using Common.Enums;
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
    public partial class EdditSetting : Form
    {
        int Id { get; set; }
        CodeBook SettingId { get; set; }
        public EdditSetting(int id, CodeBook settingId)
        {
            Id = id;
            SettingId = settingId;
            InitializeComponent();
        }

        private void EdditSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
