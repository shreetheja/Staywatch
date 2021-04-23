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
    public partial class Form_dahsboard : Form
    {
        public Form_dahsboard()
        {
            InitializeComponent();
            updateDashboard();
            timer1.Start();
            account_Details1.Hide();
            bookings1.Hide();
            bookings1.BringToFront();
            bookings1.BringToFront();
        }
        
        void updateDashboard()
        {
            Database.AccountDetails();
            Console.WriteLine("Form : " + DataClass.Realuser_Name);
            Name_D.Text = DataClass.Realuser_Name; //update Account name

        }

        private void Submit_search_btn_Click(object sender, EventArgs e)
        {
            if (Search.Text.Length != 0)
            {
                using (Search_form s = new Search_form(Search.Text))
                {
                    s.ShowDialog();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Enter Text To Search", "message", MessageBoxButtons.OK);
            }
        }

        private void Quit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure:{ ?", "Quit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();  //close
            }

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            using(Login_form lf = new Login_form())
            {
                this.Hide();
                lf.ShowDialog();
                this.Close();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime dateTime = DateTime.Now;
            this.Time_d.Text = dateTime.ToString("HH:mm:ss");

            DateD.Text = dateTime.Date.ToString("MMM dd yyyy");
        }

        private void Account_btn_Click(object sender, EventArgs e)
        {
            account_Details1.Show();
            account_Details1.refreshValues();
        }

        private void Booking_btn_Click(object sender, EventArgs e)
        {
            bookings1.Show();
            bookings1.refreshValues();
        }
    }
}
