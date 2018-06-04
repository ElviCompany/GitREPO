using System;
using System.Collections.Generic;
using System.Data.Linq;
/*using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;*/
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ginger
{
    [Table(Name = "Appartments")]
    public partial class Appartment
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(DbType = "NVarChar(25)", CanBeNull = true)]
        public string Rooms { get; set; }

        [Column(DbType = "NVarChar(250)", CanBeNull = true)]
        public string Street { get; set; }

        [Column(DbType = "NVarChar(5)", CanBeNull = true)]
        public string NumberAppt { get; set; }

        [Column(DbType = "NVarChar(15)", CanBeNull = true)]
        public string HouseNumber { get; set; }

        [Column(DbType = "NVarChar(150)", CanBeNull = true)]
        public string District { get; set; }

        [Column(DbType = "NVarChar(150)", CanBeNull = true)]
        public string City { get; set; }
        public string Floor { get; set; }
        public string Storeys { get; set; }

        [Column(CanBeNull = true)]
        public DateTime DateCall { get; set; }

        [Column(CanBeNull = true)]
        public DateTime DateFree { get; set; }

        [Column(CanBeNull = true)]
        public byte Status { get; set;} // TINYINT. 0 - активный, 1 - сдана, 2 - архив

        [Column(CanBeNull = false)]
        public bool Deleted { get; set; }

        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Surname { get; set; }
        public string Phones { get; set; }
        public string Source { get; set; }
        public string RentTime { get; set; }
        public int PriceF { get; set; }
        public int Price { get; set; }
        public bool Auction { get; set; }
        public bool Communal { get; set; }
        public bool Light { get; set; }
        public bool Water { get; set; }
        public bool Pledge { get; set; }
        public bool MarriedTrigger { get; set; }
        public string MarriedComment { get; set; }
        public bool ChildrenTrigger { get; set; }
        public string ChildrenComment { get; set; }
        public bool AloneTrigger { get; set; }
        public string AloneComment { get; set; }
        public bool AnimalsTrigger { get; set; }
        public string AnimalsComment { get; set; }
        public string OwnerType { get; set; }
        public bool Farpost { get; set; }
        public bool AgentAgreement { get; set; }
        public bool SuretyAgreement { get; set; }
        public bool Keys { get; set; }
        public string Nationality { get; set; }
        public bool EmptyTrigger { get; set; }
        public string EmptyComment { get; set; }
        public bool PartFurnitureTrigger { get; set; }
        public string PartFurnitureComment { get; set; }
        public bool AreaTrigger { get; set; }
        public string AreaComment { get; set; }
        public bool BalconyTrigger { get; set; }
        public string BalconyComment { get; set; }
        public bool LoggiaTrigger { get; set; }
        public string LoggiaComment { get; set; }
        public bool NewBuildingTrigger { get; set; }
        public string NewBuildingComment { get; set; }
        public bool ElevatorTrigger { get; set; }
        public string ElevatorComment { get; set; }
        public bool InternetTrigger { get; set; }
        public string InternetComment { get; set; }
        public bool RoomsTrigger { get; set; }
        public string RoomsComment { get; set; }
        public bool LatticesTrigger { get; set; }
        public string LatticesComment { get; set; }
        public bool PictureToSite { get; set; }
        public bool HotOffer { get; set; }
        public bool NullComission { get; set; }

        [Column(CanBeNull = true)]
        public bool Elite { get; set; }
        public int HotPrice { get; set; }
        public int HotComission { get; set; }
        public bool HD { get; set; }
        public string YoutubeLink { get; set; }
        public string CianLink { get; set; }


        /*[Association(Name = "FK_Orders_Customers", ThisKey=" Id", OtherKey = "Id", DeleteRule = "CASCADE")]
        public EntitySet <Comment> Comments { get; set; }*/

        // Прописываем индексатор, иначе без него тяжко копировать
        public object this [int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return this.Id;
                    case 1: return this.Rooms;
                    case 2: return this.Street;
                    case 3: return this.NumberAppt;
                    case 4: return this.District;
                    case 5: return this.DateCall;
                    case 6: return this.DateFree;
                    case 7: return this.Elite;
                    case 8: return this.Status;
                    case 9: return this.Deleted;
                    // В случае неверного индекса выбрасываем исключение.
                    default: throw new ArgumentOutOfRangeException("Неверный индекс");
                }
            }
            set
            {
                switch (i)
                {
                    //case 0: this.Id;
                    case 1: this.Rooms = (string) value; break;
                    case 2: this.Street = (string) value; break;
                    case 3: this.NumberAppt = (string) value; break;
                    case 4: this.District = (string) value; break;
                    case 5: this.DateCall = (DateTime) value; break;
                    case 6: this.DateFree = (DateTime) value; break;
                    case 7: this.Elite = (bool) value; break;
                    case 8: this.Status = (byte) value; break;
                    case 9: this.Deleted = (bool) value; break;
                    // В случае неверного индекса выбрасываем исключение.
                    default: throw new ArgumentOutOfRangeException("Неверный индекс");
                }
            }
        }

        readonly int fieldsCount = 8;
        public int FieldsCount { get { return fieldsCount; } }
    }

    [Table(Name = "Comments")]
    public partial class Comment
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int IdComment { get; set; }

        // Ассоциация от дочернего (Order) сущностного класса
        /*[Association(Name = "FK_ID_Appartments", OtherKey = "Id", IsForeignKey = true)]*/
        [Column(CanBeNull = false)]
        public int Id { get; set; }

        [Column(DbType = "NVarChar(250)", CanBeNull = false)]
        public string Text { get; set; }

        [Column(CanBeNull = false)]
        public DateTime Date { get; set; }
    }

    [Table(Name = "Pictures")]
    public partial class Picture
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int IdPicture { get; set; }

        [Column(CanBeNull = false)]
        public int Id { get; set; }

        [Column(DbType = "NVarChar(256)", CanBeNull = false)]
        public string Link { get; set; }
    }

    [Table(Name = "Master")]
    public partial class Master
    {
        public Master() { }
        public Master (string name, string val)
        { this.Name = name; this.Value = val; }

        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(DbType = "NVarChar(150)", CanBeNull = true)]
        public string Name { get; set; }

        [Column(DbType = "NVarChar(250)", CanBeNull = true)]
        public string Value { get; set; }
    }

}
