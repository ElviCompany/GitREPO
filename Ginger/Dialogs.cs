using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ginger
{
    static class Dialogs
    {
        /// <summary>
        /// Предупреждение и ввод пароля в случае первого запуска программы
        /// </summary>
        /// <returns></returns>
        public static bool ControlAttentionUniversal (string Msg=null)
        {
            FileDamageAttn frm2 = new FileDamageAttn();
            int i = 0, TryToPass = 3;
            bool isPwdCorrect = false;

            frm2.Tag = Msg;

            do
            {
                frm2.ShowDialog();
                if (frm2.DialogResult == DialogResult.OK)
                {
                    if (frm2.IsPasswordCorrect)
                    {
                        isPwdCorrect = true;
                        frm2.Dispose();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Неверно!");
                        i++;
                    }
                }
                else
                {
                    frm2.Dispose();
                    break;
                }
            } while (i < TryToPass);

            return isPwdCorrect;
        }

        /// <summary>
        /// Предупреждение и ввод пароля в случае обнаружения повреждения файла настроек
        /// </summary>
        /// <returns></returns>
        public static bool ControlAttentionFirstStart ()
        {
            FirstStartAtten frm1 = new FirstStartAtten();
            int i = 0, TryToPass = 3;
            bool isPwdCorrect = false;

            do
            {
                frm1.ShowDialog();
                if (frm1.DialogResult == DialogResult.OK)
                {
                    if (frm1.IsPasswordCorrect)
                    {
                        isPwdCorrect = true;
                        frm1.Dispose();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Неверно!");
                        i++;
                    }
                }
                else
                {
                    frm1.Dispose();
                    break;
                }
            } while (i < TryToPass);

            return isPwdCorrect;
        }

        public static bool ControlAttentionFileNewer ()
        {
            return true;
        }
    }
}
