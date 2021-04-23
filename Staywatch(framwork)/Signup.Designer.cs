namespace Staywatch_framwork_
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimer_txt = new System.Windows.Forms.DateTimePicker();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.confrmPas_txt = new Staywatch_framwork_.CeLearningTextbox();
            this.Password_txt = new Staywatch_framwork_.CeLearningTextbox();
            this.Phone_text = new Staywatch_framwork_.CeLearningTextbox();
            this.Email_txt = new Staywatch_framwork_.CeLearningTextbox();
            this.Name_txt = new Staywatch_framwork_.CeLearningTextbox();
            this.Username_txt = new Staywatch_framwork_.CeLearningTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(762, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimer_txt);
            this.groupBox1.Controls.Add(this.Submit_btn);
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.Controls.Add(this.confrmPas_txt);
            this.groupBox1.Controls.Add(this.Password_txt);
            this.groupBox1.Controls.Add(this.Phone_text);
            this.groupBox1.Controls.Add(this.Email_txt);
            this.groupBox1.Controls.Add(this.Name_txt);
            this.groupBox1.Controls.Add(this.Username_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(35, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 576);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // dateTimer_txt
            // 
            this.dateTimer_txt.CustomFormat = "dd-MM-yy";
            this.dateTimer_txt.Location = new System.Drawing.Point(200, 321);
            this.dateTimer_txt.MaxDate = new System.DateTime(2021, 1, 28, 0, 0, 0, 0);
            this.dateTimer_txt.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimer_txt.Name = "dateTimer_txt";
            this.dateTimer_txt.Size = new System.Drawing.Size(200, 32);
            this.dateTimer_txt.TabIndex = 5;
            this.dateTimer_txt.Value = new System.DateTime(2021, 1, 28, 0, 0, 0, 0);
            // 
            // Submit_btn
            // 
            this.Submit_btn.BackColor = System.Drawing.Color.DimGray;
            this.Submit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Submit_btn.FlatAppearance.BorderSize = 0;
            this.Submit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Submit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_btn.ForeColor = System.Drawing.Color.White;
            this.Submit_btn.Location = new System.Drawing.Point(391, 520);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(174, 47);
            this.Submit_btn.TabIndex = 17;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = false;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.DimGray;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cancel_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(77, 520);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(174, 47);
            this.cancel_btn.TabIndex = 16;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // confrmPas_txt
            // 
            this.confrmPas_txt.BackColor = System.Drawing.Color.Transparent;
            this.confrmPas_txt.BorderColor = System.Drawing.Color.Gray;
            this.confrmPas_txt.BorderSize = 1;
            this.confrmPas_txt.Br = System.Drawing.Color.White;
            this.confrmPas_txt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.confrmPas_txt.ForeColor = System.Drawing.Color.Black;
            this.confrmPas_txt.Location = new System.Drawing.Point(200, 458);
            this.confrmPas_txt.Name = "confrmPas_txt";
            this.confrmPas_txt.PasswordChar = '\0';
            this.confrmPas_txt.Size = new System.Drawing.Size(441, 34);
            this.confrmPas_txt.TabIndex = 7;
            this.confrmPas_txt.textboxRadius = 15;
            this.confrmPas_txt.UseSystemPasswordChar = false;
            // 
            // Password_txt
            // 
            this.Password_txt.BackColor = System.Drawing.Color.Transparent;
            this.Password_txt.BorderColor = System.Drawing.Color.Gray;
            this.Password_txt.BorderSize = 1;
            this.Password_txt.Br = System.Drawing.Color.White;
            this.Password_txt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Password_txt.ForeColor = System.Drawing.Color.Black;
            this.Password_txt.Location = new System.Drawing.Point(200, 418);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '\0';
            this.Password_txt.Size = new System.Drawing.Size(441, 34);
            this.Password_txt.TabIndex = 6;
            this.Password_txt.textboxRadius = 15;
            this.Password_txt.UseSystemPasswordChar = false;
            // 
            // Phone_text
            // 
            this.Phone_text.BackColor = System.Drawing.Color.Transparent;
            this.Phone_text.BorderColor = System.Drawing.Color.Gray;
            this.Phone_text.BorderSize = 1;
            this.Phone_text.Br = System.Drawing.Color.White;
            this.Phone_text.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Phone_text.ForeColor = System.Drawing.Color.Black;
            this.Phone_text.Location = new System.Drawing.Point(200, 273);
            this.Phone_text.Name = "Phone_text";
            this.Phone_text.PasswordChar = '\0';
            this.Phone_text.Size = new System.Drawing.Size(441, 34);
            this.Phone_text.TabIndex = 4;
            this.Phone_text.textboxRadius = 15;
            this.Phone_text.UseSystemPasswordChar = false;
            // 
            // Email_txt
            // 
            this.Email_txt.BackColor = System.Drawing.Color.Transparent;
            this.Email_txt.BorderColor = System.Drawing.Color.Gray;
            this.Email_txt.BorderSize = 1;
            this.Email_txt.Br = System.Drawing.Color.White;
            this.Email_txt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Email_txt.ForeColor = System.Drawing.Color.Black;
            this.Email_txt.Location = new System.Drawing.Point(200, 223);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.PasswordChar = '\0';
            this.Email_txt.Size = new System.Drawing.Size(441, 34);
            this.Email_txt.TabIndex = 3;
            this.Email_txt.textboxRadius = 15;
            this.Email_txt.UseSystemPasswordChar = false;
            // 
            // Name_txt
            // 
            this.Name_txt.BackColor = System.Drawing.Color.Transparent;
            this.Name_txt.BorderColor = System.Drawing.Color.Gray;
            this.Name_txt.BorderSize = 1;
            this.Name_txt.Br = System.Drawing.Color.White;
            this.Name_txt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Name_txt.ForeColor = System.Drawing.Color.Black;
            this.Name_txt.Location = new System.Drawing.Point(200, 119);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.PasswordChar = '\0';
            this.Name_txt.Size = new System.Drawing.Size(441, 34);
            this.Name_txt.TabIndex = 2;
            this.Name_txt.textboxRadius = 15;
            this.Name_txt.UseSystemPasswordChar = false;
            // 
            // Username_txt
            // 
            this.Username_txt.BackColor = System.Drawing.Color.Transparent;
            this.Username_txt.BorderColor = System.Drawing.Color.Gray;
            this.Username_txt.BorderSize = 1;
            this.Username_txt.Br = System.Drawing.Color.White;
            this.Username_txt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Username_txt.ForeColor = System.Drawing.Color.Black;
            this.Username_txt.Location = new System.Drawing.Point(200, 67);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.PasswordChar = '\0';
            this.Username_txt.Size = new System.Drawing.Size(441, 34);
            this.Username_txt.TabIndex = 1;
            this.Username_txt.textboxRadius = 15;
            this.Username_txt.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confrim Passowrd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(281, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Account Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1019, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1065, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimer_txt;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Button cancel_btn;
        private CeLearningTextbox confrmPas_txt;
        private CeLearningTextbox Password_txt;
        private CeLearningTextbox Phone_text;
        private CeLearningTextbox Email_txt;
        private CeLearningTextbox Name_txt;
        private CeLearningTextbox Username_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}