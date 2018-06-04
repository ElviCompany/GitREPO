using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ginger
{
    public partial class FormIniFilePath : Form
    {
        public FormIniFilePath(string iniFilePath)
        {
            InitializeComponent();
            lblIniFilePath.Text = iniFilePath;
        }

        private void MenuItemClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblIniFilePath.Text.Trim());
        }

    }
}
