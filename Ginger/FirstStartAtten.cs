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
    public partial class FirstStartAtten : Form
    {
        public bool IsPasswordCorrect { get; private set; } = false;
        public FirstStartAtten()
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

        private void FirstStartAtten_Activated(object sender, EventArgs e)
        {
            boxPwdAttn.Focus();
        }
    }
}
