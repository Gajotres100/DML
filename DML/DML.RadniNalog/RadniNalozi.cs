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

            loadData.NarutiteljDtos.Insert(0, new NarutiteljDto() { Id = 0, Name = "----Odaberi----" });
            loadData.PrimateljDtos.Insert(0, new PrimateljDto() { Id = 0, Name = "----Odaberi----" });
            loadData.RadilisteDtos.Insert(0, new RadilisteDto() { Id = 0, Name = "----Odaberi----" });
            loadData.RegOznakaDtos.Insert(0, new RegOznakaDto() { Id = 0, Name = "----Odaberi----" });
            loadData.RobuIzdaoDtos.Insert(0, new RobuIzdaoDto() { Id = 0, Name = "----Odaberi----" });
            loadData.VozacDtos.Insert(0, new VozacDto() { Id = 0, Name = "----Odaberi----" });
            loadData.VrstaRobeDtos.Insert(0, new VrstaRobeDto() { Id = 0, Name = "----Odaberi----" });
            loadData.VrstaUslugeDtos.Insert(0, new VrstaUslugeDto() { Id = 0, Name = "----Odaberi----" });

            cbNaruciteljSearch.DataSource = loadData.NarutiteljDtos;
            cbNaruciteljSearch.DisplayMember = "Name";
            cbNaruciteljSearch.ValueMember = "Id";

            cbPrimateljSearch.DataSource = loadData.PrimateljDtos;
            cbPrimateljSearch.DisplayMember = "Name";
            cbPrimateljSearch.ValueMember = "Id";

            cbGradisliteSearch.DataSource = loadData.RadilisteDtos;
            cbGradisliteSearch.DisplayMember = "Name";
            cbGradisliteSearch.ValueMember = "Id";

            cbRegKamionaSearch.DataSource = loadData.RegOznakaDtos;
            cbRegKamionaSearch.DisplayMember = "Name";
            cbRegKamionaSearch.ValueMember = "Id";

            cbRobuIzdaoSearch.DataSource = loadData.RobuIzdaoDtos;
            cbRobuIzdaoSearch.DisplayMember = "Name";
            cbRobuIzdaoSearch.ValueMember = "Id";

            cbVozacSearch.DataSource = loadData.VozacDtos;
            cbVozacSearch.DisplayMember = "Name";
            cbVozacSearch.ValueMember = "Id";

            cbVrstaRobeSearch.DataSource = loadData.VrstaRobeDtos;
            cbVrstaRobeSearch.DisplayMember = "Name";
            cbVrstaRobeSearch.ValueMember = "Id";

            cbVrstaUslugeSearch.DataSource = loadData.VrstaUslugeDtos;
            cbVrstaUslugeSearch.DisplayMember = "Name";
            cbVrstaUslugeSearch.ValueMember = "Id";

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
            int.TryParse(cbRegKamionaSearch.SelectedValue.ToString(), out int regId);
            int.TryParse(cbVrstaRobeSearch.SelectedValue.ToString(), out int vrstaRobeId);
            int.TryParse(cbRobuIzdaoSearch.SelectedValue.ToString(), out int robuIzdaoId);
            int.TryParse(cbVrstaUslugeSearch.SelectedValue.ToString(), out int vrstaUslugeId);
            int.TryParse(cbGradisliteSearch.SelectedValue.ToString(), out int radilisteId);
            int.TryParse(cbVozacSearch.SelectedValue.ToString(), out int vozacId);
            int.TryParse(cbNaruciteljSearch.SelectedValue.ToString(), out int naruciteljId);
            int.TryParse(cbPrimateljSearch.SelectedValue.ToString(), out int primateljId);

            ddgRadniNalozi.DataSource = rnServices.GetRnForTimePeriodAndReg(startDate, endDate, 
                regId, vrstaRobeId, robuIzdaoId, vrstaUslugeId, radilisteId, vozacId, naruciteljId, primateljId);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
