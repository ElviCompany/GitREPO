using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ginger
{
    public partial class Pictures : Form
    {
        const int MaxWidth = 133;
        const int MaxHeight = 88;

        #region FormActions
        public Pictures()
        {
            InitializeComponent();
        }

        public Pictures(string ApptComment)
        {
            InitializeComponent();
            boxApptComment.Text = ApptComment;
        }
        private void Pictures_Shown(object sender, EventArgs e)
        {
            RefillListMain();
            UpdateWindow();
        }

        private void Pictures_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeAllPictures();
        }

        #endregion

        #region ButtonsClick
        private void ButtonDeletePicture_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить изображение ?",
                "Требуется подтверждение", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                DelPicture(mainpictures[MainPointer].IdPicture);
                MainPointer--;
                RefillListMain();
                UpdateWindow();
            }
        }

        private void ButtonAddPicture_Click(object sender, EventArgs e)
        {
            openFileDialogPicture.Multiselect = true;

            if (openFileDialogPicture.ShowDialog() == DialogResult.Cancel)
                return;

            string[] Files = openFileDialogPicture.FileNames;
            foreach (string filepath in Files)
            {
                AddPicture(filepath);
            }

            RefillListMain();
            UpdateWindow();

            if (Files.Length > 1)
                MessageBox.Show("Добавлено " + Files.Length.ToString() + " изображений");
            else if (Files.Length == 1) MessageBox.Show("Добавлено одно изображение");
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            //DisposeAllPictures();
            Close();
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            MoveLeft();
            UpdateWindow();

            //boxPicturesNote.Text = "Рисунок XX из " + mainpictures.Count.ToString();
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            MoveRight();
            UpdateWindow();

            //boxPicturesNote.Text = "Рисунок XX из " + mainpictures.Count.ToString();
        }

        private void Pic01_Click(object sender, EventArgs e)
        {
            MainPointer = 0;
            UpdateWindow();
        }

        private void Pic02_Click(object sender, EventArgs e)
        {
            MainPointer = 1;
            UpdateWindow();
        }

        private void Pic03_Click(object sender, EventArgs e)
        {
            MainPointer = 2;
            UpdateWindow();
        }

        private void Pic04_Click(object sender, EventArgs e)
        {
            MainPointer = 3;
            UpdateWindow();
        }

        private void Pic05_Click(object sender, EventArgs e)
        {
            MainPointer = 4;
            UpdateWindow();
        }

        private void Pic06_Click(object sender, EventArgs e)
        {
            MainPointer = 5;
            UpdateWindow();
        }

        private void Pic07_Click(object sender, EventArgs e)
        {
            MainPointer = 6;
            UpdateWindow();
        }

        private void ButtonUnloadPicture_Click(object sender, EventArgs e)
        {
            UnloadPicture();
        }


        #endregion
        
        #region BitmapConversion

        private void ResizeAndCompress(string sourcepath, string destpreviewpath)
        {
            Image resizebmp = new Bitmap(sourcepath);
            ResizeImage(ref resizebmp);
            SaveImage(resizebmp, destpreviewpath);
            resizebmp.Dispose();
        }

        /// <summary>
        /// Сохранение JPG со сжатием
        /// </summary>
        /// <param name="image">Сохраняемое изображение</param>
        /// <param name="filename">Файл в который будет сохраняться</param>
        private void SaveImage(Image image, string filename)
        {
            var jgpEncoder = GetEncoder(ImageFormat.Jpeg);
            var myEncoder = System.Drawing.Imaging.Encoder.Quality;
            var myEncoderParameters = new EncoderParameters(1);
            var myEncoderParameter = new EncoderParameter(myEncoder, 50L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            image.Save(filename, jgpEncoder, myEncoderParameters);
            image.Dispose();
        }
        public static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            var codecs = ImageCodecInfo.GetImageDecoders();
            return codecs.FirstOrDefault(codec => codec.FormatID == format.Guid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        private void ResizeImage(ref Image image)
        {
            if (image.Height <= MaxHeight && image.Width <= MaxWidth)
                return;

            /*var ratio = image.Width >= image.Height
                ? (float)MaxImageSize / image.Width
                : (float)MaxImageSize / image.Height;*/
            float ratioWidth = (float)MaxWidth / image.Width;
            float ratioHeight = (float)MaxHeight / image.Height;

            float ratio = ratioHeight > ratioWidth ? ratioHeight : ratioWidth;

            var nWidth = ratio * image.Width;
            var nHeight = ratio * image.Height;

            var resultImage = new Bitmap((int)(nWidth), (int)(nHeight), PixelFormat.Format16bppRgb565);
            using (var gx = Graphics.FromImage(resultImage))
            {
                gx.Clear(Color.White);
                gx.DrawImage(image,
                    new RectangleF(0, 0, nWidth, nHeight),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            }

            image.Dispose();
            image = resultImage;
        }

        #endregion BitmapConversion

        #region CRUD
        private void AddPicture(string SourcePath)
        {
            
            string SourceExt = Path.GetExtension(SourcePath);

            //string DestFilename = String.Format("{0}_{1}{2}", DateTime.Now.ToString("yyyyMMddHHmmssfff"), Guid.NewGuid(), SourceExt);
            string DestFilename = String.Format("{0}{1}", DateTime.Now.ToString("yyyyMMddHHmmssfff"), SourceExt);

            Init ini = new Init();
            string DestPath = Path.Combine(ini.PicturePath, DestFilename);
            string DestPreviewDir = Path.Combine(ini.PicturePath, "Thumb");
            if (!Directory.Exists(DestPreviewDir))
                Directory.CreateDirectory(DestPreviewDir);
            string DestPreviewPath = Path.Combine(DestPreviewDir, DestFilename);

            Picture picture = new Picture
            {
                Id = (Tag==null)?0:(int)Tag, // При пустом ID (новая запись), подменяем ее на временный 0 (иначе LINQ глючит).
                Link = DestPath,             // Затем при закрытии окна либо пперепишем ID, либо удалим все записи, у которых ID==0
                LinkPreview = DestPreviewPath,
                ShortNotes = " ",
                MainPicture = false
            };

            DalADO dal = new DalADO();
            int id = dal.AddPicture(picture);
            //boxPictureComment.Text = id.ToString();

            File.Copy(SourcePath, DestPath, true);
            ResizeAndCompress(SourcePath, DestPreviewPath);
        }

        private void DelPicture(int IDPicture)
        {
            DisposeAllPictures();

            DalADO dal = new DalADO();
            dal.DelPicture(IDPicture);
        }

        void UnloadPicture()
        { MessageBox.Show("Выгрузка пока не работает"); }

        #endregion
    }

}

