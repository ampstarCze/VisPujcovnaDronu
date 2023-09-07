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
    public partial class SeznamDronu : Form
    {
        Boolean fromMenu;
        int zakaznikID;

        public SeznamDronu()
        {
            this.fromMenu = true;
            InitializeComponent();
        }

        public SeznamDronu(int zakaznikID)
        {
            this.fromMenu = false;
            this.zakaznikID = zakaznikID;
            InitializeComponent();
        }

        private void SeznamDronu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Collection<Dron> drons = Dron.GetAll();
            dataGridView1.DataSource = drons;
            dataGridView1.Columns["idDron"].Visible = false;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!fromMenu)
            {
                if (e.RowIndex > -1)
                {
                    string str = this.dataGridView1[0, e.RowIndex].Value.ToString();
                    Int32.TryParse(str, out int val);
                    Dron dron = Dron.GetByID(val);
                    if (dron.lzeVypujcit())
                    {
                        Form vypujcka = new Vypujcit(dron.idDron, zakaznikID);
                        vypujcka.FormClosing += new FormClosingEventHandler(SeznamDronu_Load);
                        vypujcka.Show();
                    }
                    else
                    {
                        Form form = new DronVypujcen(dron.idDron, zakaznikID);
                        form.Show();
                    }
                }
            }
        }
    }
}
