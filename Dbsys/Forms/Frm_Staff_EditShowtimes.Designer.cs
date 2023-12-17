namespace Dbsys.Forms
{
    partial class Frm_Staff_EditShowtimes
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
            this.dataGridViewShowtimes = new System.Windows.Forms.DataGridView();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtEditMovieID = new System.Windows.Forms.TextBox();
            this.txtEditShowDate = new System.Windows.Forms.TextBox();
            this.txtEditStartTime = new System.Windows.Forms.TextBox();
            this.txtEditEndTime = new System.Windows.Forms.TextBox();
            this.txtEditCapacity = new System.Windows.Forms.TextBox();
            this.pictureBoxMovie = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowtimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowtimes
            // 
            this.dataGridViewShowtimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowtimes.Location = new System.Drawing.Point(281, 159);
            this.dataGridViewShowtimes.Name = "dataGridViewShowtimes";
            this.dataGridViewShowtimes.Size = new System.Drawing.Size(487, 244);
            this.dataGridViewShowtimes.TabIndex = 0;
            this.dataGridViewShowtimes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowtimes_CellClick);
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(387, 124);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(216, 20);
            this.txtMovieName.TabIndex = 1;
            // 
            // txtEditMovieID
            // 
            this.txtEditMovieID.Location = new System.Drawing.Point(154, 179);
            this.txtEditMovieID.Name = "txtEditMovieID";
            this.txtEditMovieID.Size = new System.Drawing.Size(100, 20);
            this.txtEditMovieID.TabIndex = 2;
            // 
            // txtEditShowDate
            // 
            this.txtEditShowDate.Location = new System.Drawing.Point(154, 220);
            this.txtEditShowDate.Name = "txtEditShowDate";
            this.txtEditShowDate.Size = new System.Drawing.Size(100, 20);
            this.txtEditShowDate.TabIndex = 3;
            // 
            // txtEditStartTime
            // 
            this.txtEditStartTime.Location = new System.Drawing.Point(154, 258);
            this.txtEditStartTime.Name = "txtEditStartTime";
            this.txtEditStartTime.Size = new System.Drawing.Size(100, 20);
            this.txtEditStartTime.TabIndex = 4;
            // 
            // txtEditEndTime
            // 
            this.txtEditEndTime.Location = new System.Drawing.Point(154, 304);
            this.txtEditEndTime.Name = "txtEditEndTime";
            this.txtEditEndTime.Size = new System.Drawing.Size(100, 20);
            this.txtEditEndTime.TabIndex = 5;
            // 
            // txtEditCapacity
            // 
            this.txtEditCapacity.Location = new System.Drawing.Point(154, 349);
            this.txtEditCapacity.Name = "txtEditCapacity";
            this.txtEditCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtEditCapacity.TabIndex = 6;
            // 
            // pictureBoxMovie
            // 
            this.pictureBoxMovie.Location = new System.Drawing.Point(609, 24);
            this.pictureBoxMovie.Name = "pictureBoxMovie";
            this.pictureBoxMovie.Size = new System.Drawing.Size(159, 120);
            this.pictureBoxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMovie.TabIndex = 8;
            this.pictureBoxMovie.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Movie ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Show Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Movie Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "End Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Edit Capacity";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(31, 394);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 27);
            this.btn_Save.TabIndex = 22;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(145, 394);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(96, 27);
            this.btn_Update.TabIndex = 23;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Frm_Staff_EditShowtimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxMovie);
            this.Controls.Add(this.txtEditCapacity);
            this.Controls.Add(this.txtEditEndTime);
            this.Controls.Add(this.txtEditStartTime);
            this.Controls.Add(this.txtEditShowDate);
            this.Controls.Add(this.txtEditMovieID);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.dataGridViewShowtimes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Staff_EditShowtimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Staff_EditShowtimes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowtimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowtimes;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.TextBox txtEditMovieID;
        private System.Windows.Forms.TextBox txtEditShowDate;
        private System.Windows.Forms.TextBox txtEditStartTime;
        private System.Windows.Forms.TextBox txtEditEndTime;
        private System.Windows.Forms.TextBox txtEditCapacity;
        private System.Windows.Forms.PictureBox pictureBoxMovie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Update;
    }
}