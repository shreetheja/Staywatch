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
    public partial class DeleteStays : UserControl
    {
        public DeleteStays()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ceLearningTextbox1.Text.Length !=0)
            {
                if(MessageBox.Show("Are you sure ? ","Message",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if(Database.DeleteStay(ceLearningTextbox1.Text))
                    {
                        MessageBox.Show("Successfully Deleted :{", "Message", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong","Message" ,MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill the ID", "Message", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
