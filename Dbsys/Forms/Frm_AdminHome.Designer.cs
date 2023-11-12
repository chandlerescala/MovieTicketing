namespace Dbsys.Forms
{
    partial class Frm_AdminHome
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
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBox_History = new System.Windows.Forms.PictureBox();
            this.picBox_ViewMovie = new System.Windows.Forms.PictureBox();
            this.picBox_AddMovie = new System.Windows.Forms.PictureBox();
            this.picBox_AdminLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ViewMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AddMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AdminLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // picBox_History
            // 
            this.picBox_History.Image = global::Dbsys.Properties.Resources.history;
            this.picBox_History.Location = new System.Drawing.Point(338, 248);
            this.picBox_History.Name = "picBox_History";
            this.picBox_History.Size = new System.Drawing.Size(121, 98);
            this.picBox_History.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_History.TabIndex = 4;
            this.picBox_History.TabStop = false;
            // 
            // picBox_ViewMovie
            // 
            this.picBox_ViewMovie.Image = global::Dbsys.Properties.Resources.package;
            this.picBox_ViewMovie.Location = new System.Drawing.Point(141, 248);
            this.picBox_ViewMovie.Name = "picBox_ViewMovie";
            this.picBox_ViewMovie.Size = new System.Drawing.Size(121, 98);
            this.picBox_ViewMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_ViewMovie.TabIndex = 3;
            this.picBox_ViewMovie.TabStop = false;
            // 
            // picBox_AddMovie
            // 
            this.picBox_AddMovie.Image = global::Dbsys.Properties.Resources.edit2;
            this.picBox_AddMovie.Location = new System.Drawing.Point(141, 125);
            this.picBox_AddMovie.Name = "picBox_AddMovie";
            this.picBox_AddMovie.Size = new System.Drawing.Size(121, 98);
            this.picBox_AddMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_AddMovie.TabIndex = 2;
            this.picBox_AddMovie.TabStop = false;
            // 
            // picBox_AdminLogin
            // 
            this.picBox_AdminLogin.Image = global::Dbsys.Properties.Resources.profile;
            this.picBox_AdminLogin.Location = new System.Drawing.Point(338, 125);
            this.picBox_AdminLogin.Name = "picBox_AdminLogin";
            this.picBox_AdminLogin.Size = new System.Drawing.Size(121, 98);
            this.picBox_AdminLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_AdminLogin.TabIndex = 1;
            this.picBox_AdminLogin.TabStop = false;
            this.picBox_AdminLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "MOVIE TICKETING";
            // 
            // Frm_AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dbsys.Properties.Resources.b81;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_History);
            this.Controls.Add(this.picBox_ViewMovie);
            this.Controls.Add(this.picBox_AddMovie);
            this.Controls.Add(this.picBox_AdminLogin);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frm_AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ViewMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AddMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AdminLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBox_AdminLogin;
        private System.Windows.Forms.PictureBox picBox_AddMovie;
        private System.Windows.Forms.PictureBox picBox_ViewMovie;
        private System.Windows.Forms.PictureBox picBox_History;
        private System.Windows.Forms.Label label1;
    }
}