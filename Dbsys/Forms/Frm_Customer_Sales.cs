using Dbsys.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys
{
    public partial class Frm_Customer_Sales : Form
    {
        private Showtimes selectedShowtime;
        private PrintDocument printDocument;

        public Frm_Customer_Sales(Showtimes showtime)
        {
            InitializeComponent();
            selectedShowtime = showtime;
            DisplayShowtimeDetails();
            LoadSeatNumbers();

            // Initialize the PrintDocument
            printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;
        }
        private void DisplayShowtimeDetails()
        {
            // Display selected showtime details
            lblMovieName.Text = selectedShowtime.Movie.movieName;
            lblShowDate.Text = selectedShowtime.showDate.ToShortDateString();
            lblStartTime.Text = selectedShowtime.startTime.ToString();
            lblEndTime.Text = selectedShowtime.endTime.ToString();

            // Load and display the movie picture
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", selectedShowtime.Movie.moviePathImg);

            if (File.Exists(imagePath))
            {
                movieImage.Image = new Bitmap(imagePath);
            }
            else
            {
                // Set a default image or handle the case when no image is available
                movieImage.Image = null;
            }
        }

        private void LoadSeatNumbers()
        {
            // Load available seat numbers for the selected showtime
            using (var db = new DBSYSEntities())
            {
                var soldSeats = db.Sales
                    .Where(s => s.showtimeID == selectedShowtime.showtimeID)
                    .Select(s => s.seatNumber)
                    .ToList();

                var availableSeats = Enumerable.Range(1, selectedShowtime.capacity)
                    .Except(soldSeats)
                    .ToList();

                // Bind available seats to ComboBox
                cbSeatNumber.DataSource = availableSeats;
            }
        }

        private void CalculateTotalAmount()
        {
            // Calculate total amount based on ticket price and quantity
            if (int.TryParse(txtQuantity.Text, out int quantity))
            {
                decimal ticketPrice = selectedShowtime.Movie.moviePrice;
                decimal totalAmount = quantity * ticketPrice;
                lblTotalAmount.Text = $"Total Amount: Php {totalAmount:F2}";
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void btnCalculateChange_Click(object sender, EventArgs e)
        {
            // Calculate change based on paid amount
            if (decimal.TryParse(txtPaidAmount.Text, out decimal paidAmount))
            {
                if (decimal.TryParse(lblTotalAmount.Text.Split(' ')[3], out decimal totalAmount))
                {
                    decimal changeAmount = paidAmount - totalAmount;
                    lblChangeAmount.Text = $"Change: Php {changeAmount:F2}";
                }
            }
        }

        private void btnConfirmPurchase_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text) || string.IsNullOrWhiteSpace(txtPaidAmount.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Save sales transaction to the database
            using (var db = new DBSYSEntities())
            {
                int quantity = int.Parse(txtQuantity.Text);
                decimal totalAmount = quantity * selectedShowtime.Movie.moviePrice;
                decimal paidAmount = decimal.Parse(txtPaidAmount.Text);
                decimal changeAmount = paidAmount - totalAmount;

                // Use the stored procedure to insert the sale
                db.Database.ExecuteSqlCommand(
                    "sp_InsertSales @ShowtimeID, @CustomerName, @TransactionDate, @MovieID, @SeatNumber, @Quantity, @TotalAmount, @PaidAmount, @ChangeAmount",
                    new SqlParameter("@ShowtimeID", selectedShowtime.showtimeID),
                    new SqlParameter("@CustomerName", txtCustomerName.Text),
                    new SqlParameter("@TransactionDate", DateTime.Now),
                    new SqlParameter("@MovieID", selectedShowtime.movieID),
                    new SqlParameter("@SeatNumber", (int)cbSeatNumber.SelectedItem),
                    new SqlParameter("@Quantity", quantity),
                    new SqlParameter("@TotalAmount", totalAmount),
                    new SqlParameter("@PaidAmount", paidAmount),
                    new SqlParameter("@ChangeAmount", changeAmount)
                );

                MessageBox.Show("Transaction completed successfully!");

                DialogResult result = MessageBox.Show("Do you want to return to the home page and receive the receipt?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    PrintDialog printDialog = new PrintDialog();
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument.PrinterSettings = printDialog.PrinterSettings;
                        printDocument.Print();
                    }

                    Frm_CustomerHome h = new Frm_CustomerHome();
                    h.Show();
                    this.Close(); 
                }
                else
                {
                    //txtCustomerName.Text = "";
                    //txtQuantity.Text = "";
                    //txtPaidAmount.Text = "";
                    //lblChangeAmount.Text = "";
                    //cbSeatNumber.SelectedIndex = -1; 
                    //txtCustomerName.Focus();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            if (txtCustomerName == null || txtQuantity == null || cbSeatNumber == null || lblTotalAmount == null)
            {
                MessageBox.Show("Error: Controls not properly initialized.");
                return;
            }

            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 12, FontStyle.Regular);
            Brush brush = Brushes.Black;

            float startX = 10;
            float startY = 10;
            float lineHeight = normalFont.GetHeight() + 2;

            // Print header
            e.Graphics.DrawString("===== Sales Receipt =====", headerFont, brush, startX, startY);
            startY += lineHeight * 2;

            // Print customer information
            e.Graphics.DrawString($"Customer: {txtCustomerName.Text}", normalFont, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Date: {DateTime.Now}", normalFont, brush, startX, startY);
            startY += lineHeight;

            // Print movie details
            e.Graphics.DrawString($"Movie: {selectedShowtime.Movie.movieName}", normalFont, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Show Date: {selectedShowtime.showDate.ToShortDateString()}", normalFont, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Start Time: {selectedShowtime.startTime}", normalFont, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"End Time: {selectedShowtime.endTime}", normalFont, brush, startX, startY);
            startY += lineHeight;

            // Print ticket details
            int seatNumber = (int)cbSeatNumber.SelectedItem;
            int quantity = int.Parse(txtQuantity.Text);
            decimal totalAmount = decimal.Parse(lblTotalAmount.Text.Split(' ')[3]);

            e.Graphics.DrawString($"Seat Number: {seatNumber}", normalFont, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Quantity: {quantity}", normalFont, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Total Amount: Php {totalAmount:F2}", normalFont, brush, startX, startY);
            startY += lineHeight;

            // Print footer
            e.Graphics.DrawString("==========================", headerFont, brush, startX, startY);

            MessageBox.Show("Printed Successfully!", "Sales Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                printDocument.Print();
            }
        }
    }
}
