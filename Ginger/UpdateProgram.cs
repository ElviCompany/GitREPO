using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ginger
{
    class UpdateProgram
    {
        public bool UpdateIniFile ()
        {
            Init ini = new Init();
            ini.SaveAllParameters();
            MessageBox.Show("Программа обновлена. Перезапустите программу");
            return true;
        }

        public bool UpdateDB ()
        {
            MessageBox.Show("Предполагается, что база обновилась");
            return true;
        }
    }
}
