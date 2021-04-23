    namespace Staywatch_framwork_
{
    partial class Form_dahsboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_dahsboard));
            this.label1 = new System.Windows.Forms.Label();
            this.Submit_search_btn = new System.Windows.Forms.Button();
            this.Name_static = new System.Windows.Forms.Label();
            this.Name_D = new System.Windows.Forms.Label();
            this.Quit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Account_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Booking_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateD = new System.Windows.Forms.Label();
            this.Date_s = new System.Windows.Forms.Label();
            this.Time_d = new System.Windows.Forms.Label();
            this.Time_s = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bookings1 = new Staywatch_framwork_.Bookings();
            this.Search = new Staywatch_framwork_.CeLearningTextbox();
            this.account_Details1 = new Staywatch_framwork_.Account_Details();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(399, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 120);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staywatch";
            // 
            // Submit_search_btn
            // 
            this.Submit_search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Submit_search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_search_btn.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_search_btn.ForeColor = System.Drawing.Color.White;
            this.Submit_search_btn.Location = new System.Drawing.Point(531, 410);
            this.Submit_search_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Submit_search_btn.Name = "Submit_search_btn";
            this.Submit_search_btn.Size = new System.Drawing.Size(228, 46);
            this.Submit_search_btn.TabIndex = 6;
            this.Submit_search_btn.Text = "Search";
            this.Submit_search_btn.UseVisualStyleBackColor = false;
            this.Submit_search_btn.Click += new System.EventHandler(this.Submit_search_btn_Click);
            // 
            // Name_static
            // 
            this.Name_static.AutoSize = true;
            this.Name_static.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_static.ForeColor = System.Drawing.Color.White;
            this.Name_static.Location = new System.Drawing.Point(58, 54);
            this.Name_static.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name_static.Name = "Name_static";
            this.Name_static.Size = new System.Drawing.Size(104, 26);
            this.Name_static.TabIndex = 8;
            this.Name_static.Text = "Welcome";
            // 
            // Name_D
            // 
            this.Name_D.AutoSize = true;
            this.Name_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_D.ForeColor = System.Drawing.Color.White;
            this.Name_D.Location = new System.Drawing.Point(58, 80);
            this.Name_D.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name_D.Name = "Name_D";
            this.Name_D.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name_D.Size = new System.Drawing.Size(117, 26);
            this.Name_D.TabIndex = 9;
            this.Name_D.Text = "Shreetheja";
            this.Name_D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quit_btn
            // 
            this.Quit_btn.BackColor = System.Drawing.Color.Red;
            this.Quit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quit_btn.Location = new System.Drawing.Point(993, 10);
            this.Quit_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Quit_btn.Name = "Quit_btn";
            this.Quit_btn.Size = new System.Drawing.Size(29, 28);
            this.Quit_btn.TabIndex = 10;
            this.Quit_btn.Text = "X";
            this.Quit_btn.UseVisualStyleBackColor = false;
            this.Quit_btn.Click += new System.EventHandler(this.Quit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 718);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 109);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Account_btn);
            this.groupBox1.Controls.Add(this.Logout_btn);
            this.groupBox1.Controls.Add(this.Name_static);
            this.groupBox1.Controls.Add(this.Booking_btn);
            this.groupBox1.Controls.Add(this.Name_D);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 266);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(218, 349);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // Account_btn
            // 
            this.Account_btn.BackColor = System.Drawing.Color.White;
            this.Account_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Account_btn.FlatAppearance.BorderSize = 0;
            this.Account_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Account_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account_btn.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account_btn.ForeColor = System.Drawing.Color.Black;
            this.Account_btn.Location = new System.Drawing.Point(4, 124);
            this.Account_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Account_btn.Name = "Account_btn";
            this.Account_btn.Size = new System.Drawing.Size(209, 38);
            this.Account_btn.TabIndex = 12;
            this.Account_btn.Text = "Account";
            this.Account_btn.UseVisualStyleBackColor = false;
            this.Account_btn.Click += new System.EventHandler(this.Account_btn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.Red;
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout_btn.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(53, 245);
            this.Logout_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(104, 33);
            this.Logout_btn.TabIndex = 12;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Booking_btn
            // 
            this.Booking_btn.BackColor = System.Drawing.Color.White;
            this.Booking_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Booking_btn.FlatAppearance.BorderSize = 0;
            this.Booking_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Booking_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Booking_btn.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_btn.ForeColor = System.Drawing.Color.Black;
            this.Booking_btn.Location = new System.Drawing.Point(4, 167);
            this.Booking_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Booking_btn.Name = "Booking_btn";
            this.Booking_btn.Size = new System.Drawing.Size(209, 36);
            this.Booking_btn.TabIndex = 12;
            this.Booking_btn.Text = "Booking";
            this.Booking_btn.UseVisualStyleBackColor = false;
            this.Booking_btn.Click += new System.EventHandler(this.Booking_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.DateD);
            this.panel2.Controls.Add(this.Date_s);
            this.panel2.Controls.Add(this.Time_d);
            this.panel2.Controls.Add(this.Time_s);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(237, 678);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 40);
            this.panel2.TabIndex = 12;
            // 
            // DateD
            // 
            this.DateD.AutoSize = true;
            this.DateD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateD.ForeColor = System.Drawing.Color.White;
            this.DateD.Location = new System.Drawing.Point(47, 6);
            this.DateD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateD.Name = "DateD";
            this.DateD.Size = new System.Drawing.Size(85, 19);
            this.DateD.TabIndex = 15;
            this.DateD.Text = "21/20/2000";
            // 
            // Date_s
            // 
            this.Date_s.AutoSize = true;
            this.Date_s.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_s.ForeColor = System.Drawing.Color.White;
            this.Date_s.Location = new System.Drawing.Point(2, 6);
            this.Date_s.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Date_s.Name = "Date_s";
            this.Date_s.Size = new System.Drawing.Size(44, 19);
            this.Date_s.TabIndex = 14;
            this.Date_s.Text = "Date:";
            // 
            // Time_d
            // 
            this.Time_d.AutoSize = true;
            this.Time_d.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_d.ForeColor = System.Drawing.Color.White;
            this.Time_d.Location = new System.Drawing.Point(681, 6);
            this.Time_d.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time_d.Name = "Time_d";
            this.Time_d.Size = new System.Drawing.Size(65, 19);
            this.Time_d.TabIndex = 13;
            this.Time_d.Text = "20:14:35";
            // 
            // Time_s
            // 
            this.Time_s.AutoSize = true;
            this.Time_s.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_s.ForeColor = System.Drawing.Color.White;
            this.Time_s.Location = new System.Drawing.Point(634, 6);
            this.Time_s.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time_s.Name = "Time_s";
            this.Time_s.Size = new System.Drawing.Size(45, 19);
            this.Time_s.TabIndex = 1;
            this.Time_s.Text = "Time:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bookings1
            // 
            this.bookings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.bookings1.Location = new System.Drawing.Point(310, 107);
            this.bookings1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookings1.Name = "bookings1";
            this.bookings1.Size = new System.Drawing.Size(559, 438);
            this.bookings1.TabIndex = 13;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.BorderColor = System.Drawing.Color.Transparent;
            this.Search.BorderSize = 1;
            this.Search.Br = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(390, 347);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search.Name = "Search";
            this.Search.PasswordChar = '\0';
            this.Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Search.Size = new System.Drawing.Size(479, 48);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search for institutes..";
            this.Search.textboxRadius = 15;
            this.Search.UseSystemPasswordChar = false;
            // 
            // account_Details1
            // 
            this.account_Details1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.account_Details1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_Details1.ForeColor = System.Drawing.Color.White;
            this.account_Details1.Location = new System.Drawing.Point(243, 25);
            this.account_Details1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.account_Details1.Name = "account_Details1";
            this.account_Details1.Size = new System.Drawing.Size(450, 487);
            this.account_Details1.TabIndex = 14;
            // 
            // Form_dahsboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 718);
            this.Controls.Add(this.account_Details1);
            this.Controls.Add(this.bookings1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Quit_btn);
            this.Controls.Add(this.Submit_search_btn);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_dahsboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_dahsboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CeLearningTextbox Search;
        private System.Windows.Forms.Button Submit_search_btn;
        private System.Windows.Forms.Label Name_static;
        private System.Windows.Forms.Label Name_D;
        private System.Windows.Forms.Button Quit_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Account_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button Booking_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Time_d;
        private System.Windows.Forms.Label Time_s;
        private System.Windows.Forms.Label Date_s;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label DateD;
        private System.Windows.Forms.Timer timer1;
        private Bookings bookings1;
        private Account_Details account_Details1;
    }
}