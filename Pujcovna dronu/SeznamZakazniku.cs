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

namespace Pujcovna_dronu
{
    public partial class SeznamZakazniku : Form
    {      

        public SeznamZakazniku()
        {      
            InitializeComponent();
        }

        private async void SeznamZakazniku_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Collection<PrihlasenyZakaznik> zakazniks = await PrihlasenyZakaznik.GetAll();
            dataGridView1.DataSource = zakazniks;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {          
                if (e.RowIndex > -1)
                {
                    string str = this.dataGridView1[0, e.RowIndex].Value.ToString();
                    Int32.TryParse(str, out int val);
                    Form form = new Zakaznik(val);
                    form.Show();
                }           
        }
    }
}
