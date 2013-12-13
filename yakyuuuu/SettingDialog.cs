using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yakyuuuu
{

    public partial class SettingDialog : Form
    {
        ConvertSettings settings;

        public SettingDialog()
        {
            InitializeComponent();
            settings = new ConvertSettings();
            
        }

        private void SettingDialog_Load(object sender, EventArgs e)
        {
            checkBoxSkipN.Checked = settings.SkipN;
        }

    }
}
