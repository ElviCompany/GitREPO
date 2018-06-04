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
    public partial class ApptCardPhone : Form
    {
        private PhonesDelegate D;
        string Phones;
        public ApptCardPhone()
        {
            InitializeComponent();
        }
        public ApptCardPhone(PhonesDelegate sender, string phones)
        {
            InitializeComponent();
            D = sender;
            Phones = phones;
        }

        private void ApptCardPhone_Shown(object sender, EventArgs e)
        {
            boxPhones.Text = Phones;
        }

        private void ButtonPhonesSave_Click(object sender, EventArgs e)
        {
            D(boxPhones.Text);
        }
    }
}
