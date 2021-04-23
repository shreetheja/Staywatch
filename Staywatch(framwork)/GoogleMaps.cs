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
    public partial class Browse_window : Form
    {
        public Browse_window(string _stayID)
        {
            InitializeComponent();
            GetMap(_stayID);
        }
        void GetMap(string _stayId)
        {
            string url = "https://www.google.com/maps/dir/";
            string userId = DataClass.CurrentUsername;

            //database find User Location
            if(Database.GetUsersLocation(DataClass.CurrentUsername))
            {
                url = url + Database.fetchRecord[0][1] + "," + Database.fetchRecord[0][0];
            }

            //database find Institue Location
            if(Database.GetStayLocation(_stayId))
            {
                url = url +"/"+Database.fetchRecord[0][1] + "," + Database.fetchRecord[0][0];
                url = url + "/@" + Database.fetchRecord[0][1] + "," + Database.fetchRecord[0][0]+",15z";
                Console.WriteLine(url);
            }
            try
            {
                if (CheckForInternetConnection())
                {
                    webBrowser1.Navigate(url);
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
                else
                {
                    if(MessageBox.Show("Check Your Internet Connection :}","Message!",MessageBoxButtons.OK) == DialogResult.OK)
                    {

                        this.Hide();

                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("oops Something went Wrong Error: "+e, "Error", MessageBoxButtons.OK);
            }
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
