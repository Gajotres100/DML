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
using Microsoft.Office.Interop.Excel;

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

            cbNarucitelj.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Narucitelj).ToList();
            cbNarucitelj.DisplayMember = "Name";
            cbNarucitelj.ValueMember = "Id";

            cbPrimatelj.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Primatelj).ToList();
            cbPrimatelj.DisplayMember = "Name";
            cbPrimatelj.ValueMember = "Id";

            cbRadiliste.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Radiliste).ToList();
            cbRadiliste.DisplayMember = "Name";
            cbRadiliste.ValueMember = "Id";

            cbRegOznakaKamiona.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.RegOznaka).ToList();
            cbRegOznakaKamiona.DisplayMember = "Name";
            cbRegOznakaKamiona.ValueMember = "Id";

            cbRobuIzdao.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.RobuIzdao).ToList();
            cbRobuIzdao.DisplayMember = "Name";
            cbRobuIzdao.ValueMember = "Id";

            cbVozac.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Vozac).ToList();
            cbVozac.DisplayMember = "Name";
            cbVozac.ValueMember = "Id";

            cbVrstaRobe.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.VrstaRobe).ToList();
            cbVrstaRobe.DisplayMember = "Name";
            cbVrstaRobe.ValueMember = "Id";

            cbVrstaUsluge.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.VrstaUsluge).ToList();
            cbVrstaUsluge.DisplayMember = "Name";
            cbVrstaUsluge.ValueMember = "Id";

            cbMjera.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Mjera).ToList();
            cbMjera.DisplayMember = "Name";
            cbMjera.ValueMember = "Id";

            //var loadDataSeckond = rnServices.GetLoadData();
            loadData.BaseDtos.Insert(0, new BaseDto() { Id = 0, Name = "----Odaberi----" });

            cbNaruciteljSearch.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Narucitelj || x.Id == 0).ToList();
            cbNaruciteljSearch.DisplayMember = "Name";
            cbNaruciteljSearch.ValueMember = "Id";

            cbPrimateljSearch.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Primatelj || x.Id == 0).ToList();
            cbPrimateljSearch.DisplayMember = "Name";
            cbPrimateljSearch.ValueMember = "Id";

            cbGradisliteSearch.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Radiliste || x.Id == 0).ToList();
            cbGradisliteSearch.DisplayMember = "Name";
            cbGradisliteSearch.ValueMember = "Id";

            cbRegKamionaSearch.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.RegOznaka || x.Id == 0).ToList();
            cbRegKamionaSearch.DisplayMember = "Name";
            cbRegKamionaSearch.ValueMember = "Id";

            cbRobuIzdaoSearch.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.RobuIzdao || x.Id == 0).ToList();
            cbRobuIzdaoSearch.DisplayMember = "Name";
            cbRobuIzdaoSearch.ValueMember = "Id";

            cbVozacSearch.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.Vozac || x.Id == 0).ToList();
            cbVozacSearch.DisplayMember = "Name";
            cbVozacSearch.ValueMember = "Id";

            cbVrstaRobeSearch.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.VrstaRobe || x.Id == 0).ToList();
            cbVrstaRobeSearch.DisplayMember = "Name";
            cbVrstaRobeSearch.ValueMember = "Id";

            cbVrstaUslugeSearch.DataSource = loadData.BaseDtos.Where(x => x.PostavkaId == (int)CodeBook.VrstaUsluge || x.Id == 0).ToList();
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
            BaseDto data = new BaseDto
            {
                Name = txtSettingsName.Text,
                PostavkaId = (int)status
            };

            rnServices.SaveOrUpdate(data);

            rnServices.GetLoadData();
            var dataGet = rnServices.GetLoadData().BaseDtos.Where(x => x.PostavkaId == (int)status).ToList();

            dtgSettings.DataSource = dataGet;

            if (dataGet.Count() > 0)
            {
                DataGridViewColumn column = dtgSettings.Columns[1];
                column.Width = 600;
            }
        }

        private void cbVrstaPostavke_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(cbVrstaPostavke.SelectedValue.ToString(), out CodeBook status);
            var data = rnServices.GetLoadData().BaseDtos.Where(x => x.PostavkaId == (int)status).ToList();
            dtgSettings.DataSource = data;

            if (data.Count() > 0)
            {
                DataGridViewColumn column = dtgSettings.Columns[1];
                column.Width = 600;
            }
        }

        private void dtgSettings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Enum.TryParse(cbVrstaPostavke.SelectedValue.ToString(), out CodeBook status);
            int.TryParse(this.dtgSettings.CurrentRow.Cells[0].Value.ToString(), out int id);
            if (id > 0)
            {
                Form es = new EdditSetting(id, status, this.dtgSettings.CurrentRow.Cells[1].Value.ToString());
                es.FormClosed += new FormClosedEventHandler(es_FormClosed);
                es.Show();
            }            
        }

        private void es_FormClosed(object sender, EventArgs e)
        {
            Enum.TryParse(cbVrstaPostavke.SelectedValue.ToString(), out CodeBook status);
             var data = rnServices.GetLoadData().BaseDtos.Where(x => x.PostavkaId == (int)status).ToList();

            dtgSettings.DataSource = data;

            if (data.Count() > 0)
            {
                DataGridViewColumn column = dtgSettings.Columns[1];
                column.Width = 600;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void copyAlltoClipboard()
        {
            ddgRadniNalozi.SelectAll();
            DataObject dataObj = ddgRadniNalozi.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void ddgRadniNalozi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int.TryParse(this.ddgRadniNalozi.CurrentRow.Cells[0].Value.ToString(), out int id);
            if (id > 0)
            {
                Form es = new EditRn(id);
                es.FormClosed += new FormClosedEventHandler(es_FormClosedEdit);
                es.Show();
            }
        }

        private void es_FormClosedEdit(object sender, EventArgs e)
        {
            ddgRadniNalozi.DataSource = rnServices.GetRnDtos();
            GetLoadData();
        }
    }
}
