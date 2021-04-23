namespace Staywatch_framwork_
{
    partial class ForgetPassword
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
            this.Phone = new System.Windows.Forms.Label();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Username_txt = new Staywatch_framwork_.CeLearningTextbox();
            this.Email_txt = new Staywatch_framwork_.CeLearningTextbox();
            this.Phone_txt = new Staywatch_framwork_.CeLearningTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Details:-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.Color.White;
            this.Phone.Location = new System.Drawing.Point(65, 280);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(69, 25);
            this.Phone.TabIndex = 6;
            this.Phone.Text = "Phone";
            // 
            // Submit_btn
            // 
            this.Submit_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.Submit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_btn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.Location = new System.Drawing.Point(172, 378);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(227, 55);
            this.Submit_btn.TabIndex = 7;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = false;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.Red;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(499, 9);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(32, 36);
            this.Close_btn.TabIndex = 9;
            this.Close_btn.Text = "X";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Username_txt
            // 
            this.Username_txt.BackColor = System.Drawing.Color.Transparent;
            this.Username_txt.BorderColor = System.Drawing.Color.Gray;
            this.Username_txt.BorderSize = 1;
            this.Username_txt.Br = System.Drawing.Color.White;
            this.Username_txt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Username_txt.ForeColor = System.Drawing.Color.Black;
            this.Username_txt.Location = new System.Drawing.Point(140, 139);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.PasswordChar = '\0';
            this.Username_txt.Size = new System.Drawing.Size(296, 45);
            this.Username_txt.TabIndex = 10;
            this.Username_txt.textboxRadius = 15;
            this.Username_txt.UseSystemPasswordChar = false;
            // 
            // Email_txt
            // 
            this.Email_txt.BackColor = System.Drawing.Color.Transparent;
            this.Email_txt.BorderColor = System.Drawing.Color.Gray;
            this.Email_txt.BorderSize = 1;
            this.Email_txt.Br = System.Drawing.Color.White;
            this.Email_txt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Email_txt.ForeColor = System.Drawing.Color.Black;
            this.Email_txt.Location = new System.Drawing.Point(140, 200);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.PasswordChar = '\0';
            this.Email_txt.Size = new System.Drawing.Size(296, 48);
            this.Email_txt.TabIndex = 11;
            this.Email_txt.textboxRadius = 15;
            this.Email_txt.UseSystemPasswordChar = false;
            // 
            // Phone_txt
            // 
            this.Phone_txt.BackColor = System.Drawing.Color.Transparent;
            this.Phone_txt.BorderColor = System.Drawing.Color.Gray;
            this.Phone_txt.BorderSize = 1;
            this.Phone_txt.Br = System.Drawing.Color.White;
            this.Phone_txt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Phone_txt.ForeColor = System.Drawing.Color.Black;
            this.Phone_txt.Location = new System.Drawing.Point(140, 268);
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.PasswordChar = '\0';
            this.Phone_txt.Size = new System.Drawing.Size(296, 47);
            this.Phone_txt.TabIndex = 12;
            this.Phone_txt.textboxRadius = 15;
            this.Phone_txt.UseSystemPasswordChar = false;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(543, 464);
            this.Controls.Add(this.Phone_txt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Username_txt);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Button Close_btn;
        private CeLearningTextbox Username_txt;
        private CeLearningTextbox Email_txt;
        private CeLearningTextbox Phone_txt;
    }
}