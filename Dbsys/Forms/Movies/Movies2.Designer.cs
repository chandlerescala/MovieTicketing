
namespace Dbsys
{
    partial class Movies2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movies2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.linkLabel_m1 = new System.Windows.Forms.LinkLabel();
            this.picBox_AvailableSeat = new System.Windows.Forms.PictureBox();
            this.picBox_Buy = new System.Windows.Forms.PictureBox();
            this.picBox_m1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AvailableSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_m1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(300, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 320);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 57);
            this.label3.TabIndex = 18;
            this.label3.Text = "Director: Francis Lawrence\r\nDistributed by: Lionsgate Films\r\nCast: Rachel Zegler," +
    " Hunter Schafer, Tom Blyth\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "About";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 160);
            this.label2.TabIndex = 16;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(22, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 39);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // linkLabel_m1
            // 
            this.linkLabel_m1.AutoSize = true;
            this.linkLabel_m1.BackColor = System.Drawing.Color.White;
            this.linkLabel_m1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_m1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_m1.Location = new System.Drawing.Point(18, 306);
            this.linkLabel_m1.Name = "linkLabel_m1";
            this.linkLabel_m1.Size = new System.Drawing.Size(265, 60);
            this.linkLabel_m1.TabIndex = 19;
            this.linkLabel_m1.TabStop = true;
            this.linkLabel_m1.Text = "The Hunger Games: \r\nThe Ballad of Songbirds & Snakes\r\n(2023)";
            // 
            // picBox_AvailableSeat
            // 
            this.picBox_AvailableSeat.Image = global::Dbsys.Properties.Resources.sits;
            this.picBox_AvailableSeat.Location = new System.Drawing.Point(149, 379);
            this.picBox_AvailableSeat.Name = "picBox_AvailableSeat";
            this.picBox_AvailableSeat.Size = new System.Drawing.Size(79, 36);
            this.picBox_AvailableSeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_AvailableSeat.TabIndex = 23;
            this.picBox_AvailableSeat.TabStop = false;
            // 
            // picBox_Buy
            // 
            this.picBox_Buy.Image = global::Dbsys.Properties.Resources.Buy;
            this.picBox_Buy.Location = new System.Drawing.Point(52, 379);
            this.picBox_Buy.Name = "picBox_Buy";
            this.picBox_Buy.Size = new System.Drawing.Size(79, 36);
            this.picBox_Buy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Buy.TabIndex = 22;
            this.picBox_Buy.TabStop = false;
            // 
            // picBox_m1
            // 
            this.picBox_m1.Image = global::Dbsys.Properties.Resources.m2;
            this.picBox_m1.Location = new System.Drawing.Point(82, 110);
            this.picBox_m1.Name = "picBox_m1";
            this.picBox_m1.Size = new System.Drawing.Size(133, 181);
            this.picBox_m1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_m1.TabIndex = 18;
            this.picBox_m1.TabStop = false;
            // 
            // Movies2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dbsys.Properties.Resources.clapperboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.picBox_AvailableSeat);
            this.Controls.Add(this.picBox_Buy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.linkLabel_m1);
            this.Controls.Add(this.picBox_m1);
            this.Name = "Movies2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AvailableSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_m1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_AvailableSeat;
        private System.Windows.Forms.PictureBox picBox_Buy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.LinkLabel linkLabel_m1;
        private System.Windows.Forms.PictureBox picBox_m1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}