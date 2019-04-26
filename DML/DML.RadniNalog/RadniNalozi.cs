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
                Datum = datum,
                NaruciteljId = int.Parse(cbNarucitelj.SelectedValue.ToString()),
                PrimateljId = int.Parse(cbPrimatelj.SelectedValue.ToString()),
                RadilisteId = int.Parse(cbRadiliste.SelectedValue.ToString()),
                RegOznakaId = int.Parse(cbRegOznakaKamiona.SelectedValue.ToString()),
                RN = txtRadniNalog.Text,
                RobuIzdaoId = int.Parse(cbRobuIzdao.SelectedValue.ToString()),
                VozacId = int.Parse(cbVozac.SelectedValue.ToString()),
                VrstaRobeId = int.Parse(cbVrstaRobe.SelectedValue.ToString()),
                VrstaStroja = txtVrstaStroja.Text,
                VrstaUslugeId = int.Parse(cbVrstaUsluge.SelectedValue.ToString()),
            };

            rnServices.Save(data);
            tabControl1.SelectedIndex = 1;
        }

        private void RadniNalozi_Load(object sender, EventArgs e)
        {
            var loadData = rnServices.GetLoadData();

            cbNarucitelj.DataSource = loadData.NarutiteljDtos;
            cbNarucitelj.DisplayMember = "Name";
            cbNarucitelj.ValueMember = "Id";

            cbPrimatelj.DataSource = loadData.PrimateljDtos;
            cbPrimatelj.DisplayMember = "Name";
            cbPrimatelj.ValueMember = "Id";

            cbRadiliste.DataSource = loadData.RadilisteDtos;
            cbRadiliste.DisplayMember = "Name";
            cbRadiliste.ValueMember = "Id";

            cbRegOznakaKamiona.DataSource = loadData.RegOznakaDtos;
            cbRegOznakaKamiona.DisplayMember = "Name";
            cbRegOznakaKamiona.ValueMember = "Id";

            cbRobuIzdao.DataSource = loadData.RobuIzdaoDtos;
            cbRobuIzdao.DisplayMember = "Name";
            cbRobuIzdao.ValueMember = "Id";

            cbVozac.DataSource = loadData.VozacDtos;
            cbVozac.DisplayMember = "Name";
            cbVozac.ValueMember = "Id";

            cbVrstaRobe.DataSource = loadData.VrstaRobeDtos;
            cbVrstaRobe.DisplayMember = "Name";
            cbVrstaRobe.ValueMember = "Id";

            cbVrstaUsluge.DataSource = loadData.VrstaUslugeDtos;
            cbVrstaUsluge.DisplayMember = "Name";
            cbVrstaUsluge.ValueMember = "Id";

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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
