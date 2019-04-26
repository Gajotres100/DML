using DML.Services.RadniNalozi;
using DML.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DML.RadniNalog
{
    public partial class RadniNalozi : Form
    {
        RnServices rnServices;
        public RadniNalozi()
        {
            InitializeComponent();

            rnServices = new RnServices();
        }

        private void btnSaveRn_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtKolicinaRobe.Text, out int kolicinaRobe);
            DateTime.TryParse(dtpDatum.Text, out DateTime datum);
            var data = new RnDto
            {
               Datum = datum
            };

            rnServices.Save(data);
            tabControl1.SelectedIndex = 1;
        }

        private void RadniNalozi_Load(object sender, EventArgs e)
        {
            ddgRadniNalozi.DataSource = rnServices.GetRnDtos();
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            ddgRadniNalozi.DataSource = rnServices.GetRnDtos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime.TryParse(dtpStart.Text, out DateTime startDate);
            DateTime.TryParse(dtpEnd.Text, out DateTime endDate);
            int.TryParse(txtRegFilter.Text, out int regId);

            ddgRadniNalozi.DataSource = rnServices.GetRnForTimePeriodAndReg(startDate, endDate, regId);
        }
    }
}
