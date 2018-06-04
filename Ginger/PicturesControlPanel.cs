using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ginger
{
    public partial class Pictures : Form
    {
        int [] wideselector = { 0, 1, 2, 3, 4, 5, 6};
        List<Picture> mainpictures;
        // CircularDoublyLinkedList<Picture> Main = new CircularDoublyLinkedList<Picture>();
        int MainPointer = 0;

        void UpdateWindow ()
        {
            DisposeAllPictures();

            int c = mainpictures.Count;

            if (c>0)
            MainPicture.Image = Image.FromFile(mainpictures[wideselector[MainPointer]].Link);

            if (c > 0)
                pic01.Image = Image.FromFile(mainpictures[wideselector[0]].LinkPreview);
            if (c > 1)
                pic02.Image = Image.FromFile(mainpictures[wideselector[1]].LinkPreview);
            if (c > 2)
                pic03.Image = Image.FromFile(mainpictures[wideselector[2]].LinkPreview);
            if (c > 3)
                pic04.Image = Image.FromFile(mainpictures[wideselector[3]].LinkPreview);
            if (c > 4)
                pic05.Image = Image.FromFile(mainpictures[wideselector[4]].LinkPreview);
            if (c > 5)
                pic06.Image = Image.FromFile(mainpictures[wideselector[5]].LinkPreview);
            if (c > 6)
                pic07.Image = Image.FromFile(mainpictures[wideselector[6]].LinkPreview);

            if (mainpictures.Count <= 7)
            {
                ButtonLeft.Enabled = false;
                ButtonRight.Enabled = false;
            }
            else
            {
                ButtonLeft.Enabled = true;
                ButtonRight.Enabled = true;
            }

            if (MainPointer < 0) MainPointer = 0;
            if (MainPointer > 6) MainPointer = 6;

            if (c <= 0) ButtonDeletePicture.Enabled = false;
            else ButtonDeletePicture.Enabled = true;

        }

        void MoveRight ()
        {
            if (mainpictures.Count == 0) return;

            if (wideselector[6] == (mainpictures.Count-1)) return;

            wideselector[0]++;
            wideselector[1]++;
            wideselector[2]++;
            wideselector[3]++;
            wideselector[4]++;
            wideselector[5]++;
            wideselector[6]++;

        }

        void MoveLeft()
        {
            if (mainpictures.Count == 0) return;

            if (wideselector[0] == 0) return;

            wideselector[0]--;
            wideselector[1]--;
            wideselector[2]--;
            wideselector[3]--;
            wideselector[4]--;
            wideselector[5]--;
            wideselector[6]--;

        }

        void RefillListMain ()
        {
            // Заполняем заново список картинок
            DalADO dal = new DalADO();

            if (Tag==null)
            mainpictures = dal.GetPictures(0);
            else
            mainpictures = dal.GetPictures((int)Tag);
        }

        void DisposeAllPictures()
        {
            if (pic01.Image != null)
            {
                pic01.Image.Dispose();
                pic01.Image = null;
            }
            if (pic02.Image != null)
            {
                pic02.Image.Dispose();
                pic02.Image = null;
            }
            if (pic03.Image != null)
            {
                pic03.Image.Dispose();
                pic03.Image = null;
            }
            if (pic04.Image != null)
            {
                pic04.Image.Dispose();
                pic04.Image = null;
            }
            if (pic05.Image != null)
            {
                pic05.Image.Dispose();
                pic05.Image = null;
            }
            if (pic06.Image != null)
            {
                pic06.Image.Dispose();
                pic06.Image = null;
            }
            if (pic07.Image != null)
            {
                pic07.Image.Dispose();
                pic07.Image = null;
            }

            if (MainPicture.Image != null)
            {
                MainPicture.Image.Dispose();
                MainPicture.Image = null;
            }
        }
    }
}
