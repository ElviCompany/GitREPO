using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ginger
{
    public partial class Form1 : Form
    {
        private void FillCatalogueDataGrid()
        {
            dataGridCatalogue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCatalogue.AllowUserToAddRows = false;

            DalADO dal = new DalADO();
            DataSet ds = dal.GetApptDS(Status: 0);

            CatalogBindingSrc.DataSource = ds;
            dataGridCatalogue.DataSource = CatalogBindingSrc;
            dataGridCatalogue.DataMember = "Appartments";
            dataGridCatalogue.Columns["Id"].HeaderText = "№ п/п";
            // делаем недоступным столбец id для изменения
            dataGridCatalogue.Columns["Id"].ReadOnly = true;
            dataGridCatalogue.Columns["Rooms"].HeaderText = "Число комн.";
            dataGridCatalogue.Columns["Street"].HeaderText = "Улица";
            dataGridCatalogue.Columns["HouseNumber"].HeaderText = "№ дома";
            dataGridCatalogue.Columns["NumberAppt"].HeaderText = "№ кварт.";
            dataGridCatalogue.Columns["District"].HeaderText = "Район";
            dataGridCatalogue.Columns["Price"].HeaderText = "Цена";
            dataGridCatalogue.Columns["RentTime"].HeaderText = "Срок сдачи";
            dataGridCatalogue.Columns["DateFree"].HeaderText = "Дата освоб.";
            dataGridCatalogue.Columns["DateFree"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dataGridCatalogue.Columns["DateCall"].HeaderText = "Дата прозвона";
            dataGridCatalogue.Columns["DateCall"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dataGridCatalogue.Columns["ShortNotes"].HeaderText = "Примечание";

            if (dataGridCatalogue.DataSource == null)
            { ButtonAdd.Enabled = false; }
            else { ButtonAdd.Enabled = true; }

            if (dataGridCatalogue.Rows.Count != 0)
            {
                ButtonEdit.Enabled = true;
                //ButtonDelete.Enabled = true; // Пока отключено
            }
            else
            {
                ButtonEdit.Enabled = false;
                ButtonDelete.Enabled = false;
            }
        }

        private void FillRentedDataGrid()
        {
            DataGridRented.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridRented.AllowUserToAddRows = false;

            DalADO dal = new DalADO();
            DataSet ds = dal.GetApptDS(Status: 1);

            RentedBindingSource.DataSource = ds;
            DataGridRented.DataSource = RentedBindingSource;
            DataGridRented.DataMember = "Appartments";
            DataGridRented.Columns["Id"].HeaderText = "№ п/п";
            // делаем недоступным столбец id для изменения
            DataGridRented.Columns["Id"].ReadOnly = true;
            DataGridRented.Columns["Rooms"].HeaderText = "Число комн.";
            DataGridRented.Columns["Street"].HeaderText = "Улица";
            DataGridRented.Columns["HouseNumber"].HeaderText = "№ дома";
            DataGridRented.Columns["NumberAppt"].HeaderText = "№ кварт.";
            DataGridRented.Columns["District"].HeaderText = "Район";
            DataGridRented.Columns["Price"].HeaderText = "Цена";
            DataGridRented.Columns["RentTime"].HeaderText = "Срок сдачи";
            DataGridRented.Columns["DateFree"].HeaderText = "Дата освоб.";
            DataGridRented.Columns["DateFree"].DefaultCellStyle.Format = "dd.MM.yyyy";
            DataGridRented.Columns["DateCall"].HeaderText = "Дата прозвона";
            DataGridRented.Columns["DateCall"].DefaultCellStyle.Format = "dd.MM.yyyy";
            DataGridRented.Columns["ShortNotes"].HeaderText = "Примечание";

            if (DataGridRented.DataSource == null)
            {
                ButtonToCatalogueFromRented.Enabled = false;
                ButtonToArcFromRented.Enabled = false;
            }

            if (DataGridRented.Rows.Count != 0)
            {
                ButtonToCatalogueFromRented.Enabled = true;
                ButtonToArcFromRented.Enabled = true;
            }
            else
            {
                ButtonToCatalogueFromRented.Enabled = false;
                ButtonToArcFromRented.Enabled = false;
            }
        }

        private void FillArchiveDataGrid()
        {
            DataGridArchive.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridArchive.AllowUserToAddRows = false;

            DalADO dal = new DalADO();
            DataSet ds = dal.GetApptDS(Status: 2);

            ArcBindingSrc.DataSource = ds;
            DataGridArchive.DataSource = ArcBindingSrc;
            DataGridArchive.DataMember = "Appartments";
            DataGridArchive.Columns["Id"].HeaderText = "№ п/п";
            // делаем недоступным столбец id для изменения
            DataGridArchive.Columns["Id"].ReadOnly = true;
            DataGridArchive.Columns["Rooms"].HeaderText = "Число комн.";
            DataGridArchive.Columns["Street"].HeaderText = "Улица";
            DataGridArchive.Columns["HouseNumber"].HeaderText = "№ дома";
            DataGridArchive.Columns["NumberAppt"].HeaderText = "№ кварт.";
            DataGridArchive.Columns["District"].HeaderText = "Район";
            DataGridArchive.Columns["Price"].HeaderText = "Цена";
            DataGridArchive.Columns["RentTime"].HeaderText = "Срок сдачи";
            DataGridArchive.Columns["DateFree"].HeaderText = "Дата освоб.";
            DataGridArchive.Columns["DateFree"].DefaultCellStyle.Format = "dd.MM.yyyy";
            DataGridArchive.Columns["DateCall"].HeaderText = "Дата прозвона";
            DataGridArchive.Columns["DateCall"].DefaultCellStyle.Format = "dd.MM.yyyy";
            DataGridRented.Columns["ShortNotes"].HeaderText = "Примечание";
        }
    }
}
