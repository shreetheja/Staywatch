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
    public partial class Bookings : UserControl
    {
        public Bookings()
        {
            InitializeComponent();
            fillDataGrid();
        }
        public void refreshValues()
        {
            fillDataGrid();
        }
        void fillDataGrid()
        {
            Account_d.Text = DataClass.Realuser_Name;
            Database.getBookingDetails();
            if(Database.fetchRecord.Count !=0)
            dataGridView1.DataSource = Database.fillDatagridBooking(Database.fetchRecord);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
