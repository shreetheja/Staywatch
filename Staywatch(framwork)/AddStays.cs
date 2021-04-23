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
    public partial class AddStays : UserControl
    {
        public AddStays()
        {
            InitializeComponent();
        }

       

        private void Submit_button_Click(object sender, EventArgs e)
        {
            List<string> _values = fillData();
            
           
            if(DataClass.isFormValid(DataClass.regexCompare.isNull,_values))
            {
                if(DataClass.isFormValid(DataClass.regexCompare.phone,_values[2]))
                {
                    if(Database.InsertStays(_values))
                    {
                        if(MessageBox.Show("Insertion Succesfull! :}","Message",MessageBoxButtons.OK)==DialogResult.OK)
                        {
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Oops Something Went Wrong", "Message", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Enter Valid Phone Number", "Message", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Fill Every Field", "Message", MessageBoxButtons.OK);
            }
        }
        
        private List<string> fillData()
        {
            /*
             * 
             * values are in order of
             * 1.name
             * 2.address
             * 3.phone
             * 4.number of rooms
             * 5.type
             * 6.roomcost
             * 7.latitude
             * 8.longitude
             * 9.distance
             * 10.near To institute
             */
            List<string> _values = new List<string>();
            _values.Add(Name_text.textbox.Text);
            _values.Add(Address_text.Text);
            _values.Add(Phone_text.Text);
            _values.Add(NumberOfRooms_text.Text);
            //drop
            if(boys_r.Checked)
            {
                _values.Add("B");
            }
            else if(both_r.Checked)
            {
                _values.Add("BG");
            }
            else if(girls_r.Checked)
            {
                _values.Add("G");
            }
            else
            {
                MessageBox.Show("Enter the Type");
                return null;
            }
            _values.Add(RoomCost_text.Text);


            _values.Add(Latitude_text.Text);
            _values.Add(Longitude_text.Text);
            _values.Add(Distance_text.Text);
            _values.Add(NearTo_text.Text);

           
              
            return _values;
                

        }
        
        private void Quit_id_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
