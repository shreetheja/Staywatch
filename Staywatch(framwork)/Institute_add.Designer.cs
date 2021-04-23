namespace Staywatch_framwork_
{
    partial class Institute_add
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

        #region Component Designer generated code

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
            this.Location = new System.Windows.Forms.GroupBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Quit_btn = new System.Windows.Forms.Button();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.address_txt = new Staywatch_framwork_.CeLearningTextbox();
            this.ID_txt = new Staywatch_framwork_.CeLearningTextbox();
            this.Name_txt = new Staywatch_framwork_.CeLearningTextbox();
            this.longitude_txt = new Staywatch_framwork_.CeLearningTextbox();
            this.Latitude_txt = new Staywatch_framwork_.CeLearningTextbox();
            this.Location.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Institute Details:-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Latitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Longitude";
            // 
            // Location
            // 
            this.Location.Controls.Add(this.longitude_txt);
            this.Location.Controls.Add(this.Latitude_txt);
            this.Location.Controls.Add(this.label4);
            this.Location.Controls.Add(this.label6);
            this.Location.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.ForeColor = System.Drawing.Color.White;
            this.Location.Location = new System.Drawing.Point(59, 266);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(629, 121);
            this.Location.TabIndex = 7;
            this.Location.TabStop = false;
            this.Location.Text = "Location";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_btn.Location = new System.Drawing.Point(117, 417);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(200, 40);
            this.Cancel_btn.TabIndex = 11;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Quit_btn
            // 
            this.Quit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit_btn.Location = new System.Drawing.Point(707, 11);
            this.Quit_btn.Name = "Quit_btn";
            this.Quit_btn.Size = new System.Drawing.Size(29, 29);
            this.Quit_btn.TabIndex = 12;
            this.Quit_btn.Text = "X";
            this.Quit_btn.UseVisualStyleBackColor = true;
            this.Quit_btn.Click += new System.EventHandler(this.Quit_btn_Click);
            // 
            // Submit_btn
            // 
            this.Submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_btn.Location = new System.Drawing.Point(413, 417);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(200, 40);
            this.Submit_btn.TabIndex = 13;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // address_txt
            // 
            this.address_txt.BackColor = System.Drawing.Color.Transparent;
            this.address_txt.BorderColor = System.Drawing.Color.Gray;
            this.address_txt.BorderSize = 1;
            this.address_txt.Br = System.Drawing.Color.White;
            this.address_txt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.address_txt.ForeColor = System.Drawing.Color.Black;
            this.address_txt.Location = new System.Drawing.Point(221, 192);
            this.address_txt.Name = "address_txt";
            this.address_txt.PasswordChar = '\0';
            this.address_txt.Size = new System.Drawing.Size(223, 35);
            this.address_txt.TabIndex = 10;
            this.address_txt.textboxRadius = 15;
            this.address_txt.UseSystemPasswordChar = false;
            // 
            // ID_txt
            // 
            this.ID_txt.BackColor = System.Drawing.Color.Transparent;
            this.ID_txt.BorderColor = System.Drawing.Color.Gray;
            this.ID_txt.BorderSize = 1;
            this.ID_txt.Br = System.Drawing.Color.White;
            this.ID_txt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ID_txt.ForeColor = System.Drawing.Color.Black;
            this.ID_txt.Location = new System.Drawing.Point(221, 149);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.PasswordChar = '\0';
            this.ID_txt.Size = new System.Drawing.Size(223, 35);
            this.ID_txt.TabIndex = 9;
            this.ID_txt.textboxRadius = 15;
            this.ID_txt.UseSystemPasswordChar = false;
            // 
            // Name_txt
            // 
            this.Name_txt.BackColor = System.Drawing.Color.Transparent;
            this.Name_txt.BorderColor = System.Drawing.Color.Gray;
            this.Name_txt.BorderSize = 1;
            this.Name_txt.Br = System.Drawing.Color.White;
            this.Name_txt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Name_txt.ForeColor = System.Drawing.Color.Black;
            this.Name_txt.Location = new System.Drawing.Point(221, 98);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.PasswordChar = '\0';
            this.Name_txt.Size = new System.Drawing.Size(223, 35);
            this.Name_txt.TabIndex = 8;
            this.Name_txt.textboxRadius = 15;
            this.Name_txt.UseSystemPasswordChar = false;
            // 
            // longitude_txt
            // 
            this.longitude_txt.BackColor = System.Drawing.Color.Transparent;
            this.longitude_txt.BorderColor = System.Drawing.Color.Gray;
            this.longitude_txt.BorderSize = 1;
            this.longitude_txt.Br = System.Drawing.Color.White;
            this.longitude_txt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.longitude_txt.ForeColor = System.Drawing.Color.Black;
            this.longitude_txt.Location = new System.Drawing.Point(297, 63);
            this.longitude_txt.Name = "longitude_txt";
            this.longitude_txt.PasswordChar = '\0';
            this.longitude_txt.Size = new System.Drawing.Size(223, 35);
            this.longitude_txt.TabIndex = 8;
            this.longitude_txt.textboxRadius = 15;
            this.longitude_txt.UseSystemPasswordChar = false;
            // 
            // Latitude_txt
            // 
            this.Latitude_txt.BackColor = System.Drawing.Color.Transparent;
            this.Latitude_txt.BorderColor = System.Drawing.Color.Gray;
            this.Latitude_txt.BorderSize = 1;
            this.Latitude_txt.Br = System.Drawing.Color.White;
            this.Latitude_txt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Latitude_txt.ForeColor = System.Drawing.Color.Black;
            this.Latitude_txt.Location = new System.Drawing.Point(29, 63);
            this.Latitude_txt.Name = "Latitude_txt";
            this.Latitude_txt.PasswordChar = '\0';
            this.Latitude_txt.Size = new System.Drawing.Size(223, 35);
            this.Latitude_txt.TabIndex = 7;
            this.Latitude_txt.textboxRadius = 15;
            this.Latitude_txt.UseSystemPasswordChar = false;
            // 
            // Institute_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Quit_btn);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Institute_add";
            this.Size = new System.Drawing.Size(749, 487);
            this.Location.ResumeLayout(false);
            this.Location.PerformLayout();
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
        private System.Windows.Forms.GroupBox Location;
        private CeLearningTextbox longitude_txt;
        private CeLearningTextbox Latitude_txt;
        private CeLearningTextbox Name_txt;
        private CeLearningTextbox ID_txt;
        private CeLearningTextbox address_txt;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Quit_btn;
        private System.Windows.Forms.Button Submit_btn;
    }
}
