using Dbsys.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys
{
    public partial class Frm_Customer_ClosedShow : Form
    {
        public List<Movie> listMovie;
        public Frm_Customer_ClosedShow()
        {
            InitializeComponent();
            listMovie = new List<Movie>();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            Frm_CustomerHome home = new Frm_CustomerHome();
            home.Show();
            this.Close();
        }

        private void Frm_Admin_ViewMovies_Load(object sender, EventArgs e)
        {
            LoadClosedShowMovies();
        }

        private void LoadClosedShowMovies()
        {
            using (var db = new DBSYSEntities())
            {
                // Get the previous date
                DateTime previousDate = DateTime.Today.AddDays(-7);

                // Get movies with showtimes for the previous date
                listMovie = db.Showtimes
                    .Where(s => s.showDate < DateTime.Today && s.showDate >= previousDate)
                    .Select(s => s.Movie)
                    .Distinct()
                    .ToList();

                cbMovies.DisplayMember = "movieName";
                cbMovies.ValueMember = "movieId";
                cbMovies.DataSource = listMovie;
            }
        }

        private void cbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedId = Convert.ToInt32(cbMovies.SelectedValue);

                Movie selectedMovie = listMovie.Where(c => c.movieId == selectedId).FirstOrDefault();

                txtMovieName.Text = selectedMovie.movieName;
                txtMoviePrice.Text = "Php " + selectedMovie.moviePrice;
                txtReleaseYear.Text = Convert.ToString(selectedMovie.movieReleaseYear);
                txtGenre.Text = selectedMovie.movieGenre;
                txtMovieDirector.Text = selectedMovie.movieDirector;
                txtMoviePublisher.Text = selectedMovie.moviePublisher;
                pictureBox1.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Image\\" + selectedMovie.moviePathImg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
