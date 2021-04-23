using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staywatch_framwork_
{
    public partial class Account_Details : UserControl
    {
        public Account_Details()
        {
            InitializeComponent();

        }
        public void refreshValues()
        {
            Usernam_txt.Text = DataClass.CurrentUsername;
            Name_txt.Text = DataClass.Realuser_Name;
            Phone_txt.Text = DataClass.CurrentPhoneNumber;
            Email_txt.Text = DataClass.CurrentMailId;
            Age_txt.Text = DataClass.age;
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
