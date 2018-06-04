using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ginger
{
    public partial class ApptCard : Form
    {
        #region Form1GlobalVariables
        string PhoneList = "+7(914)";
        #endregion Form1GlobalVariables
        public ApptCard()
        {
            InitializeComponent();
        }
        private void ApptCard_Shown(object sender, EventArgs e)
        {
            if (Tag != null)
            {
                DalADO dal = new DalADO();
                Appartment appt = new Appartment();

                appt = dal.GetRecord((int)Tag);

                comboType.Text = appt.Rooms.Trim();
                boxStreet.Text = appt.Street.Trim();
                boxNumberAppt.Text = appt.NumberAppt.Trim();
                boxHouseNumber.Text = appt.HouseNumber.Trim();
                comboDistrict.Text = appt.District.Trim();
                boxCity.Text = appt.City.Trim();
                boxFloor.Text = appt.Floor.Trim();
                boxStoreys.Text = appt.Storeys.Trim();
                dateTimeCall.Value = appt.DateCall;
                dateTimeFree.Value = appt.DateFree;
                boxFirstName.Text = appt.Firstname.Trim();
                boxSecondName.Text = appt.Secondname.Trim();
                boxSurname.Text = appt.Surname.Trim();
                PhoneList = appt.Phones.Trim();
                comboSource.Text = appt.Source.Trim();
                comboRentTime.Text = appt.RentTime.Trim();
                maskFPrice.Text = appt.PriceF.ToString().Trim();
                maskPrice.Text = appt.Price.ToString().Trim();
                checkAuction.Checked = appt.Auction;
                checkCommunal.Checked = appt.Communal;
                checkLight.Checked = appt.Light;
                checkWater.Checked = appt.Water;
                checkPledge.Checked = appt.Pledge;
                checkMarried.Checked = appt.MarriedTrigger;
                boxMarried.Text = appt.MarriedComment.Trim();
                checkChildren.Checked = appt.ChildrenTrigger;
                boxChildren.Text = appt.ChildrenComment.Trim();
                checkAlone.Checked = appt.AloneTrigger;
                boxAlone.Text = appt.AloneComment.Trim();
                checkAnimals.Checked = appt.AnimalsTrigger;
                boxAnimals.Text = appt.AnimalsComment.Trim();
                boxOwnerType.Text = appt.OwnerType;
                checkFarpost.Checked = appt.Farpost;
                checkAgentAgreement.Checked = appt.AgentAgreement;
                checkSuretyAgreement.Checked = appt.SuretyAgreement;
                checkKeys.Checked = appt.Keys;
                boxNationality.Text = appt.Nationality.Trim();
                checkEmpty.Checked = appt.EmptyTrigger;
                boxEmpty.Text = appt.EmptyComment.Trim();
                checkPartFurniture.Checked = appt.PartFurnitureTrigger;
                boxPartFurniture.Text = appt.PartFurnitureComment.Trim();
                checkArea.Checked = appt.AreaTrigger;
                boxArea.Text = appt.AreaComment.Trim();
                checkBalcony.Checked = appt.BalconyTrigger;
                boxBalcony.Text = appt.BalconyComment.Trim();
                checkLoggia.Checked = appt.LoggiaTrigger;
                boxLoggia.Text = appt.LoggiaComment.Trim();
                checkNewBuilding.Checked = appt.NewBuildingTrigger;
                boxNewBuilding.Text = appt.NewBuildingComment.Trim();
                checkElevator.Checked = appt.ElevatorTrigger;
                boxElevator.Text = appt.ElevatorComment.Trim();
                checkInternet.Checked = appt.InternetTrigger;
                boxInternet.Text = appt.InternetComment.Trim();
                checkRooms.Checked = appt.RoomsTrigger;
                boxRooms.Text = appt.RoomsComment.Trim();
                checkLattices.Checked = appt.LatticesTrigger;
                boxLattices.Text = appt.LatticesComment.Trim();
                checkPictureToSite.Checked = appt.PictureToSite;
                checkHotOffer.Checked = appt.HotOffer;
                checkNullComission.Checked = appt.NullComission;
                checkElite.Checked = appt.Elite;
                maskHotPrice.Text = appt.HotPrice.ToString().Trim();
                maskHotComission.Text = appt.HotComission.ToString().Trim();
                checkHD.Checked = appt.HD;
                boxYoutubeLink.Text = appt.YoutubeLink.Trim();
                boxCianLink.Text = appt.CianLink.Trim();
                if (appt.ApptIsFree) { radioFree.Checked = true; }
                else { radioWillBeFree.Checked = true; }
                boxShortNotes.Text = appt.ShortNotes;
                boxPledge.Text = appt.PledgeText;
                boxCommunal.Text = appt.CommunalText;
                boxAuction.Text = appt.AuctionText;
                boxLight.Text = appt.LightText;
                boxWater.Text = appt.WaterText;
            }
        }
        void Func(string param)
        {
            PhoneList = param;
        }

        #region MaskValidation
        private void MaskFPrice_Validated(object sender, EventArgs e)
        {
            try
            { int.Parse(maskFPrice.Text); }
            catch (FormatException ex)
            {
                maskFPrice.Text = "0";
                Logger.WriteLog(ex.Message + "\nИсточник: " + ex.Source +
                    "\nПеременная: " + maskFPrice.Text);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message + "\nИсточник: " + ex.Source +
                    "\nПеременная: " + maskFPrice.Text);
            }

        }

        private void MaskPrice_Validated(object sender, EventArgs e)
        {
            try
            { int.Parse(maskPrice.Text); }
            catch (FormatException ex)
            {
                maskPrice.Text = "0";
                Logger.WriteLog(ex.Message + "\nИсточник: " + ex.Source +
                    "\nПеременная: " + maskPrice.Text);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message + "\nИсточник: " + ex.Source +
                    "\nПеременная: " + maskPrice.Text);
            }
        }

        private void MaskHotPrice_Validated(object sender, EventArgs e)
        {
            try
            { int.Parse(maskHotPrice.Text); }
            catch (FormatException ex)
            {
                maskHotPrice.Text = "0";
                Logger.WriteLog(ex.Message + "\nИсточник: " + ex.Source +
                    "\nПеременная: " + maskHotPrice.Text);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message + "\nИсточник: " + ex.Source +
                    "\nПеременная: " + maskHotPrice.Text);
            }
        }

        private void MaskHotComission_Validated(object sender, EventArgs e)
        {
            try
            { int.Parse(maskHotComission.Text); }
            catch (FormatException ex)
            {
                maskHotComission.Text = "0";
                Logger.WriteLog(ex.Message + "\nИсточник: " + ex.Source +
                    "\nПеременная: " + maskHotComission.Text);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message + "\nИсточник: " + ex.Source +
                    "\nПеременная: " + maskHotComission.Text);
            }
        }

        #endregion MaskValidation

        #region ButtonsClick
        private void Button1_Click(object sender, EventArgs e)
        {
            //
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DalADO dal = new DalADO();
            dal.PictureFixation(null);
        }
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            int priceFSafe, priceSafe, HotPriceSafe, HotComissionSafe;

            if ((maskHotComission.Text.Trim() == String.Empty) || maskHotComission.Text.Trim().Contains(" "))
            { HotComissionSafe = 0; }
            else { HotComissionSafe = int.Parse(maskHotComission.Text.Trim()); }

            if ((maskHotPrice.Text.Trim() == String.Empty) || maskHotPrice.Text.Trim().Contains(" "))
            { HotPriceSafe = 0; }
            else { HotPriceSafe = int.Parse(maskHotPrice.Text.Trim()); }

            if ((maskFPrice.Text.Trim() == String.Empty) || maskFPrice.Text.Trim().Contains(" "))
            { priceFSafe = 0; }
            else { priceFSafe = int.Parse(maskFPrice.Text.Trim()); }

            if ((maskPrice.Text.Trim() == String.Empty) || maskPrice.Text.Trim().Contains(" "))
            { priceSafe = 0; }
            else { priceSafe = int.Parse(maskPrice.Text.Trim()); }

            Appartment appt = new Appartment
            {
                Rooms = comboType.Text.Trim(),
                Street = boxStreet.Text.Trim(),
                NumberAppt = boxNumberAppt.Text.Trim(),
                HouseNumber = boxHouseNumber.Text.Trim(),
                District = comboDistrict.Text.Trim(),
                City = boxCity.Text.Trim(),
                Floor = boxFloor.Text.Trim(),
                Storeys = boxStoreys.Text.Trim(),
                DateCall = dateTimeCall.Value,
                DateFree = dateTimeFree.Value,
                // Status = 0, // По умолчанию только что добавленная квартира не может сразу попасть в архив
                // Deleted = false, // По умолчанию только что добавленная квартира не может быть удалена
                Firstname = boxFirstName.Text.Trim(),
                Secondname = boxSecondName.Text.Trim(),
                Surname = boxSurname.Text.Trim(),
                Phones = PhoneList,  // ------------------------- !
                Source = comboSource.Text.Trim(),
                RentTime = comboRentTime.Text.Trim(),
                PriceF = priceFSafe,
                Price = priceSafe,
                Auction = checkAuction.Checked ? true : false,
                Communal = checkCommunal.Checked ? true : false,
                Light = checkLight.Checked ? true : false,
                Water = checkWater.Checked ? true : false,
                Pledge = checkPledge.Checked ? true : false,
                MarriedTrigger = checkMarried.Checked ? true : false,
                MarriedComment = boxMarried.Text.Trim(),
                ChildrenTrigger = checkChildren.Checked ? true : false,
                ChildrenComment = boxChildren.Text.Trim(),
                AloneTrigger = checkAlone.Checked ? true : false,
                AloneComment = boxAlone.Text.Trim(),
                AnimalsTrigger = checkAnimals.Checked ? true : false,
                AnimalsComment = boxAnimals.Text.Trim(),
                OwnerType = boxOwnerType.Text.Trim(),
                Farpost = checkFarpost.Checked ? true : false,
                AgentAgreement = checkAgentAgreement.Checked ? true : false,
                SuretyAgreement = checkSuretyAgreement.Checked ? true : false,
                Keys = checkKeys.Checked ? true : false,
                Nationality = boxNationality.Text.Trim(),
                EmptyTrigger = checkEmpty.Checked ? true : false,
                EmptyComment = boxEmpty.Text.Trim(),
                PartFurnitureTrigger = checkPartFurniture.Checked ? true : false,
                PartFurnitureComment = boxPartFurniture.Text.Trim(),
                AreaTrigger = checkArea.Checked ? true : false,
                AreaComment = boxArea.Text.Trim(),
                BalconyTrigger = checkBalcony.Checked ? true : false,
                BalconyComment = boxBalcony.Text.Trim(),
                LoggiaTrigger = checkLoggia.Checked ? true : false,
                LoggiaComment = boxLoggia.Text.Trim(),
                NewBuildingTrigger = checkNewBuilding.Checked ? true : false,
                NewBuildingComment = boxNewBuilding.Text.Trim(),
                ElevatorTrigger = checkElevator.Checked ? true : false,
                ElevatorComment = boxElevator.Text.Trim(),
                InternetTrigger = checkInternet.Checked ? true : false,
                InternetComment = boxInternet.Text.Trim(),
                RoomsTrigger = checkRooms.Checked ? true : false,
                RoomsComment = boxRooms.Text.Trim(),
                LatticesTrigger = checkLattices.Checked ? true : false,
                LatticesComment = boxLattices.Text.Trim(),
                PictureToSite = checkPictureToSite.Checked ? true : false,
                HotOffer = checkHotOffer.Checked ? true : false,
                NullComission = checkNullComission.Checked ? true : false,
                Elite = checkElite.Checked ? true : false,
                HotPrice = HotPriceSafe,
                HotComission = HotComissionSafe,
                HD = checkHD.Checked,
                YoutubeLink = boxYoutubeLink.Text.Trim(),
                CianLink = boxCianLink.Text.Trim(),
                ApptIsFree = (radioFree.Checked == true) ? true : false,
                ShortNotes = boxShortNotes.Text.Trim(),
                PledgeText = boxPledge.Text.Trim(),
                CommunalText = boxCommunal.Text.Trim(),
                AuctionText = boxAuction.Text.Trim(),
                LightText = boxLight.Text.Trim(),
                WaterText = boxWater.Text.Trim ()
            };
            
            DalADO dal = new DalADO();
            if (Tag != null)
            {
                dal.UpdateRecord((int)Tag, appt);
            }
            else
            {
                int x = dal.AddRecord(appt);
                //MessageBox.Show(x.ToString());
                dal.PictureFixation(x);
            }
        }
        private void ButtonPhone_Click(object sender, EventArgs e)
        {
            ApptCardPhone frm = new ApptCardPhone(new PhonesDelegate(Func), PhoneList);
            frm.ShowDialog();
        }
        
        #endregion ButtonsClick

        #region RadioButtonsChanged
        private void RadioFree_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if ((radioButton.Name == "radioFree") && (radioButton.Checked))
                { dateTimeFree.Enabled = false; }
            else if ((radioButton.Name == "radioWillBeFree") && (radioButton.Checked))
                { dateTimeFree.Enabled = true; }
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            boxAuction.Enabled = checkAuction.Checked;
            boxCommunal.Enabled = checkCommunal.Checked;
            boxLight.Enabled = checkLight.Checked;
            boxWater.Enabled = checkWater.Checked;
            boxPledge.Enabled = checkPledge.Checked;

            boxMarried.Enabled = checkMarried.Checked;
            boxChildren.Enabled = checkChildren.Checked;
            boxAlone.Enabled = checkAlone.Checked;
            boxAnimals.Enabled = checkAnimals.Checked;

            boxEmpty.Enabled = checkEmpty.Checked;
            boxPartFurniture.Enabled = checkPartFurniture.Checked;
            boxArea.Enabled = checkArea.Checked;
            boxBalcony.Enabled = checkBalcony.Checked;
            boxLoggia.Enabled = checkLoggia.Checked;
            boxNewBuilding.Enabled = checkNewBuilding.Checked;
            boxElevator.Enabled = checkElevator.Checked;
            boxInternet.Enabled = checkInternet.Checked;
            boxRooms.Enabled = checkRooms.Checked;
            boxLattices.Enabled = checkLattices.Checked;
        }


        #endregion RadioButtonsChanged

        private void PictureThumb_Click(object sender, EventArgs e)
        {
            string ApptComment = String.Format("{0}\r\nдом: {1}\r\nкв: {2}\r\n{3}", boxStreet.Text.Trim(), boxHouseNumber.Text.Trim(), boxNumberAppt.Text.Trim(), boxShortNotes.Text.Trim());

            Pictures PictureForm = new Pictures (ApptComment)
            {
                Tag = this.Tag
            };
            PictureForm.ShowDialog();
        }


    }
}
