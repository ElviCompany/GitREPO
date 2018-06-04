using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ginger
{
    public partial class Form1 : Form
    {
        #region Form1GlobalVariables
        bool SuperUserMode = false;
        byte ProgramMode;
        const byte PROGRAM_MODE_AGENTS = 0;
        const byte PROGRAM_MODE_ARCHIVE = 1;
        const byte PROGRAM_MODE_CATALOGUE = 2;
        const byte PROGRAM_MODE_CLIENTS = 3;
        const byte PROGRAM_MODE_MEETINGS = 4;
        const byte PROGRAM_MODE_RENTED = 5;
        const byte PROGRAM_MODE_REPORTS = 6;
        const byte PROGRAM_MODE_SETTINGS = 7;
        const byte PROGRAM_MODE_START = 8;
        const byte PROGRAM_MODE_START_OR_PROBLEM_SETTINGS = 9;
        #endregion Form1GlobalVariables
        public Form1()
        {
            InitializeComponent();

            #region Form1Template
            /*
                PanelAgents.Visible = false;
                PanelArchive.Visible = false;
                PanelCatalogue.Visible = false;
                PanelClients.Visible = false;
                PanelMeetings.Visible = false;
                PanelRented.Visible = false;
                PanelReports.Visible = false;
                PanelSettings.Visible = false;

                PanelStart.Visible = true;
            */
            #endregion Form1Template

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyWorkersDataSet.Appartments". При необходимости она может быть перемещена или удалена.
            // this.appartmentsTableAdapter.Fill(this.companyWorkersDataSet.Appartments);
            byte startcheck = StartCheckList();
            if (startcheck == CHECK_EXIT) // Все проверки вначале делаем, устанавливаем все переменные и т.д.
            {
                Application.Exit();
            }
            else if (startcheck == CHECK_SETTINGS)
            {
                ProgramMode = PROGRAM_MODE_START_OR_PROBLEM_SETTINGS;
                SetVisibilityPanels();
            }
            else if (startcheck == CHECK_OK)
            {
                ProgramMode = PROGRAM_MODE_START;
                SetVisibilityPanels();
            }
        }

        #region Form1PanelButtons
        private void ButtonRented_Click(object sender, EventArgs e)
        {
            ProgramMode = PROGRAM_MODE_RENTED;
            SetVisibilityPanels();

            FillRentedDataGrid();
        }

        private void ButtonCatalogue_Click(object sender, EventArgs e)
        {
            ProgramMode = PROGRAM_MODE_CATALOGUE;
            SetVisibilityPanels();

            if (dataGridCatalogue.DataSource == null)
            { ButtonAdd.Enabled = false; }
            else { ButtonAdd.Enabled = true; }

            FillCatalogueDataGrid();
        }

        private void ButtonArchive_Click(object sender, EventArgs e)
        {
            ProgramMode = PROGRAM_MODE_ARCHIVE;
            SetVisibilityPanels();

            FillArchiveDataGrid();
        }

        private void ButtonMeetings_Click(object sender, EventArgs e)
        {
            ProgramMode = PROGRAM_MODE_MEETINGS;
            SetVisibilityPanels();
        }

        private void ButtonClients_Click(object sender, EventArgs e)
        {
            ProgramMode = PROGRAM_MODE_CLIENTS;
            SetVisibilityPanels();
        }

        private void ButtonAgents_Click(object sender, EventArgs e)
        {
            ProgramMode = PROGRAM_MODE_AGENTS;
            SetVisibilityPanels();
        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {
            ProgramMode = PROGRAM_MODE_REPORTS;
            SetVisibilityPanels();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            if (ProgramMode == PROGRAM_MODE_START_OR_PROBLEM_SETTINGS)
            {
                ProgramMode = PROGRAM_MODE_START_OR_PROBLEM_SETTINGS;
                SetVisibilityPanels();
            }
            else
            {
                ProgramMode = PROGRAM_MODE_SETTINGS;
                SetVisibilityPanels();
            }
        }

        #endregion Form1PanelButtons

        #region Form1Buttons

        private void ButtonCancelIni_Click(object sender, EventArgs e)
        {
            Init ini = new Init();
            boxConnectionString.Text = ini.DbConnectString;
            boxPicturePath.Text = ini.PicturePath.Trim();
            maskDaysLittle.Text = ini.DaysLittle.ToString().Trim();
            maskDaysTooLittle.Text = ini.DaysTooLittle.ToString().Trim();
        }

        private void ButtonSaveIni_Click(object sender, EventArgs e)
        {
            Init ini = new Init
            {
                DbConnectString = boxConnectionString.Text.Trim(),
                PicturePath = boxPicturePath.Text.Trim(),
                DaysLittle = int.Parse(maskDaysLittle.Text.Trim()),
                DaysTooLittle = int.Parse(maskDaysTooLittle.Text.Trim()),

                ColorForDaysLittle = ColorForDaysLittle.BackColor.Name
            };

            ini.SaveAllParameters();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridCatalogue.DataSource == null)
            {
                MessageBox.Show("Какая-то ошибка, база данных не подключена");
                ButtonAdd.Enabled = false;
                return;
            }
            ApptCard frmApt = new ApptCard();
            if (frmApt.ShowDialog()==DialogResult.OK)
            {
                FillCatalogueDataGrid();
            }
           
        }

        private void ButtonFillGrid_Click(object sender, EventArgs e)
        {
            //FillCatalogueDataGrid();
            DalADO dal = new DalADO();
            dal.InitDB();

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridCatalogue.SelectedCells.Count != 0)
            {
                int x = (int)dataGridCatalogue.SelectedCells[0].Value;
                ApptCard frmApt = new ApptCard
                {
                    Tag = x
                };
                if (frmApt.ShowDialog() == DialogResult.OK)
                {
                    FillCatalogueDataGrid();
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int ID = (int)dataGridCatalogue.SelectedCells[0].Value;

            if (MessageBox.Show(String.Format ("Действительно удалить квартиру с кодом {0} из справочника?", ID),
                "Внимание", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2 )==DialogResult.OK)
            {
                DalADO dal = new DalADO();
                dal.DeleteRecord(ID);
                FillCatalogueDataGrid();
            }

            if (dataGridCatalogue.Rows.Count != 0)
            {
                ButtonEdit.Enabled = true;
                ButtonDelete.Enabled = true;
            }
            else
            {
                ButtonEdit.Enabled = false;
                ButtonDelete.Enabled = false;
            }

            SuperUserMode = false;
            ButtonDelete.Enabled = false;
        }

        private void ButtonCheckConnection_Click(object sender, EventArgs e)
        {
            DalADO dal = new DalADO();
            Init ini = new Init
            {
                DbConnectString = boxConnectionString.Text.Trim()
            };
            ini.SaveAllParameters();

            if (dal.IsDbConnectionOK()==true)
            {
                MessageBox.Show("Соединение с базой данных установлено успешно.\n" +
                    "Для работы нажмите \"Сохранить\" и перезапустите программу");
                // SuperUserMode = true;
            }
            else
            {
                MessageBox.Show("Не удалось установить соединение с базой данных.");
                // SuperUserMode = false;
            }

            SetVisibilityPanels();
        }

        private void ButtonAdminAccess_Click(object sender, EventArgs e)
        {
            if (SuperUserMode == true)
                SuperUserMode = false;
            else
            {
                if (Dialogs.ControlAttentionUniversal("Требуется пароль администратора") == true)
                {
                    SuperUserMode = true;
                }
                else
                {
                    SuperUserMode = false;
                }
            }
            SetVisibilityPanels();
        }

        private void ButtonSelectPictureFolder_Click(object sender, EventArgs e)
        {
            dlgFolderSelect.SelectedPath = boxPicturePath.Text;
            dlgFolderSelect.ShowNewFolderButton = true;
            if (dlgFolderSelect.ShowDialog() == DialogResult.OK)
            {
                boxPicturePath.Text = dlgFolderSelect.SelectedPath;
            }
        }

        private void ButtonCreateDB_Click(object sender, EventArgs e)
        {
            DalADO dal = new DalADO();
            dal.InitDB();
        }

        private void ColorForDaysLittle_DoubleClick(object sender, EventArgs e)
        {
            colorSelectDialog.Color = ColorForDaysLittle.BackColor;
            if (colorSelectDialog.ShowDialog() == DialogResult.OK)
            { ColorForDaysLittle.BackColor = colorSelectDialog.Color; }
        }

        private void ColorForDaysTooLittle_DoubleClick(object sender, EventArgs e)
        {
            colorSelectDialog.Color = ColorForDaysTooLittle.BackColor;
            if (colorSelectDialog.ShowDialog() == DialogResult.OK)
            { ColorForDaysTooLittle.BackColor = colorSelectDialog.Color; }
        }

        #endregion Form1Buttons

        #region Form1RightMenu
        private void MenuToArchiveFromCatalogue_Click(object sender, EventArgs e)
        {
            if (dataGridCatalogue.SelectedCells.Count != 0)
            {
                int ID = (int)dataGridCatalogue.SelectedCells[0].Value;

                if (MessageBox.Show(String.Format("Отправить в архив квартиру с ID = {0}?", ID),
                    "Внимание", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DalADO dal = new DalADO();
                    dal.ChangeStatus(ID, 2);
                    FillCatalogueDataGrid();
                    FillRentedDataGrid();
                    FillArchiveDataGrid();
                }
            }
        }

        private void MenuToRentFromCatalogue_Click(object sender, EventArgs e)
        {
            if (dataGridCatalogue.SelectedCells.Count != 0)
            {
                int ID = (int)dataGridCatalogue.SelectedCells[0].Value;

                if (MessageBox.Show(String.Format("Сдать квартиру с ID = {0}?", ID),
                    "Внимание", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DalADO dal = new DalADO();
                    dal.ChangeStatus(ID, 1);
                    FillCatalogueDataGrid();
                    FillRentedDataGrid();
                    FillArchiveDataGrid();
                }
            }
        }

        private void MenuToActiveFromArchive_Click(object sender, EventArgs e)
        {
            if (DataGridArchive.SelectedCells.Count != 0)
            {
                int ID = (int)DataGridArchive.SelectedCells[0].Value;

                if (MessageBox.Show(String.Format("Вернуть квартиру с ID = {0} в активные?", ID),
                    "Внимание", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DalADO dal = new DalADO();
                    dal.ChangeStatus(ID, 0);
                    FillCatalogueDataGrid();
                    FillRentedDataGrid();
                    FillArchiveDataGrid();
                }
            }
        }

        private void MenuToActiveFromRented_Click(object sender, EventArgs e)
        {
            if (DataGridRented.SelectedCells.Count != 0)
            {
                int ID = (int)DataGridRented.SelectedCells[0].Value;

                if (MessageBox.Show(String.Format("Вернуть квартиру с ID = {0} в активные?", ID),
                    "Внимание", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DalADO dal = new DalADO();
                    dal.ChangeStatus(ID, 0);
                    FillCatalogueDataGrid();
                    FillRentedDataGrid();
                    FillArchiveDataGrid();
                }
            }
        }

        private void MenuToArchiveFromRented_Click(object sender, EventArgs e)
        {
            if (DataGridRented.SelectedCells.Count != 0)
            {
                int ID = (int)DataGridRented.SelectedCells[0].Value;

                if (MessageBox.Show(String.Format("Отправить в архив квартиру с ID = {0}?", ID),
                    "Внимание", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DalADO dal = new DalADO();
                    dal.ChangeStatus(ID, 2);
                    FillCatalogueDataGrid();
                    FillRentedDataGrid();
                    FillArchiveDataGrid();
                }
            }
        }


        #endregion Form1RightMenu        

        #region Validation
        private void MaskDaysLittle_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            Init ini = new Init();
            try
            {
                if (int.Parse(maskDaysLittle.Text) < 2)
                { maskDaysLittle.Text = ini.DaysLittle.ToString().Trim(); }
            }
            catch (FormatException ex)
            {
                maskDaysLittle.Text = ini.DaysLittle.ToString().Trim();
                Logger.WriteLog(ex.Message + "\nИсточник: " + ex.Source);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message + "\nИсточник: " + ex.Source);
            }
        }
        private void MaskDaysTooLittle_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            Init ini = new Init();
            try
            {
                if (int.Parse(maskDaysTooLittle.Text) < 1)
                { maskDaysTooLittle.Text = ini.DaysTooLittle.ToString().Trim(); }
            }
            catch (FormatException ex)
            {
                maskDaysTooLittle.Text = ini.DaysTooLittle.ToString().Trim();
                Logger.WriteLog(ex.Message + "\nИсточник: " + ex.Source);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message + "\nИсточник: " + ex.Source);
            }

        }
        #endregion Validation

        private void Catalogue_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridCatalogue.SelectedCells.Count != 0)
            {
                int x = (int)dataGridCatalogue.SelectedCells[0].Value;
                ApptCard frmApt = new ApptCard
                {
                    Tag = x
                };
                if (frmApt.ShowDialog() == DialogResult.OK)
                {
                    FillCatalogueDataGrid();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DalADO dal = new DalADO();
            dal.GetPictures(1);
        }
    }
}
