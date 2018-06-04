using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ginger
{
    public partial class Appartment
    {
        // Прописываем индексатор, иначе без него тяжко копировать
        public object this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return this.Id;
                    case 1: return this.Rooms;
                    case 2: return this.Street;
                    case 3: return this.NumberAppt;
                    case 4: return this.HouseNumber;
                    case 5: return this.District;
                    case 6: return this.City;
                    case 7: return this.Floor;
                    case 8: return this.Storeys;
                    case 9: return this.DateCall;
                    case 10: return this.DateFree;
                    case 11: return this.Status;
                    case 12: return this.Deleted;
                    case 13: return this.Firstname;
                    case 14: return this.Secondname;
                    case 15: return this.Surname;
                    case 16: return this.Phones;
                    case 17: return this.Source;
                    case 18: return this.RentTime;
                    case 19: return this.PriceF;
                    case 20: return this.Price;
                    case 21: return this.Auction;
                    case 22: return this.Communal;
                    case 23: return this.Light;
                    case 24: return this.Water;
                    case 25: return this.Pledge;
                    case 26: return this.MarriedTrigger;
                    case 27: return this.MarriedComment;
                    case 28: return this.ChildrenTrigger;
                    case 29: return this.ChildrenComment;
                    case 30: return this.AloneTrigger;
                    case 31: return this.AloneComment;
                    case 32: return this.AnimalsTrigger;
                    case 33: return this.AnimalsComment;
                    case 34: return this.OwnerType;
                    case 35: return this.Farpost;
                    case 36: return this.AgentAgreement;
                    case 37: return this.SuretyAgreement;
                    case 38: return this.Keys;
                    case 39: return this.Nationality;
                    case 40: return this.EmptyTrigger;
                    case 41: return this.EmptyComment;
                    case 42: return this.PartFurnitureTrigger;
                    case 43: return this.PartFurnitureComment;
                    case 44: return this.AreaTrigger;
                    case 45: return this.AreaComment;
                    case 46: return this.BalconyTrigger;
                    case 47: return this.BalconyComment;
                    case 48: return this.LoggiaTrigger;
                    case 49: return this.LoggiaComment;
                    case 50: return this.NewBuildingTrigger;
                    case 51: return this.NewBuildingComment;
                    case 52: return this.ElevatorTrigger;
                    case 53: return this.ElevatorComment;
                    case 54: return this.InternetTrigger;
                    case 55: return this.InternetComment;
                    case 56: return this.RoomsTrigger;
                    case 57: return this.RoomsComment;
                    case 58: return this.LatticesTrigger;
                    case 59: return this.LatticesComment;
                    case 60: return this.PictureToSite;
                    case 61: return this.HotOffer;
                    case 62: return this.NullComission;
                    case 63: return this.Elite;
                    case 64: return this.HotPrice;
                    case 65: return this.HotComission;
                    case 66: return this.HD;
                    case 67: return this.YoutubeLink;
                    case 68: return this.CianLink;
                    case 69: return this.ApptIsFree;
                    case 70: return this.ShortNotes;
                    case 71: return this.PledgeText;
                    case 72: return this.CommunalText;
                    case 73: return this.AuctionText;
                    case 74: return this.LightText;
                    case 75: return this.WaterText;
                    // В случае неверного индекса выбрасываем исключение.
                    default: throw new ArgumentOutOfRangeException("Неверный индекс");
                }
            }
            set
            {
                switch (i)
                {
                    //case 0: this.Id;
                    case 1: this.Rooms = (string)value; break;
                    case 2: this.Street = (string)value; break;
                    case 3: this.NumberAppt = (string)value; break;
                    case 4: this.HouseNumber = (string)value; break;
                    case 5: this.District = (string)value; break;
                    case 6: this.City = (string)value; break;
                    case 7: this.Floor = (string)value; break;
                    case 8: this.Storeys = (string)value; break;
                    case 9: this.DateCall = (DateTime)value; break;
                    case 10: this.DateFree = (DateTime)value; break;
                    case 11: this.Status = (byte)value; break;
                    case 12: this.Deleted = (bool)value; break;
                    case 13: this.Firstname = (string)value; break;
                    case 14: this.Secondname = (string)value; break;
                    case 15: this.Surname = (string)value; break;
                    case 16: this.Phones = (string)value; break;
                    case 17: this.Source = (string)value; break;
                    case 18: this.RentTime = (string)value; break;
                    case 19: this.PriceF = (int)value; break;
                    case 20: this.Price = (int)value; break;
                    case 21: this.Auction = (bool)value; break;
                    case 22: this.Communal = (bool)value; break;
                    case 23: this.Light = (bool)value; break;
                    case 24: this.Water = (bool)value; break;
                    case 25: this.Pledge = (bool)value; break;
                    case 26: this.MarriedTrigger = (bool)value; break;
                    case 27: this.MarriedComment = (string)value; break;
                    case 28: this.ChildrenTrigger = (bool)value; break;
                    case 29: this.ChildrenComment = (string)value; break;
                    case 30: this.AloneTrigger = (bool)value; break;
                    case 31: this.AloneComment = (string)value; break;
                    case 32: this.AnimalsTrigger = (bool)value; break;
                    case 33: this.AnimalsComment = (string)value; break;
                    case 34: this.OwnerType = (string)value; break;
                    case 35: this.Farpost = (bool)value; break;
                    case 36: this.AgentAgreement = (bool)value; break;
                    case 37: this.SuretyAgreement = (bool)value; break;
                    case 38: this.Keys = (bool)value; break;
                    case 39: this.Nationality = (string)value; break;
                    case 40: this.EmptyTrigger = (bool)value; break;
                    case 41: this.EmptyComment = (string)value; break;
                    case 42: this.PartFurnitureTrigger = (bool)value; break;
                    case 43: this.PartFurnitureComment = (string)value; break;
                    case 44: this.AreaTrigger = (bool)value; break;
                    case 45: this.AreaComment = (string)value; break;
                    case 46: this.BalconyTrigger = (bool)value; break;
                    case 47: this.BalconyComment = (string)value; break;
                    case 48: this.LoggiaTrigger = (bool)value; break;
                    case 49: this.LoggiaComment = (string)value; break;
                    case 50: this.NewBuildingTrigger = (bool)value; break;
                    case 51: this.NewBuildingComment = (string)value; break;
                    case 52: this.ElevatorTrigger = (bool)value; break;
                    case 53: this.ElevatorComment = (string)value; break;
                    case 54: this.InternetTrigger = (bool)value; break;
                    case 55: this.InternetComment = (string)value; break;
                    case 56: this.RoomsTrigger = (bool)value; break;
                    case 57: this.RoomsComment = (string)value; break;
                    case 58: this.LatticesTrigger = (bool)value; break;
                    case 59: this.LatticesComment = (string)value; break;
                    case 60: this.PictureToSite = (bool)value; break;
                    case 61: this.HotOffer = (bool)value; break;
                    case 62: this.NullComission = (bool)value; break;
                    case 63: this.Elite = (bool)value; break;
                    case 64: this.HotPrice = (int)value; break;
                    case 65: this.HotComission = (int)value; break;
                    case 66: this.HD = (bool)value; break;
                    case 67: this.YoutubeLink = (string)value; break;
                    case 68: this.CianLink = (string)value; break;
                    case 69: this.ApptIsFree = (bool)value; break;
                    case 70: this.ShortNotes = (string)value; break;
                    case 71: this.PledgeText = (string)value; break;
                    case 72: this.CommunalText = (string)value; break;
                    case 73: this.AuctionText = (string)value; break;
                    case 74: this.LightText = (string)value; break;
                    case 75: this.WaterText = (string)value; break;

                    // В случае неверного индекса выбрасываем исключение.
                    default: throw new ArgumentOutOfRangeException("Неверный индекс");
                }
            }
        }

    }
}
