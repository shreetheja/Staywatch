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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if(isFormValid())
            {
                List<string> _values = new List<string>();
                _values.Add(Username_txt.Text);
                _values.Add(Name_txt.Text);

                //date Beta

                //datetime = Convert.ToDateTime(datetime, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
                //tring convertedstring = datetime.ToString("dd/MM/yyyy");
                Console.WriteLine("Converted String : " + dateTimer_txt.Text);
                _values.Add(dateTimer_txt.Text);
                //_values.Add();
                
                _values.Add(Email_txt.Text);
                _values.Add(Phone_text.Text);
                _values.Add ("29");
                _values.Add(Password_txt.Text);

                if (DataClass.isFormValid(DataClass.regexCompare.email, _values[3]))
                    {
                    if (DataClass.isFormValid(DataClass.regexCompare.phone, _values[4]))
                    {
                        if (Database.SignUp(_values))
                        {

                            SMTPClient.SignupMail(_values[3]);
                            if (MessageBox.Show("Successfully Inserted :} happy Browsing!", "Message", MessageBoxButtons.OK) == DialogResult.OK)
                            {

                                using (Login_form lf = new Login_form())
                                {
                                    this.Hide();
                                    lf.ShowDialog();
                                    this.Dispose();
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("User Already Exists :{", "Message", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phone Number Invalid", "Message", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Mail Invalid", "Message", MessageBoxButtons.OK);
                }

            }

        }
        bool isFormValid()
        {
            bool returnValue = false;
            if(Password_txt.Text.Equals(confrmPas_txt.Text))
            {
                if(Name_txt.Text.Length == 0 || Username_txt.Text.Length == 0 || Email_txt.Text.Length == 0 || Phone_text.Text.Length == 0||dateTimer_txt.Value == dateTimer_txt.MinDate || Password_txt.Text.Length == 0 || confrmPas_txt.Text.Length == 0)
                {
                    MessageBox.Show("Fill All Fields Please :}", "Message", MessageBoxButtons.OK);
                    returnValue = false;
                }
                else
                {
                    returnValue = true;
                }
            }
            else
            {
                MessageBox.Show("Password and Confirm Password Should be same", "Message", MessageBoxButtons.OK);
                returnValue = false;
            }
            return returnValue;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            using(Login_form lf = new Login_form())
            {
                this.Hide();
                lf.ShowDialog();
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure :{ ?", "Quit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();  //close
            }
        }
    }
}
