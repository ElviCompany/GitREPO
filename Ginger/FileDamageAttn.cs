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
    public partial class FileDamageAttn : Form
    {
        public bool IsPasswordCorrect { get; private set; } = false;
        public FileDamageAttn()
        {
            InitializeComponent();
        }

        private void ButtonCancelPwdAttn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOKPwdAttn_Click(object sender, EventArgs e)
        {
            string pwd = "";

            pwd = boxPwdAttn.Text;
            if (PwdChecking.IsPasswordCorrect(pwd)) { IsPasswordCorrect = true; }
            else { IsPasswordCorrect = false; }
            Close();
        }

        private void FileDamageAttn_Activated(object sender, EventArgs e)
        {
            boxPwdAttn.Focus();
        }

        private void FileDamageAttn_Shown(object sender, EventArgs e)
        {
            if (Tag != null)
            {
                lblTextFirstAttn.Text = Tag.ToString();
            }

        }
    }
}
