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
            this.transactionHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel_AddMovie = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox_History = new System.Windows.Forms.PictureBox();
            this.picBox_EditShowtimes = new System.Windows.Forms.PictureBox();
            this.txtLoggedUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.picBox_UserInfo = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_EditShowtimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_UserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addMovieToolStripMenuItem,
            this.transactionHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
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
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // linkLabel_AddMovie
            // 
            this.linkLabel_AddMovie.AutoSize = true;
            this.linkLabel_AddMovie.BackColor = System.Drawing.Color.White;
            this.linkLabel_AddMovie.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_AddMovie.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_AddMovie.Location = new System.Drawing.Point(163, 244);
            this.linkLabel_AddMovie.Name = "linkLabel_AddMovie";
            this.linkLabel_AddMovie.Size = new System.Drawing.Size(95, 20);
            this.linkLabel_AddMovie.TabIndex = 6;
            this.linkLabel_AddMovie.TabStop = true;
            this.linkLabel_AddMovie.Text = "Showtimes";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(228, 373);
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
            this.picBox_History.Location = new System.Drawing.Point(244, 272);
            this.picBox_History.Name = "picBox_History";
            this.picBox_History.Size = new System.Drawing.Size(121, 98);
            this.picBox_History.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_History.TabIndex = 4;
            this.picBox_History.TabStop = false;
            this.picBox_History.Click += new System.EventHandler(this.picBox_History_Click);
            // 
            // picBox_EditShowtimes
            // 
            this.picBox_EditShowtimes.Image = global::Dbsys.Properties.Resources.Showtimes;
            this.picBox_EditShowtimes.Location = new System.Drawing.Point(149, 143);
            this.picBox_EditShowtimes.Name = "picBox_EditShowtimes";
            this.picBox_EditShowtimes.Size = new System.Drawing.Size(121, 98);
            this.picBox_EditShowtimes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_EditShowtimes.TabIndex = 2;
            this.picBox_EditShowtimes.TabStop = false;
            this.picBox_EditShowtimes.Click += new System.EventHandler(this.picBox_AddMovie_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "CINESWIFT";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(337, 244);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 20);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "User Information";
            // 
            // picBox_UserInfo
            // 
            this.picBox_UserInfo.Image = global::Dbsys.Properties.Resources.package;
            this.picBox_UserInfo.Location = new System.Drawing.Point(348, 143);
            this.picBox_UserInfo.Name = "picBox_UserInfo";
            this.picBox_UserInfo.Size = new System.Drawing.Size(121, 98);
            this.picBox_UserInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_UserInfo.TabIndex = 14;
            this.picBox_UserInfo.TabStop = false;
            this.picBox_UserInfo.Click += new System.EventHandler(this.picBox_UserInfo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Dbsys.Properties.Resources.package;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 20);
            this.toolStripMenuItem1.Text = " User Information";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Frm_StaffHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dbsys.Properties.Resources.movie_objects_with_space_top;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.picBox_UserInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoggedUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel_AddMovie);
            this.Controls.Add(this.picBox_History);
            this.Controls.Add(this.picBox_EditShowtimes);
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
            ((System.ComponentModel.ISupportInitialize)(this.picBox_EditShowtimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_UserInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBox_EditShowtimes;
        private System.Windows.Forms.PictureBox picBox_History;
        private System.Windows.Forms.LinkLabel linkLabel_AddMovie;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLoggedUser;
        private System.Windows.Forms.ToolStripMenuItem addMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox picBox_UserInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}