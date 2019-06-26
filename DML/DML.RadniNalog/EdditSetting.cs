using Common.Enums;
using DML.Services.RadniNalozi;
using DML.VM;
using System;
using System.Windows.Forms;

namespace DML.RadniNalog
{
    public partial class EdditSetting : Form
    {
        int Id { get; set; }
        CodeBook status { get; set; }
        string Name { get; set; }

        RnServices rnServices;
        public EdditSetting(int id, CodeBook settingId, string name)
        {
            Id = id;
            status = settingId;
            InitializeComponent();
            Name = name;
            rnServices = new RnServices();
        }

        private void EdditSetting_Load(object sender, EventArgs e)
        {
            txtSettingsName.Text = Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BaseDto settingData = new BaseDto
            {
                Id = Id,
                Name = txtSettingsName.Text,
                PostavkaId = (int)status
            };

            rnServices.SaveOrUpdate(settingData);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool isDeletedOk = rnServices.DeletePostavka(Id);
            if(isDeletedOk) this.Close();
            else MessageBox.Show("Postiji vezani Radni Nalog");
        }
    }
}
