namespace Dbsys.Forms
{
    partial class Frm_Admin_AddMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richText_MovieInformation = new System.Windows.Forms.RichTextBox();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.dateTime_StartShowing = new System.Windows.Forms.DateTimePicker();
            this.dateTime_EndShowing = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtMovieDirector = new System.Windows.Forms.TextBox();
            this.txtMoviePublisher = new System.Windows.Forms.TextBox();
            this.btn_AddMovie = new System.Windows.Forms.Button();
            this.btn_UpdateMovie = new System.Windows.Forms.Button();
            this.btn_DeleteMovie = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Movie Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Movie Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Movie Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Movie Director";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Start Showing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "End Showing";
            // 
            // richText_MovieInformation
            // 
            this.richText_MovieInformation.Location = new System.Drawing.Point(195, 158);
            this.richText_MovieInformation.Name = "richText_MovieInformation";
            this.richText_MovieInformation.Size = new System.Drawing.Size(233, 115);
            this.richText_MovieInformation.TabIndex = 12;
            this.richText_MovieInformation.Text = "";
            // 
            // txtMovieId
            // 
            this.txtMovieId.Location = new System.Drawing.Point(195, 66);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(96, 20);
            this.txtMovieId.TabIndex = 13;
            // 
            // dateTime_StartShowing
            // 
            this.dateTime_StartShowing.Location = new System.Drawing.Point(195, 366);
            this.dateTime_StartShowing.Name = "dateTime_StartShowing";
            this.dateTime_StartShowing.Size = new System.Drawing.Size(200, 20);
            this.dateTime_StartShowing.TabIndex = 14;
            // 
            // dateTime_EndShowing
            // 
            this.dateTime_EndShowing.Location = new System.Drawing.Point(195, 413);
            this.dateTime_EndShowing.Name = "dateTime_EndShowing";
            this.dateTime_EndShowing.Size = new System.Drawing.Size(200, 20);
            this.dateTime_EndShowing.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(447, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 369);
            this.dataGridView1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Movie Publisher";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(195, 113);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(186, 20);
            this.txtMovieName.TabIndex = 18;
            // 
            // txtMovieDirector
            // 
            this.txtMovieDirector.Location = new System.Drawing.Point(195, 285);
            this.txtMovieDirector.Name = "txtMovieDirector";
            this.txtMovieDirector.Size = new System.Drawing.Size(186, 20);
            this.txtMovieDirector.TabIndex = 19;
            // 
            // txtMoviePublisher
            // 
            this.txtMoviePublisher.Location = new System.Drawing.Point(195, 328);
            this.txtMoviePublisher.Name = "txtMoviePublisher";
            this.txtMoviePublisher.Size = new System.Drawing.Size(186, 20);
            this.txtMoviePublisher.TabIndex = 20;
            // 
            // btn_AddMovie
            // 
            this.btn_AddMovie.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMovie.Location = new System.Drawing.Point(489, 450);
            this.btn_AddMovie.Name = "btn_AddMovie";
            this.btn_AddMovie.Size = new System.Drawing.Size(100, 37);
            this.btn_AddMovie.TabIndex = 21;
            this.btn_AddMovie.Text = "Add";
            this.btn_AddMovie.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateMovie
            // 
            this.btn_UpdateMovie.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateMovie.Location = new System.Drawing.Point(635, 450);
            this.btn_UpdateMovie.Name = "btn_UpdateMovie";
            this.btn_UpdateMovie.Size = new System.Drawing.Size(100, 37);
            this.btn_UpdateMovie.TabIndex = 22;
            this.btn_UpdateMovie.Text = "Update";
            this.btn_UpdateMovie.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteMovie
            // 
            this.btn_DeleteMovie.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteMovie.Location = new System.Drawing.Point(772, 450);
            this.btn_DeleteMovie.Name = "btn_DeleteMovie";
            this.btn_DeleteMovie.Size = new System.Drawing.Size(100, 37);
            this.btn_DeleteMovie.TabIndex = 23;
            this.btn_DeleteMovie.Text = "Delete";
            this.btn_DeleteMovie.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 39);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Frm_Admin_AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dbsys.Properties.Resources.movie_objects_with_space_top;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(931, 507);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_DeleteMovie);
            this.Controls.Add(this.btn_UpdateMovie);
            this.Controls.Add(this.btn_AddMovie);
            this.Controls.Add(this.txtMoviePublisher);
            this.Controls.Add(this.txtMovieDirector);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTime_EndShowing);
            this.Controls.Add(this.dateTime_StartShowing);
            this.Controls.Add(this.txtMovieId);
            this.Controls.Add(this.richText_MovieInformation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Admin_AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Movie(Admin)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richText_MovieInformation;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.DateTimePicker dateTime_StartShowing;
        private System.Windows.Forms.DateTimePicker dateTime_EndShowing;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.TextBox txtMovieDirector;
        private System.Windows.Forms.TextBox txtMoviePublisher;
        private System.Windows.Forms.Button btn_AddMovie;
        private System.Windows.Forms.Button btn_UpdateMovie;
        private System.Windows.Forms.Button btn_DeleteMovie;
        private System.Windows.Forms.Button btnBack;
    }
}