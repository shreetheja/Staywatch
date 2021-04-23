using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Staywatch_framwork_
{
    public partial class Login_form :Form 
    {
        #region shadow
        private const int CS_dropShadow = 0x00020000; // Shadow Property
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_dropShadow;
                return cp;
            }
        }
        #endregion
        public Login_form()

        {
            InitializeComponent();
        }

        private void Quit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure:{ ?","Quit" , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();  //close
            }
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            List<string> str = new List<string>();
            str.Add(Username_TxtBox.Text);
            str.Add(Password_TxtBox.Text);
            if(!DataClass.isFormValid(DataClass.regexCompare.isNull,str))
            {
                MessageBox.Show("All fields are required","message",MessageBoxButtons.OK );
            }
            else
            {
                bool _results = Database.Login(Username_TxtBox.Text.ToString(), Password_TxtBox.Text.ToString(),DataClass.isAdmin);
                if(_results)//Account doessnt exist
                {
                    SMTPClient.LoginAlert();
                    using (Form_dahsboard fd = new Form_dahsboard())
                    {
                        this.Hide();
                        fd.ShowDialog();
                        this.Dispose();

                    }
                }
                else if(Database.State == Database.LoginStates.usernameDosnt)
                {
                    MessageBox.Show(" Account Doesnt exist", "message", MessageBoxButtons.OK);
                }
                else if(Database.State == Database.LoginStates.credentialWrong)
                {
                    MessageBox.Show("The account credential is wrong", "message", MessageBoxButtons.OK);
                }
            }


        }
        
        private void Logo_btn_Click(object sender, EventArgs e)
        {
            //link
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            using(Signup sf = new Signup())
            {
                this.Hide();
                sf.ShowDialog();
                this.Dispose();
                
            }
        }

        private void ForgetPassword_btn_Click(object sender, EventArgs e)
        {
            using(ForgetPassword fp = new ForgetPassword())
            {
                fp.ShowDialog();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataClass.isAdmin = radioButton1.Checked;
            
        }
    }
}
