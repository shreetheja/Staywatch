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
    public partial class Booking : UserControl
    {
        List<string> _DispValues = new List<string>();
        List<string> _sendToDatabaseValues = new List<string>();
        public Booking()
        {
            InitializeComponent();
        }
        public void refreshValues()
        {
            _DispValues = DataClass.cache;
            Name_d.Text = _DispValues[1];
            Address_d.Text = _DispValues[3];
            Phone_d.Text = _DispValues[4];
            Cost_d.Text = _DispValues[6];
            Type_d.Text = _DispValues[5];

            _sendToDatabaseValues.Add(_DispValues[4]);
            _sendToDatabaseValues.Add(_DispValues[6]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Database.BookStay(_sendToDatabaseValues))
            {
                if(MessageBox.Show("Succefully Booked Wait Until Owner contacts you!! :}","Message!",MessageBoxButtons.OK)==DialogResult.OK)
                {
                    this.Hide();
                    this.Dispose();
                }
            }
        }
    }
}
