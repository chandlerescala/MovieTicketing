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
    public partial class Frm_Admin_ViewMovies : Form
    {
        public List<Movie> listMovie;
        private String IMG_PATH = AppDomain.CurrentDomain.BaseDirectory + "\\Image";
        private String newImagePath;
        public Frm_Admin_ViewMovies()
        {
            InitializeComponent();
            listMovie = new List<Movie>();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            Frm_AdminHome home = new Frm_AdminHome();
            home.Show();
            this.Close();
        }

        private void Frm_Admin_ViewMovies_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            loadCbBox();
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                using (var db = new DBSYSEntities())
                {
                    var movieDetails = db.vw_MovieDetails.ToList();

                    dataGridViewMovies.DataSource = movieDetails;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadCbBox()
        {
            using (var db = new DBSYSEntities())
            {

                listMovie = db.Movie.ToList();

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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected movie ID from the DataGridView
                int selectedMovieId = 0;

                if (dataGridViewMovies.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridViewMovies.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewMovies.Rows[selectedRowIndex];
                    selectedMovieId = Convert.ToInt32(selectedRow.Cells["movieId"].Value);
                }

                if (selectedMovieId > 0)
                {
                    using (var db = new DBSYSEntities())
                    {
                        Movie selectedMovie = db.Movie.Find(selectedMovieId);

                        if (selectedMovie != null)
                        {
                            selectedMovie.movieName = txtMovieName.Text;
                            selectedMovie.moviePrice = Convert.ToInt32(txtMoviePrice.Text);
                            selectedMovie.movieReleaseYear = Convert.ToInt32(txtReleaseYear.Text);
                            selectedMovie.movieGenre = txtGenre.Text;
                            selectedMovie.movieDirector = txtMovieDirector.Text;
                            selectedMovie.moviePublisher = txtMoviePublisher.Text;

                            // Check if a new image path is available
                            if (!string.IsNullOrEmpty(newImagePath))
                            {
                                // Copy the new image to the image directory
                                string newFile = $"Img_{DateTime.Now.ToString("yyyy-M-d_H-m-ss")}.jpg";
                                string newFilepath = System.IO.Path.Combine(IMG_PATH, newFile);
                                System.IO.File.Copy(newImagePath, newFilepath, true);

                                // Update the movie's image path
                                selectedMovie.moviePathImg = newFile;
                            }

                            db.SaveChanges();

                            MessageBox.Show("Movie updated successfully.");

                            LoadDataIntoDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Selected movie not found.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a movie from the DataGridView.");
                }

                newImagePath = null;
                loadCbBox();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected movie ID from the DataGridView
                int selectedMovieId = 0;

                if (dataGridViewMovies.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridViewMovies.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewMovies.Rows[selectedRowIndex];
                    selectedMovieId = Convert.ToInt32(selectedRow.Cells["movieId"].Value);
                }

                if (selectedMovieId > 0)
                {
                    using (var db = new DBSYSEntities())
                    {
                        Movie selectedMovie = db.Movie.Find(selectedMovieId);

                        if (selectedMovie != null)
                        {
                            db.Movie.Remove(selectedMovie);
                            db.SaveChanges();

                            MessageBox.Show("Movie deleted successfully.");

                            LoadDataIntoDataGridView();

                            // Clear
                            txtMovieName.Clear();
                            txtMoviePrice.Clear();
                            txtReleaseYear.Clear();
                            txtGenre.Clear();
                            txtMovieDirector.Clear();
                            txtMoviePublisher.Clear();
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("Selected movie not found.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a movie from the DataGridView.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                    openFileDialog.Title = "Select Movie Image";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        newImagePath = openFileDialog.FileName;

                        pictureBox1.Image = new Bitmap(newImagePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewMovies.Rows[e.RowIndex];

                    int selectedMovieId = Convert.ToInt32(row.Cells["movieId"].Value);

                    using (var db = new DBSYSEntities())
                    {
                        Movie selectedMovie = db.Movie.Find(selectedMovieId);

                        if (selectedMovie != null)
                        {
                            txtMovieName.Text = selectedMovie.movieName;
                            txtMoviePrice.Text = "Php " + selectedMovie.moviePrice;
                            txtReleaseYear.Text = Convert.ToString(selectedMovie.movieReleaseYear);
                            txtGenre.Text = selectedMovie.movieGenre;
                            txtMovieDirector.Text = selectedMovie.movieDirector;
                            txtMoviePublisher.Text = selectedMovie.moviePublisher;
                            pictureBox1.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Image\\" + selectedMovie.moviePathImg);
                        }
                        else
                        {
                            MessageBox.Show("Selected movie not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
