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
    public partial class ForgetPassword : Form
    {
        private readonly Random _random = new Random();
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();
            
            values.Add(Username_txt.Text);
            values.Add(Email_txt.Text);
            values.Add(Phone_txt.Text);
            
            if(DataClass.isFormValid(DataClass.regexCompare.isNull,values))
            {
                Console.WriteLine("IN1");
                if(DataClass.isFormValid(DataClass.regexCompare.email,values[1]))
                {
                    Console.WriteLine("IN2");
                    if (DataClass.isFormValid(DataClass.regexCompare.phone,Phone_txt.Text))
                    {
                        Console.WriteLine("IN3");
                        changePassword();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Phone Number: "+Phone_txt.Text+" :{ ", "Message", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email Try Again!", "Message", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Fill all the Required Fields Please","Message",MessageBoxButtons.OK);
            }
        }

       

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose(); 
        }


        #region paswword Changers
        private bool checkValidity()
        {
            if(Database.PasswordChangeCheck(Username_txt.Text,Email_txt.Text,Phone_txt.Text))
            {
                if(Database.fetchRecord.Count != 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("The User Does not Exist or the Credeentials are wrong","Error",MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(" oops Something Went Wrong", "Error", MessageBoxButtons.OK);
            }
            return false;
        }
        private void changePassword()
        {
            if(checkValidity())
            {
                string _newPassword = "Hello123";
                if (Database.changePassword(_newPassword))
                {
                    if(SMTPClient.ForgetPasswordMail(_newPassword,Email_txt.Text))
                    MessageBox.Show("New password Sent To eamil Succesfully", "Message!", MessageBoxButtons.OK);
                    else
                    MessageBox.Show("Check Internet Connection!", "Message!", MessageBoxButtons.OK);


                }
                else
                {
                    MessageBox.Show("oops something went Wrong", "Message!", MessageBoxButtons.OK);
                }
            }
            
        }

        #endregion

        

    }
}
