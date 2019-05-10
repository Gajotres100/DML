using Common.Enums;
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
                kolicinaRobe = kolicinaRobe,
                MjeraId = int.Parse(cbMjera.SelectedValue.ToString()),
            };

            rnServices.Save(data);
            tabControl1.SelectedIndex = 1;
        }

        private void RadniNalozi_Load(object sender, EventArgs e)
        {
            ddgRadniNalozi.DataSource = rnServices.GetRnDtos();
            //ovo prebaciti na otvaranje trećeg taba
            cbVrstaPostavke.DataSource = Enum.GetValues(typeof(CodeBook));
            GetLoadData();
        }

        private void GetLoadData()
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

            cbMjera.DataSource = loadData.MjeraDtos;
            cbMjera.DisplayMember = "Name";
            cbMjera.ValueMember = "Id";

            var loadDataSeckond = rnServices.GetLoadData();
            loadDataSeckond.NarutiteljDtos.Insert(0, new NarutiteljDto() { Id = 0, Name = "----Odaberi----" });
            loadDataSeckond.PrimateljDtos.Insert(0, new PrimateljDto() { Id = 0, Name = "----Odaberi----" });
            loadDataSeckond.RadilisteDtos.Insert(0, new RadilisteDto() { Id = 0, Name = "----Odaberi----" });
            loadDataSeckond.RegOznakaDtos.Insert(0, new RegOznakaDto() { Id = 0, Name = "----Odaberi----" });
            loadDataSeckond.RobuIzdaoDtos.Insert(0, new RobuIzdaoDto() { Id = 0, Name = "----Odaberi----" });
            loadDataSeckond.VozacDtos.Insert(0, new VozacDto() { Id = 0, Name = "----Odaberi----" });
            loadDataSeckond.VrstaRobeDtos.Insert(0, new VrstaRobeDto() { Id = 0, Name = "----Odaberi----" });
            loadDataSeckond.VrstaUslugeDtos.Insert(0, new VrstaUslugeDto() { Id = 0, Name = "----Odaberi----" });

            cbNaruciteljSearch.DataSource = loadDataSeckond.NarutiteljDtos;
            cbNaruciteljSearch.DisplayMember = "Name";
            cbNaruciteljSearch.ValueMember = "Id";

            cbPrimateljSearch.DataSource = loadDataSeckond.PrimateljDtos;
            cbPrimateljSearch.DisplayMember = "Name";
            cbPrimateljSearch.ValueMember = "Id";

            cbGradisliteSearch.DataSource = loadDataSeckond.RadilisteDtos;
            cbGradisliteSearch.DisplayMember = "Name";
            cbGradisliteSearch.ValueMember = "Id";

            cbRegKamionaSearch.DataSource = loadDataSeckond.RegOznakaDtos;
            cbRegKamionaSearch.DisplayMember = "Name";
            cbRegKamionaSearch.ValueMember = "Id";

            cbRobuIzdaoSearch.DataSource = loadDataSeckond.RobuIzdaoDtos;
            cbRobuIzdaoSearch.DisplayMember = "Name";
            cbRobuIzdaoSearch.ValueMember = "Id";

            cbVozacSearch.DataSource = loadDataSeckond.VozacDtos;
            cbVozacSearch.DisplayMember = "Name";
            cbVozacSearch.ValueMember = "Id";

            cbVrstaRobeSearch.DataSource = loadDataSeckond.VrstaRobeDtos;
            cbVrstaRobeSearch.DisplayMember = "Name";
            cbVrstaRobeSearch.ValueMember = "Id";

            cbVrstaUslugeSearch.DataSource = loadDataSeckond.VrstaUslugeDtos;
            cbVrstaUslugeSearch.DisplayMember = "Name";
            cbVrstaUslugeSearch.ValueMember = "Id";
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            ddgRadniNalozi.DataSource = rnServices.GetRnDtos();
            GetLoadData();
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

            var rnList = rnServices.GetRnForTimePeriodAndReg(startDate, endDate,
                regId, vrstaRobeId, robuIzdaoId, vrstaUslugeId, radilisteId, vozacId, naruciteljId, primateljId);

            ddgRadniNalozi.DataSource = rnList;

            var suma = rnList.GroupBy(g => g.Mjera).Select(cl => new SummPoFilterPodatcimaDto
            {
                Suma = cl.Sum(c => c.Kolicina.GetValueOrDefault()),
                Mjera = cl.Key
            }).ToList();
            var builder = new StringBuilder();            
            builder.Append("Ukupno:\n");
            foreach (var s in suma)
            {
                builder.Append(s.Suma + " " + s.Mjera + "\n");
            }
            lblSuma.Text = builder.ToString();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enum.TryParse(cbVrstaPostavke.SelectedValue.ToString(), out CodeBook status);

            if (status == CodeBook.Narucitelj) rnServices.SaveNarucitelj(txtSettingsName.Text);
            if (status == CodeBook.Primatelj) rnServices.SavePrimatelj(txtSettingsName.Text);
            if (status == CodeBook.Radiliste) rnServices.SaveRadiliste(txtSettingsName.Text);
            if (status == CodeBook.RegOznaka) rnServices.SaveRegOznaka(txtSettingsName.Text);
            if (status == CodeBook.RobuIzdao) rnServices.SaveRobuIzdao(txtSettingsName.Text);
            if (status == CodeBook.Vozac) rnServices.SaveVozac(txtSettingsName.Text);
            if (status == CodeBook.VrstaRobe) rnServices.SaveVrstaRobe(txtSettingsName.Text);
            if (status == CodeBook.VrstaUsluge) rnServices.SaveVrstaUsluge(txtSettingsName.Text);

            if (status == CodeBook.Narucitelj) dtgSettings.DataSource = rnServices.GetNarucitelj();
            if (status == CodeBook.Primatelj) dtgSettings.DataSource = rnServices.GetPrimatelj();
            if (status == CodeBook.Radiliste) dtgSettings.DataSource = rnServices.GetRadiliste();
            if (status == CodeBook.RegOznaka) dtgSettings.DataSource = rnServices.GetRegOznaka();
            if (status == CodeBook.RobuIzdao) dtgSettings.DataSource = rnServices.GetRobuIzdao();
            if (status == CodeBook.Vozac) dtgSettings.DataSource = rnServices.GetVozac();
            if (status == CodeBook.VrstaRobe) dtgSettings.DataSource = rnServices.GetVrstaRobe();
            if (status == CodeBook.VrstaUsluge) dtgSettings.DataSource = rnServices.GetVrstaUsluge();

            DataGridViewColumn column = dtgSettings.Columns[1];
            column.Width = 600;
        }

        private void cbVrstaPostavke_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(cbVrstaPostavke.SelectedValue.ToString(), out CodeBook status);

            if (status == CodeBook.Narucitelj) dtgSettings.DataSource = rnServices.GetNarucitelj();
            if (status == CodeBook.Primatelj) dtgSettings.DataSource = rnServices.GetPrimatelj();
            if (status == CodeBook.Radiliste) dtgSettings.DataSource = rnServices.GetRadiliste();
            if (status == CodeBook.RegOznaka) dtgSettings.DataSource = rnServices.GetRegOznaka();
            if (status == CodeBook.RobuIzdao) dtgSettings.DataSource = rnServices.GetRobuIzdao();
            if (status == CodeBook.Vozac) dtgSettings.DataSource = rnServices.GetVozac();
            if (status == CodeBook.VrstaRobe) dtgSettings.DataSource = rnServices.GetVrstaRobe();
            if (status == CodeBook.VrstaUsluge) dtgSettings.DataSource = rnServices.GetVrstaUsluge();

            DataGridViewColumn column = dtgSettings.Columns[1];
            column.Width = 600;
        }
    }
}
