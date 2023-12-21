using Dbsys.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys.Forms
{
    public partial class Frm_Staff_EditShowtimes : Form
    {
        public Frm_Staff_EditShowtimes()
        {
            InitializeComponent();
            LoadShowtimes();
        }
        private void LoadShowtimes()
        {
            using (var db = new DBSYSEntities())
            {
                // Retrieve showtime details from the view
                var showtimes = db.vw_ShowtimeDetails.ToList();

                // Bind the showtimes to the DataGridView
                dataGridViewShowtimes.DataSource = showtimes;

                // Clear existing values
                txtEditMovieID.Clear();
                txtEditShowDate.Clear();
                txtEditStartTime.Clear();
                txtEditEndTime.Clear();
                txtEditCapacity.Clear();
                txtMovieName.Clear();
                pictureBoxMovie.Image = null;
            }
        }

        private void dataGridViewShowtimes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewShowtimes.Rows[e.RowIndex];

                // Populate textboxes with showtime details
                txtEditMovieID.Text = row.Cells["movieID"].Value.ToString();
                txtEditShowDate.Text = row.Cells["showDate"].Value.ToString();
                txtEditStartTime.Text = row.Cells["startTime"].Value.ToString();
                txtEditEndTime.Text = row.Cells["endTime"].Value.ToString();
                txtEditCapacity.Text = row.Cells["capacity"].Value.ToString();

                if (int.TryParse(txtEditMovieID.Text, out int selectedMovieID))
                {
                    using (var db = new DBSYSEntities())
                    {
                        var movie = db.Movie.FirstOrDefault(m => m.movieId == selectedMovieID);

                        if (movie != null)
                        {
                            
                            txtMovieName.Text = movie.movieName;

                            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", movie.moviePathImg);

                            // Load and display the movie picture
                            if (File.Exists(imagePath))
                            {
                                pictureBoxMovie.Image = new Bitmap(imagePath);
                            }
                            else
                            {
                                pictureBoxMovie.Image = null;
                            }
                        }
                    }
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtEditMovieID.Text))
                {
                    if (int.TryParse(txtEditMovieID.Text, out int selectedMovieID))
                    {
                        using (var db = new DBSYSEntities())
                        {
                            var existingMovie = db.Movie.FirstOrDefault(m => m.movieId == selectedMovieID);

                            if (existingMovie != null)
                            {
                                //Insert Showtimes
                                db.Database.ExecuteSqlCommand(
                                    "sp_InsertShowtimes @MovieID, @ShowDate, @StartTime, @EndTime, @Capacity",
                                    new SqlParameter("@MovieID", selectedMovieID),
                                    new SqlParameter("@ShowDate", Convert.ToDateTime(txtEditShowDate.Text)),
                                    new SqlParameter("@StartTime", TimeSpan.Parse(txtEditStartTime.Text)),
                                    new SqlParameter("@EndTime", TimeSpan.Parse(txtEditEndTime.Text)),
                                    new SqlParameter("@Capacity", Convert.ToInt32(txtEditCapacity.Text))
                                );

                                MessageBox.Show("Showtime saved successfully!");
                                LoadShowtimes();
                            }
                            else
                            {
                                MessageBox.Show("Invalid MovieID. Please enter a valid MovieID.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid MovieID format. Please enter a valid integer value for MovieID.");
                    }
                }
                else
                {
                    MessageBox.Show("MovieID cannot be empty. Please enter a valid MovieID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtEditMovieID.Text))
                {
                    if (int.TryParse(txtEditMovieID.Text, out int selectedMovieID))
                    {
                        using (var db = new DBSYSEntities())
                        {
                            var existingMovie = db.Movie.FirstOrDefault(m => m.movieId == selectedMovieID);

                            if (existingMovie != null)
                            {
  
                                if (dataGridViewShowtimes.SelectedRows.Count > 0)
                                {
                                    
                                    int selectedShowtimeID = (int)dataGridViewShowtimes.SelectedRows[0].Cells["ShowtimeID"].Value;
                                    // Update showtime
                                    db.Database.ExecuteSqlCommand(
                                        "sp_UpdateShowtimes @ShowtimeID, @MovieID, @ShowDate, @StartTime, @EndTime, @Capacity",
                                        new SqlParameter("@ShowtimeID", selectedShowtimeID),
                                        new SqlParameter("@MovieID", selectedMovieID),
                                        new SqlParameter("@ShowDate", Convert.ToDateTime(txtEditShowDate.Text)),
                                        new SqlParameter("@StartTime", TimeSpan.Parse(txtEditStartTime.Text)),
                                        new SqlParameter("@EndTime", TimeSpan.Parse(txtEditEndTime.Text)),
                                        new SqlParameter("@Capacity", Convert.ToInt32(txtEditCapacity.Text))
                                    );

                                    MessageBox.Show("Showtime updated successfully!");
                                    LoadShowtimes();
                                }
                                else
                                {
                                    MessageBox.Show("Please select a showtime to update.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid MovieID. Please enter a valid MovieID.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid MovieID format. Please enter a valid integer value for MovieID.");
                    }
                }
                else
                {
                    MessageBox.Show("MovieID cannot be empty. Please enter a valid MovieID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Frm_StaffHome h = new Frm_StaffHome();
            h.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewShowtimes.SelectedRows.Count > 0)
                {
                    int selectedShowtimeID = (int)dataGridViewShowtimes.SelectedRows[0].Cells["ShowtimeID"].Value;

                    using (var db = new DBSYSEntities())
                    {
                        //delete showtime
                        db.Database.ExecuteSqlCommand("sp_DeleteShowtimes @ShowtimeID", new SqlParameter("@ShowtimeID", selectedShowtimeID));

                        MessageBox.Show("Showtime deleted successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a showtime to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
