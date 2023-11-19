using Dbsys.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys
{
    public partial class Frm_Admin_AddMovie : Form
    {
        public bool hasChange = false;
        private String IMG_PATH = AppDomain.CurrentDomain.BaseDirectory + "\\Image";
        public Frm_Admin_AddMovie()
        {
            InitializeComponent();
            //
            if (!Directory.Exists(IMG_PATH))
                Directory.CreateDirectory(IMG_PATH);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Frm_AdminHome home = new Frm_AdminHome();
            home.Show();
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            String path = ofd.FileName;

            labelPath.Text = path;
            pictureBox1.Image = new Bitmap(path);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                String oldpath = labelPath.Text;

                String newFile = $"Img_{DateTime.Now.ToString("yyyy-M-d_H-m-ss")}.jpg";

                String newFilepath = Path.Combine(IMG_PATH, newFile);

                System.IO.File.Copy(oldpath, newFilepath);
                //MessageBox.Show("Uploaded!");


                using (var db = new DBSYSEntities())
                {
                    var newMovie = new Movie();
                    newMovie.movieName = txtMovieName.Text;
                    newMovie.moviePrice = Convert.ToInt32(txtMoviePrice.Text);
                    newMovie.movieReleaseYear = Convert.ToInt32(txtReleaseYear.Text);
                    newMovie.movieGenre = txtGenre.Text;
                    newMovie.movieDirector = txtMovieDirector.Text;
                    newMovie.moviePublisher = txtMoviePublisher.Text;
                    newMovie.moviePathImg = newFile;

                    db.Movie.Add(newMovie);
                    db.SaveChanges();

                    hasChange = true;
                }
                MessageBox.Show("Uploaded!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
