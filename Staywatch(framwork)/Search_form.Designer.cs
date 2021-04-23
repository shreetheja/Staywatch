namespace Staywatch_framwork_
{
    partial class Search_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Institute_data = new System.Windows.Forms.GroupBox();
            this.InsertI_data = new System.Windows.Forms.Button();
            this.Stay_data = new System.Windows.Forms.GroupBox();
            this.Delete_data = new System.Windows.Forms.Button();
            this.Insert_data = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.search2_btn = new System.Windows.Forms.Button();
            this.Search2 = new Staywatch_framwork_.CeLearningTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Quit = new System.Windows.Forms.Button();
            this.Time_d = new System.Windows.Forms.Label();
            this.Time_s = new System.Windows.Forms.Label();
            this.Name_D = new System.Windows.Forms.Label();
            this.name_S = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NumberC_d = new System.Windows.Forms.Label();
            this.NumberC_s = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.addStays1 = new Staywatch_framwork_.AddStays();
            this.deleteStays1 = new Staywatch_framwork_.DeleteStays();
            this.institute_add1 = new Staywatch_framwork_.Institute_add();
            this.booking1 = new Staywatch_framwork_.Booking();
            this.panel1.SuspendLayout();
            this.Institute_data.SuspendLayout();
            this.Stay_data.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.Institute_data);
            this.panel1.Controls.Add(this.Stay_data);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.search2_btn);
            this.panel1.Controls.Add(this.Search2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 716);
            this.panel1.TabIndex = 0;
            // 
            // Institute_data
            // 
            this.Institute_data.Controls.Add(this.InsertI_data);
            this.Institute_data.ForeColor = System.Drawing.Color.White;
            this.Institute_data.Location = new System.Drawing.Point(9, 373);
            this.Institute_data.Margin = new System.Windows.Forms.Padding(2);
            this.Institute_data.Name = "Institute_data";
            this.Institute_data.Padding = new System.Windows.Forms.Padding(2);
            this.Institute_data.Size = new System.Drawing.Size(187, 131);
            this.Institute_data.TabIndex = 7;
            this.Institute_data.TabStop = false;
            this.Institute_data.Text = "Institute data";
            // 
            // InsertI_data
            // 
            this.InsertI_data.BackColor = System.Drawing.Color.DarkGray;
            this.InsertI_data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.InsertI_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertI_data.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertI_data.ForeColor = System.Drawing.Color.Black;
            this.InsertI_data.Location = new System.Drawing.Point(8, 61);
            this.InsertI_data.Margin = new System.Windows.Forms.Padding(2);
            this.InsertI_data.Name = "InsertI_data";
            this.InsertI_data.Size = new System.Drawing.Size(174, 34);
            this.InsertI_data.TabIndex = 0;
            this.InsertI_data.Text = "Insert Data";
            this.InsertI_data.UseVisualStyleBackColor = false;
            this.InsertI_data.Click += new System.EventHandler(this.InsertI_data_Click);
            // 
            // Stay_data
            // 
            this.Stay_data.Controls.Add(this.Delete_data);
            this.Stay_data.Controls.Add(this.Insert_data);
            this.Stay_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stay_data.ForeColor = System.Drawing.Color.White;
            this.Stay_data.Location = new System.Drawing.Point(9, 215);
            this.Stay_data.Margin = new System.Windows.Forms.Padding(2);
            this.Stay_data.Name = "Stay_data";
            this.Stay_data.Padding = new System.Windows.Forms.Padding(2);
            this.Stay_data.Size = new System.Drawing.Size(187, 131);
            this.Stay_data.TabIndex = 6;
            this.Stay_data.TabStop = false;
            this.Stay_data.Text = "Stay Data";
            // 
            // Delete_data
            // 
            this.Delete_data.BackColor = System.Drawing.Color.DarkGray;
            this.Delete_data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Delete_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_data.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_data.ForeColor = System.Drawing.Color.Black;
            this.Delete_data.Location = new System.Drawing.Point(8, 75);
            this.Delete_data.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_data.Name = "Delete_data";
            this.Delete_data.Size = new System.Drawing.Size(174, 30);
            this.Delete_data.TabIndex = 5;
            this.Delete_data.Text = "Delete Data";
            this.Delete_data.UseVisualStyleBackColor = false;
            this.Delete_data.Click += new System.EventHandler(this.Delete_data_Click);
            // 
            // Insert_data
            // 
            this.Insert_data.BackColor = System.Drawing.Color.DarkGray;
            this.Insert_data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Insert_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_data.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_data.ForeColor = System.Drawing.Color.Black;
            this.Insert_data.Location = new System.Drawing.Point(8, 36);
            this.Insert_data.Margin = new System.Windows.Forms.Padding(2);
            this.Insert_data.Name = "Insert_data";
            this.Insert_data.Size = new System.Drawing.Size(174, 34);
            this.Insert_data.TabIndex = 4;
            this.Insert_data.Text = "Insert Data";
            this.Insert_data.UseVisualStyleBackColor = false;
            this.Insert_data.Click += new System.EventHandler(this.Insert_data_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Red;
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(9, 10);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(69, 29);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // search2_btn
            // 
            this.search2_btn.BackColor = System.Drawing.Color.Transparent;
            this.search2_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search2_btn.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.search2_btn.FlatAppearance.BorderSize = 0;
            this.search2_btn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search2_btn.ForeColor = System.Drawing.Color.Black;
            this.search2_btn.Location = new System.Drawing.Point(44, 158);
            this.search2_btn.Margin = new System.Windows.Forms.Padding(2);
            this.search2_btn.Name = "search2_btn";
            this.search2_btn.Size = new System.Drawing.Size(136, 24);
            this.search2_btn.TabIndex = 1;
            this.search2_btn.Text = "Search";
            this.search2_btn.UseVisualStyleBackColor = false;
            this.search2_btn.Click += new System.EventHandler(this.search2_btn_Click);
            // 
            // Search2
            // 
            this.Search2.BackColor = System.Drawing.Color.Transparent;
            this.Search2.BorderColor = System.Drawing.Color.Gray;
            this.Search2.BorderSize = 1;
            this.Search2.Br = System.Drawing.Color.White;
            this.Search2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Search2.ForeColor = System.Drawing.Color.Black;
            this.Search2.Location = new System.Drawing.Point(17, 108);
            this.Search2.Margin = new System.Windows.Forms.Padding(2);
            this.Search2.Name = "Search2";
            this.Search2.PasswordChar = '\0';
            this.Search2.Size = new System.Drawing.Size(184, 32);
            this.Search2.TabIndex = 1;
            this.Search2.Text = "Search";
            this.Search2.textboxRadius = 15;
            this.Search2.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.Quit);
            this.panel2.Controls.Add(this.Time_d);
            this.panel2.Controls.Add(this.Time_s);
            this.panel2.Controls.Add(this.Name_D);
            this.panel2.Controls.Add(this.name_S);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(213, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 72);
            this.panel2.TabIndex = 1;
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Red;
            this.Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quit.FlatAppearance.BorderSize = 0;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.ForeColor = System.Drawing.Color.White;
            this.Quit.Location = new System.Drawing.Point(736, 2);
            this.Quit.Margin = new System.Windows.Forms.Padding(2);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(32, 29);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "X";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Time_d
            // 
            this.Time_d.AutoSize = true;
            this.Time_d.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_d.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Time_d.Location = new System.Drawing.Point(659, 45);
            this.Time_d.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time_d.Name = "Time_d";
            this.Time_d.Size = new System.Drawing.Size(80, 24);
            this.Time_d.TabIndex = 3;
            this.Time_d.Text = "20:15:20";
            // 
            // Time_s
            // 
            this.Time_s.AutoSize = true;
            this.Time_s.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_s.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Time_s.Location = new System.Drawing.Point(602, 47);
            this.Time_s.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time_s.Name = "Time_s";
            this.Time_s.Size = new System.Drawing.Size(56, 24);
            this.Time_s.TabIndex = 2;
            this.Time_s.Text = "Time:";
            // 
            // Name_D
            // 
            this.Name_D.AutoSize = true;
            this.Name_D.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_D.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name_D.Location = new System.Drawing.Point(84, 40);
            this.Name_D.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name_D.Name = "Name_D";
            this.Name_D.Size = new System.Drawing.Size(57, 24);
            this.Name_D.TabIndex = 1;
            this.Name_D.Text = "Shree";
            // 
            // name_S
            // 
            this.name_S.AutoSize = true;
            this.name_S.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_S.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name_S.Location = new System.Drawing.Point(9, 40);
            this.name_S.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_S.Name = "name_S";
            this.name_S.Size = new System.Drawing.Size(83, 24);
            this.name_S.TabIndex = 0;
            this.name_S.Text = "Account:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(758, 604);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel3.Controls.Add(this.NumberC_d);
            this.panel3.Controls.Add(this.NumberC_s);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(213, 677);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(769, 39);
            this.panel3.TabIndex = 3;
            // 
            // NumberC_d
            // 
            this.NumberC_d.AutoSize = true;
            this.NumberC_d.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberC_d.ForeColor = System.Drawing.Color.White;
            this.NumberC_d.Location = new System.Drawing.Point(512, 0);
            this.NumberC_d.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberC_d.Name = "NumberC_d";
            this.NumberC_d.Size = new System.Drawing.Size(25, 19);
            this.NumberC_d.TabIndex = 1;
            this.NumberC_d.Text = "03";
            // 
            // NumberC_s
            // 
            this.NumberC_s.AutoSize = true;
            this.NumberC_s.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberC_s.ForeColor = System.Drawing.Color.White;
            this.NumberC_s.Location = new System.Drawing.Point(339, 0);
            this.NumberC_s.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberC_s.Name = "NumberC_s";
            this.NumberC_s.Size = new System.Drawing.Size(179, 19);
            this.NumberC_s.TabIndex = 0;
            this.NumberC_s.Text = "Number of Rows Selected:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(966, 72);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(16, 605);
            this.panel4.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // addStays1
            // 
            this.addStays1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.addStays1.Location = new System.Drawing.Point(236, 72);
            this.addStays1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addStays1.Name = "addStays1";
            this.addStays1.Size = new System.Drawing.Size(667, 504);
            this.addStays1.TabIndex = 5;
            // 
            // deleteStays1
            // 
            this.deleteStays1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.deleteStays1.Location = new System.Drawing.Point(166, 187);
            this.deleteStays1.Name = "deleteStays1";
            this.deleteStays1.Size = new System.Drawing.Size(499, 312);
            this.deleteStays1.TabIndex = 6;
            // 
            // institute_add1
            // 
            this.institute_add1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.institute_add1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.institute_add1.ForeColor = System.Drawing.Color.White;
            this.institute_add1.Location = new System.Drawing.Point(105, 88);
            this.institute_add1.Name = "institute_add1";
            this.institute_add1.Size = new System.Drawing.Size(752, 509);
            this.institute_add1.TabIndex = 7;
            // 
            // booking1
            // 
            this.booking1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.booking1.Location = new System.Drawing.Point(201, 108);
            this.booking1.Name = "booking1";
            this.booking1.Size = new System.Drawing.Size(550, 447);
            this.booking1.TabIndex = 8;
            // 
            // Search_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 716);
            this.Controls.Add(this.booking1);
            this.Controls.Add(this.institute_add1);
            this.Controls.Add(this.deleteStays1);
            this.Controls.Add(this.addStays1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Search_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_form";
            this.panel1.ResumeLayout(false);
            this.Institute_data.ResumeLayout(false);
            this.Stay_data.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button search2_btn;
        private CeLearningTextbox Search2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Time_d;
        private System.Windows.Forms.Label Time_s;
        private System.Windows.Forms.Label Name_D;
        private System.Windows.Forms.Label name_S;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label NumberC_d;
        private System.Windows.Forms.Label NumberC_s;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox Stay_data;
        private System.Windows.Forms.Button Delete_data;
        private System.Windows.Forms.Button Insert_data;
        private System.Windows.Forms.GroupBox Institute_data;
        private System.Windows.Forms.Button InsertI_data;
        private AddStays addStays1;
        private DeleteStays deleteStays1;
        private Institute_add institute_add1;
        private Booking booking1;
    }
}