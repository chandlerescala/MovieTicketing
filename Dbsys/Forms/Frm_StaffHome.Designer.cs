namespace Dbsys
{
    partial class Frm_StaffHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_AddMovie = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ViewAccount = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox_History = new System.Windows.Forms.PictureBox();
            this.picBox_ViewMovie = new System.Windows.Forms.PictureBox();
            this.picBox_EditShowtimes = new System.Windows.Forms.PictureBox();
            this.picBox_AdminLogin = new System.Windows.Forms.PictureBox();
            this.txtLoggedUser = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ViewMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_EditShowtimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AdminLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addMovieToolStripMenuItem,
            this.viewMoviesToolStripMenuItem,
            this.accountManagementToolStripMenuItem,
            this.transactionHistoryToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileSettingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // profileSettingsToolStripMenuItem
            // 
            this.profileSettingsToolStripMenuItem.Image = global::Dbsys.Properties.Resources.profile;
            this.profileSettingsToolStripMenuItem.Name = "profileSettingsToolStripMenuItem";
            this.profileSettingsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.profileSettingsToolStripMenuItem.Text = "Profile Settings";
            this.profileSettingsToolStripMenuItem.Click += new System.EventHandler(this.profileSettingsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::Dbsys.Properties.Resources.Log_out;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click_1);
            // 
            // addMovieToolStripMenuItem
            // 
            this.addMovieToolStripMenuItem.Image = global::Dbsys.Properties.Resources.Showtimes;
            this.addMovieToolStripMenuItem.Name = "addMovieToolStripMenuItem";
            this.addMovieToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.addMovieToolStripMenuItem.Text = "Showtimes";
            this.addMovieToolStripMenuItem.Click += new System.EventHandler(this.addMovieToolStripMenuItem_Click);
            // 
            // viewMoviesToolStripMenuItem
            // 
            this.viewMoviesToolStripMenuItem.Image = global::Dbsys.Properties.Resources.ticket;
            this.viewMoviesToolStripMenuItem.Name = "viewMoviesToolStripMenuItem";
            this.viewMoviesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.viewMoviesToolStripMenuItem.Text = "Tickets";
            this.viewMoviesToolStripMenuItem.Click += new System.EventHandler(this.viewMoviesToolStripMenuItem_Click);
            // 
            // accountManagementToolStripMenuItem
            // 
            this.accountManagementToolStripMenuItem.Image = global::Dbsys.Properties.Resources.sales;
            this.accountManagementToolStripMenuItem.Name = "accountManagementToolStripMenuItem";
            this.accountManagementToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.accountManagementToolStripMenuItem.Text = "Sales";
            this.accountManagementToolStripMenuItem.Click += new System.EventHandler(this.accountManagementToolStripMenuItem_Click);
            // 
            // transactionHistoryToolStripMenuItem
            // 
            this.transactionHistoryToolStripMenuItem.Image = global::Dbsys.Properties.Resources.history;
            this.transactionHistoryToolStripMenuItem.Name = "transactionHistoryToolStripMenuItem";
            this.transactionHistoryToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.transactionHistoryToolStripMenuItem.Text = "Transaction History";
            this.transactionHistoryToolStripMenuItem.Click += new System.EventHandler(this.transactionHistoryToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = global::Dbsys.Properties.Resources.setting_2;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Image = global::Dbsys.Properties.Resources.profile2;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "MOVIE TICKETING";
            // 
            // linkLabel_AddMovie
            // 
            this.linkLabel_AddMovie.AutoSize = true;
            this.linkLabel_AddMovie.BackColor = System.Drawing.Color.White;
            this.linkLabel_AddMovie.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_AddMovie.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_AddMovie.Location = new System.Drawing.Point(158, 251);
            this.linkLabel_AddMovie.Name = "linkLabel_AddMovie";
            this.linkLabel_AddMovie.Size = new System.Drawing.Size(95, 20);
            this.linkLabel_AddMovie.TabIndex = 6;
            this.linkLabel_AddMovie.TabStop = true;
            this.linkLabel_AddMovie.Text = "Showtimes";
            // 
            // linkLabel_ViewAccount
            // 
            this.linkLabel_ViewAccount.AutoSize = true;
            this.linkLabel_ViewAccount.BackColor = System.Drawing.Color.White;
            this.linkLabel_ViewAccount.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_ViewAccount.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_ViewAccount.Location = new System.Drawing.Point(365, 251);
            this.linkLabel_ViewAccount.Name = "linkLabel_ViewAccount";
            this.linkLabel_ViewAccount.Size = new System.Drawing.Size(64, 20);
            this.linkLabel_ViewAccount.TabIndex = 7;
            this.linkLabel_ViewAccount.TabStop = true;
            this.linkLabel_ViewAccount.Text = "Tickets";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(178, 391);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sales";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(325, 391);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(163, 20);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Transaction History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dbsys.Properties.Resources.profile1;
            this.pictureBox1.Location = new System.Drawing.Point(543, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // picBox_History
            // 
            this.picBox_History.Image = global::Dbsys.Properties.Resources.history;
            this.picBox_History.Location = new System.Drawing.Point(341, 290);
            this.picBox_History.Name = "picBox_History";
            this.picBox_History.Size = new System.Drawing.Size(121, 98);
            this.picBox_History.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_History.TabIndex = 4;
            this.picBox_History.TabStop = false;
            this.picBox_History.Click += new System.EventHandler(this.picBox_History_Click);
            // 
            // picBox_ViewMovie
            // 
            this.picBox_ViewMovie.Image = global::Dbsys.Properties.Resources.sales;
            this.picBox_ViewMovie.Location = new System.Drawing.Point(144, 290);
            this.picBox_ViewMovie.Name = "picBox_ViewMovie";
            this.picBox_ViewMovie.Size = new System.Drawing.Size(121, 98);
            this.picBox_ViewMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_ViewMovie.TabIndex = 3;
            this.picBox_ViewMovie.TabStop = false;
            this.picBox_ViewMovie.Click += new System.EventHandler(this.picBox_ViewMovie_Click);
            // 
            // picBox_EditShowtimes
            // 
            this.picBox_EditShowtimes.Image = global::Dbsys.Properties.Resources.Showtimes;
            this.picBox_EditShowtimes.Location = new System.Drawing.Point(144, 150);
            this.picBox_EditShowtimes.Name = "picBox_EditShowtimes";
            this.picBox_EditShowtimes.Size = new System.Drawing.Size(121, 98);
            this.picBox_EditShowtimes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_EditShowtimes.TabIndex = 2;
            this.picBox_EditShowtimes.TabStop = false;
            this.picBox_EditShowtimes.Click += new System.EventHandler(this.picBox_AddMovie_Click);
            // 
            // picBox_AdminLogin
            // 
            this.picBox_AdminLogin.Image = global::Dbsys.Properties.Resources.ticket;
            this.picBox_AdminLogin.Location = new System.Drawing.Point(341, 150);
            this.picBox_AdminLogin.Name = "picBox_AdminLogin";
            this.picBox_AdminLogin.Size = new System.Drawing.Size(121, 98);
            this.picBox_AdminLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_AdminLogin.TabIndex = 1;
            this.picBox_AdminLogin.TabStop = false;
            this.picBox_AdminLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtLoggedUser
            // 
            this.txtLoggedUser.Location = new System.Drawing.Point(437, 42);
            this.txtLoggedUser.Name = "txtLoggedUser";
            this.txtLoggedUser.ReadOnly = true;
            this.txtLoggedUser.Size = new System.Drawing.Size(100, 20);
            this.txtLoggedUser.TabIndex = 11;
            this.txtLoggedUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_StaffHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dbsys.Properties.Resources.movie_objects_with_space_top;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.txtLoggedUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel_ViewAccount);
            this.Controls.Add(this.linkLabel_AddMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_History);
            this.Controls.Add(this.picBox_ViewMovie);
            this.Controls.Add(this.picBox_EditShowtimes);
            this.Controls.Add(this.picBox_AdminLogin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_StaffHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home(Staff)";
            this.Load += new System.EventHandler(this.Frm_AdminHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ViewMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_EditShowtimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AdminLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBox_AdminLogin;
        private System.Windows.Forms.PictureBox picBox_EditShowtimes;
        private System.Windows.Forms.PictureBox picBox_ViewMovie;
        private System.Windows.Forms.PictureBox picBox_History;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_AddMovie;
        private System.Windows.Forms.LinkLabel linkLabel_ViewAccount;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLoggedUser;
        private System.Windows.Forms.ToolStripMenuItem addMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
    }
}