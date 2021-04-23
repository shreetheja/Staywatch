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
    public partial class Search_form : Form
    {
        Dictionary<int, List<string>> _record = new Dictionary<int, List<string>>();
        
        public Search_form(string search)
        {
            InitializeComponent();
            _fetchDatabase(search);
            _initialseDetails(search);
            _AdminToolsStatus();
            timer1.Start();
            addStays1.Hide();
            deleteStays1.Hide();
            institute_add1.Hide();
            booking1.Hide();
        }
        void _fetchDatabase(string _search)
        {
            if (Database.SearchResults1(_search)) //searching...
            {
                try
                {
                    _record = Database.fetchRecord;
                }
                catch(Exception e)
                {
                    MessageBox.Show("Failed error" + e);
                }
            }
            else
            {
                MessageBox.Show("No Pg found");
            }
        }
        void _initialseDetails(string s)
        {
            Search2.Text = s; //search box filled
            Name_D.Text = DataClass.Realuser_Name;//name fill
            NumberC_d.Text = Database.fetchRecord.Count.ToString(); //number of record
            dataGridView1.DataSource = Database.fillDatagrid(Database.fetchRecord); // datagrid fill
        }
        void _AdminToolsStatus()
        {
            if(DataClass.isAdmin == true)
            {
                Stay_data.Visible = true;
                Institute_data.Visible = true;
            }
            else
            {
                Stay_data.Visible = false;
                Institute_data.Visible = false;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            using(Form_dahsboard fd = new Form_dahsboard())
            {
                this.Hide();
                fd.ShowDialog();
                this.Dispose();
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure:{ ?", "Quit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();  //close
            }

        }

        private void search2_btn_Click(object sender, EventArgs e)
        {
            using(Search_form s = new Search_form(Search2.Text))
            {
                this.Hide();
                s.ShowDialog();
                this.Dispose();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Wanna see Maps? or Press no To book","Message",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(Browse_window mp = new Browse_window(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()))
                {
                    mp.ShowDialog();
                    return;
                }
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                List<string> _values = new List<string>();
                
                if(MessageBox.Show("Are you Sure To book the Pg:"+selectedRow.Cells[1].Value.ToString(),"Confirmation",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    DataClass.cache.Clear();

                    for (int i = 0; i < selectedRow.Cells.Count; i++)
                    {
                        DataClass.cache.Add(selectedRow.Cells[i].Value.ToString());
                    }
                    booking1.Show();
                    booking1.refreshValues();

                }



            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.Time_d.Text = dateTime.ToString("HH:mm:ss");
        }

        private void Insert_data_Click(object sender, EventArgs e)
        {
            addStays1.Show();
        }

        private void InsertI_data_Click(object sender, EventArgs e)
        {
           institute_add1.Show();
        }

        private void Delete_data_Click(object sender, EventArgs e)
        {
            deleteStays1.Show();
        }

        
    }
}
