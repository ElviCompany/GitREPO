using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ginger
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// Пришлось вынести в отдельную функцию видимость панели настроек
        /// и ряда других объектов, в зависимости от прав доступа
        /// чтобы не раскидывывать однотипные команды по всей программе
        /// </summary>
        void SetVisibilityPanels()
        {
            Init ini = new Init();

            switch (ProgramMode)
            {
                case PROGRAM_MODE_START:
                    PanelAgents.Visible = false;
                    PanelArchive.Visible = false;
                    PanelCatalogue.Visible = false;
                    PanelClients.Visible = false;
                    PanelMeetings.Visible = false;
                    PanelRented.Visible = false;
                    PanelReports.Visible = false;
                    PanelSettings.Visible = false;

                    PanelStart.Visible = true;
                    break;
                case PROGRAM_MODE_AGENTS:
                    PanelStart.Visible = false;
                    PanelArchive.Visible = false;
                    PanelCatalogue.Visible = false;
                    PanelClients.Visible = false;
                    PanelMeetings.Visible = false;
                    PanelRented.Visible = false;
                    PanelReports.Visible = false;
                    PanelSettings.Visible = false;

                    PanelAgents.Visible = true;
                    break;
                case PROGRAM_MODE_ARCHIVE:
                    PanelStart.Visible = false;
                    PanelAgents.Visible = false;
                    PanelCatalogue.Visible = false;
                    PanelClients.Visible = false;
                    PanelMeetings.Visible = false;
                    PanelRented.Visible = false;
                    PanelReports.Visible = false;
                    PanelSettings.Visible = false;

                    PanelArchive.Visible = true;
                    break;
                case PROGRAM_MODE_CATALOGUE:
                    PanelStart.Visible = false;
                    PanelAgents.Visible = false;
                    PanelArchive.Visible = false;
                    PanelClients.Visible = false;
                    PanelMeetings.Visible = false;
                    PanelRented.Visible = false;
                    PanelReports.Visible = false;
                    PanelSettings.Visible = false;

                    PanelCatalogue.Visible = true;

                    ButtonDelete.Enabled = SuperUserMode ? true : false;
                    break;
                case PROGRAM_MODE_CLIENTS:
                    PanelStart.Visible = false;
                    PanelAgents.Visible = false;
                    PanelArchive.Visible = false;
                    PanelCatalogue.Visible = false;
                    PanelMeetings.Visible = false;
                    PanelRented.Visible = false;
                    PanelReports.Visible = false;
                    PanelSettings.Visible = false;

                    PanelClients.Visible = true;
                    break;
                case PROGRAM_MODE_MEETINGS:
                    PanelStart.Visible = false;
                    PanelAgents.Visible = false;
                    PanelArchive.Visible = false;
                    PanelCatalogue.Visible = false;
                    PanelClients.Visible = false;
                    PanelRented.Visible = false;
                    PanelReports.Visible = false;
                    PanelSettings.Visible = false;

                    PanelMeetings.Visible = true;
                    break;
                case PROGRAM_MODE_RENTED:
                    PanelStart.Visible = false;
                    PanelAgents.Visible = false;
                    PanelArchive.Visible = false;
                    PanelCatalogue.Visible = false;
                    PanelClients.Visible = false;
                    PanelMeetings.Visible = false;
                    PanelReports.Visible = false;
                    PanelSettings.Visible = false;

                    PanelRented.Visible = true;
                    break;
                case PROGRAM_MODE_REPORTS:
                    PanelStart.Visible = false;
                    PanelAgents.Visible = false;
                    PanelArchive.Visible = false;
                    PanelCatalogue.Visible = false;
                    PanelClients.Visible = false;
                    PanelMeetings.Visible = false;
                    PanelRented.Visible = false;
                    PanelSettings.Visible = false;

                    PanelReports.Visible = true;
                    break;
                case PROGRAM_MODE_SETTINGS:
                    PanelStart.Visible = false;
                    PanelAgents.Visible = false;
                    PanelArchive.Visible = false;
                    PanelCatalogue.Visible = false;
                    PanelClients.Visible = false;
                    PanelMeetings.Visible = false;
                    PanelRented.Visible = false;
                    PanelReports.Visible = false;

                    PanelSettings.Visible = true;

                    maskDaysLittle.Text = ini.DaysLittle.ToString().Trim();
                    maskDaysTooLittle.Text = ini.DaysTooLittle.ToString().Trim();
                    boxConnectionString.Text = ini.DbConnectString;
                    boxPicturePath.Text = ini.PicturePath.Trim();
                    ColorForDaysLittle.BackColor = Color.FromName(ini.ColorForDaysLittle.Trim());
                    ColorForDaysTooLittle.BackColor = Color.FromName(ini.ColorForDaysTooLittle.Trim());
                    if (SuperUserMode == true)
                    {
                        boxConnectionString.UseSystemPasswordChar = false;
                        boxPicturePath.UseSystemPasswordChar = false;
                        boxConnectionString.Enabled = true;
                        boxPicturePath.Enabled = true;

                        ButtonCheckConnection.Enabled = true;
                        ButtonSelectPictureFolder.Enabled = true;
                        ButtonAdminAccess.Image = Properties.Resources.Button_ON_64x64;
                    }
                    else
                    {
                        boxConnectionString.UseSystemPasswordChar = true;
                        boxPicturePath.UseSystemPasswordChar = true;
                        boxConnectionString.Enabled = false;
                        boxPicturePath.Enabled = false;

                        ButtonCheckConnection.Enabled = false;
                        ButtonSelectPictureFolder.Enabled = false;
                        ButtonAdminAccess.Image = Properties.Resources.Button_OFF_64x64;
                    }

                    break;
                case PROGRAM_MODE_START_OR_PROBLEM_SETTINGS:
                    PanelStart.Visible = false;
                    PanelAgents.Visible = false;
                    PanelArchive.Visible = false;
                    PanelCatalogue.Visible = false;
                    PanelClients.Visible = false;
                    PanelMeetings.Visible = false;
                    PanelRented.Visible = false;
                    PanelReports.Visible = false;

                    ButtonCatalogue.Enabled = false;
                    ButtonRented.Enabled = false;
                    ButtonArchive.Enabled = false;
                    ButtonMeetings.Enabled = false;
                    ButtonClients.Enabled = false;
                    ButtonAgents.Enabled = false;
                    ButtonReports.Enabled = false;

                    PanelSettings.Visible = true;

                    maskDaysLittle.Text = ini.DaysLittle.ToString().Trim();
                    maskDaysTooLittle.Text = ini.DaysTooLittle.ToString().Trim();
                    boxConnectionString.Text = ini.DbConnectString;
                    boxPicturePath.Text = ini.PicturePath.Trim();
                    ColorForDaysLittle.BackColor = Color.FromName(ini.ColorForDaysLittle.Trim());
                    ColorForDaysTooLittle.BackColor = Color.FromName(ini.ColorForDaysTooLittle.Trim());
                    if (SuperUserMode == true)
                    {
                        boxConnectionString.UseSystemPasswordChar = false;
                        boxPicturePath.UseSystemPasswordChar = false;
                        boxConnectionString.Enabled = true;
                        boxPicturePath.Enabled = true;

                        ButtonCheckConnection.Enabled = true;
                        ButtonSelectPictureFolder.Enabled = true;
                        ButtonCreateDB.Enabled = true;
                        ButtonAdminAccess.Image = Properties.Resources.Button_ON_64x64;
                        toolStripStatusLabel1.Text = "Особый режим. Строка состояния: ВНИМАНИЕ - Режим администратора";
                    }
                    else
                    {
                        boxConnectionString.UseSystemPasswordChar = true;
                        boxPicturePath.UseSystemPasswordChar = true;
                        boxConnectionString.Enabled = false;
                        boxPicturePath.Enabled = false;

                        ButtonCheckConnection.Enabled = false;
                        ButtonSelectPictureFolder.Enabled = false;
                        ButtonCreateDB.Enabled = false;
                        ButtonAdminAccess.Image = Properties.Resources.Button_OFF_64x64;
                        toolStripStatusLabel1.Text = "Особый режим. Строка состояния:";
                    }
                    break;
            }

            if (ProgramMode != PROGRAM_MODE_START_OR_PROBLEM_SETTINGS)
            {
                ButtonCatalogue.Enabled = true;
                ButtonRented.Enabled = true;
                ButtonArchive.Enabled = true;
                ButtonSettings.Enabled = true;
                if (SuperUserMode == true)
                { toolStripStatusLabel1.Text = "Строка состояния: ВНИМАНИЕ - Режим администратора"; }
                else
                { toolStripStatusLabel1.Text = "Строка состояния:"; }
            }

        }

    }
}
