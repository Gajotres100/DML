using Common.Enums;
using DML.Services.RadniNalozi;
using DML.VM;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DML.RadniNalog
{
    public partial class EditRn : Form
    {
        RnServices rnServices;
        int Id { get; set; }

        public EditRn(int id)
        {
            InitializeComponent();
            Id = id;
            rnServices = new RnServices();
        }

        private void EditRn_Load(object sender, EventArgs e)
        {
            GetLoadData();
        }

        private void GetLoadData()
        {
            var rn = rnServices.GetRnDto(Id);

            var loadData = rnServices.GetLoadData();

            cbNarucitelj.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Kupac).ToList();
            cbNarucitelj.DisplayMember = "Name";
            cbNarucitelj.ValueMember = "Id";
            cbNarucitelj.SelectedValue = rn.NaruciteljId;

            cbPrimatelj.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Skladiste).ToList();
            cbPrimatelj.DisplayMember = "Name";
            cbPrimatelj.ValueMember = "Id";
            cbPrimatelj.SelectedValue = rn.PrimateljId;

            cbRadiliste.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Radiliste).ToList();
            cbRadiliste.DisplayMember = "Name";
            cbRadiliste.ValueMember = "Id";
            cbRadiliste.SelectedValue = rn.RadilisteId;

            cbRegOznakaKamiona.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.RegOznaka).ToList();
            cbRegOznakaKamiona.DisplayMember = "Name";
            cbRegOznakaKamiona.ValueMember = "Id";
            cbRegOznakaKamiona.SelectedValue = rn.RegOznakaId;

            cbRobuIzdao.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.RobuIzdao).ToList();
            cbRobuIzdao.DisplayMember = "Name";
            cbRobuIzdao.ValueMember = "Id";
            cbRobuIzdao.SelectedValue = rn.RobuIzdaoId;

            cbVozac.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Vozac).ToList();
            cbVozac.DisplayMember = "Name";
            cbVozac.ValueMember = "Id";
            cbVozac.SelectedValue = rn.VozacId;

            cbVrstaRobe.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.VrstaRobe).ToList();
            cbVrstaRobe.DisplayMember = "Name";
            cbVrstaRobe.ValueMember = "Id";

            cbVrstaUsluge.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.VrstaUsluge).ToList();
            cbVrstaUsluge.DisplayMember = "Name";
            cbVrstaUsluge.ValueMember = "Id";
            cbVrstaUsluge.SelectedValue = rn.VrstaUslugeId;

            cbMjera.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Mjera).ToList();
            cbMjera.DisplayMember = "Name";
            cbMjera.ValueMember = "Id";
            cbMjera.SelectedValue = rn.MjeraId;

            txtRadniNalog.Text = rn.RN;
            txtVrstaStroja.Text = rn.VrstaStroja;
            TxtKolicinaRobe.Text = rn.kolicinaRobe.ToString();
        }

        private void btnSaveRn_Click(object sender, EventArgs e)
        {
            decimal.TryParse(TxtKolicinaRobe.Text, out decimal kolicinaRobe);
            DateTime.TryParse(dtpDatum.Text, out DateTime datum);

            var data = new RnDto
            {
                Id = Id,
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
            this.Close();
        }
    }
}
