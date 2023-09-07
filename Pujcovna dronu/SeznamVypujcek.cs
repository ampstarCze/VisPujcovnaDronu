using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Object;
using PresentationLayer;

namespace Pujcovna_dronu
{
    public partial class SeznamVypujcek : Form
    {

        public SeznamVypujcek()
        {           
            InitializeComponent();
         
        }

        private async void SeznamVypujcek_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Collection<Vypujcka> vypujckas = await Vypujcka.GetAll();
            vypujckas = dataConverter.vypujckaDate(vypujckas);
            dataGridView1.DataSource = vypujckas;
            dataGridView1.Columns["dron"].Visible = false;
            dataGridView1.Columns["zakaznik"].Visible = false;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string str = this.dataGridView1[0, e.RowIndex].Value.ToString();
                Int32.TryParse(str, out int val);
                Form vratit = new Vratit(val);
                vratit.FormClosing += new FormClosingEventHandler(SeznamVypujcek_Load);
                vratit.Show();
            }
        }      
    }
}
