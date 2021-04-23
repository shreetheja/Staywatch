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
    public partial class Institute_add : UserControl
    {
        public Institute_add()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            List<string> _values = new List<string>();
            _values = fillData();
            if(DataClass.isFormValid(DataClass.regexCompare.isNull,_values))
            {
                if(Database.InsertInstitue(_values))
                {
                    MessageBox.Show("Record Inserted Successful", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Oops something went Wrong", "Message", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("All fields Required", "Message", MessageBoxButtons.OK);
            }
        }
        private List<string> fillData()
        {
            List<string> _values = new List<string>();
            _values.Add(Name_txt.Text);
            _values.Add(ID_txt.Text);
            _values.Add(address_txt.Text);
            _values.Add(longitude_txt.Text);
            _values.Add(Latitude_txt.Text);
            return _values;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Quit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
