using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ginger
{
    [System.Data.Linq.Mapping.Table(Name = "Appartments")]
    public partial class Appartment
    {
        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [System.Data.Linq.Mapping.Column(DbType = "NVarChar(25)", CanBeNull = true)]
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

        [Column(DbType = "NVarChar(5)", CanBeNull = true)]
        public string Floor { get; set; }

        [Column(DbType = "NVarChar(5)", CanBeNull = true)]
        public string Storeys { get; set; }

        [Column(CanBeNull = true)]
        public DateTime DateCall { get; set; }

        [Column(CanBeNull = true)]
        public DateTime DateFree { get; set; }

        [Column(CanBeNull = true)]
        public byte Status { get; set;} // TINYINT. 0 - активный, 1 - сдана, 2 - архив

        [Column(CanBeNull = false)]
        public bool Deleted { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string Firstname { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string Secondname { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string Surname { get; set; }

        [Column(DbType = "NVarChar(500)", CanBeNull = true)]
        public string Phones { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string Source { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string RentTime { get; set; }

        [Column(CanBeNull = true)]
        public int PriceF { get; set; }

        [Column(CanBeNull = true)]
        public int Price { get; set; }

        [Column(CanBeNull = true)]
        public bool Auction { get; set; }

        [Column(CanBeNull = true)]
        public bool Communal { get; set; }

        [Column(CanBeNull = true)]
        public bool Light { get; set; }

        [Column(CanBeNull = true)]
        public bool Water { get; set; }

        [Column(CanBeNull = true)]
        public bool Pledge { get; set; }

        [Column(CanBeNull = true)]
        public bool MarriedTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string MarriedComment { get; set; }

        [Column(CanBeNull = true)]
        public bool ChildrenTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string ChildrenComment { get; set; }

        [Column(CanBeNull = true)]
        public bool AloneTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string AloneComment { get; set; }

        [Column(CanBeNull = true)]
        public bool AnimalsTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string AnimalsComment { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string OwnerType { get; set; }

        [Column(CanBeNull = true)]
        public bool Farpost { get; set; }

        [Column(CanBeNull = true)]
        public bool AgentAgreement { get; set; }

        [Column(CanBeNull = true)]
        public bool SuretyAgreement { get; set; }

        [Column(CanBeNull = true)]
        public bool Keys { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string Nationality { get; set; }

        [Column(CanBeNull = true)]
        public bool EmptyTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string EmptyComment { get; set; }

        [Column(CanBeNull = true)]
        public bool PartFurnitureTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string PartFurnitureComment { get; set; }

        [Column(CanBeNull = true)]
        public bool AreaTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string AreaComment { get; set; }

        [Column(CanBeNull = true)]
        public bool BalconyTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string BalconyComment { get; set; }

        [Column(CanBeNull = true)]
        public bool LoggiaTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string LoggiaComment { get; set; }

        [Column(CanBeNull = true)]
        public bool NewBuildingTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string NewBuildingComment { get; set; }

        [Column(CanBeNull = true)]
        public bool ElevatorTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string ElevatorComment { get; set; }

        [Column(CanBeNull = true)]
        public bool InternetTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string InternetComment { get; set; }

        [Column(CanBeNull = true)]
        public bool RoomsTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string RoomsComment { get; set; }

        [Column(CanBeNull = true)]
        public bool LatticesTrigger { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string LatticesComment { get; set; }

        [Column(CanBeNull = true)]
        public bool PictureToSite { get; set; }

        [Column(CanBeNull = true)]
        public bool HotOffer { get; set; }

        [Column(CanBeNull = true)]
        public bool NullComission { get; set; }

        [Column(CanBeNull = true)]
        public bool Elite { get; set; }

        [Column(CanBeNull = true)]
        public int HotPrice { get; set; }

        [Column(CanBeNull = true)]
        public int HotComission { get; set; }

        [Column(CanBeNull = true)]
        public bool HD { get; set; }

        [Column(DbType = "NVarChar(500)", CanBeNull = true)]
        public string YoutubeLink { get; set; }

        [Column(DbType = "NVarChar(500)", CanBeNull = true)]
        public string CianLink { get; set; }

        [Column(CanBeNull = true)]
        public bool ApptIsFree { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string ShortNotes { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string PledgeText { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string CommunalText { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string AuctionText { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string LightText { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string WaterText { get; set; }

        /*[Association(Name = "FK_Orders_Customers", ThisKey=" Id", OtherKey = "Id", DeleteRule = "CASCADE")]
        public EntitySet <Comment> Comments { get; set; }*/


        readonly int fieldsCount = 75;
        public int FieldsCount { get { return fieldsCount; } }

    }

    [System.Data.Linq.Mapping.Table(Name = "Comments")]
    public partial class Comment
    {
        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int IdComment { get; set; }

        // Ассоциация от дочернего (Order) сущностного класса
        /*[Association(Name = "FK_ID_Appartments", OtherKey = "Id", IsForeignKey = true)]*/
        [Column(CanBeNull = false)]
        public int Id { get; set; }

        [Column(DbType = "NVarChar(500)", CanBeNull = false)]
        public string Text { get; set; }

        [Column(CanBeNull = false)]
        public DateTime Date { get; set; }
    }

    [System.Data.Linq.Mapping.Table(Name = "Pictures")]
    public partial class Picture
    {
        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int IdPicture { get; set; }

        [System.Data.Linq.Mapping.Column(CanBeNull = true)]
        public int? Id { get; set; }

        [Column(DbType = "NVarChar(256)", CanBeNull = false)]
        public string Link { get; set; }

        [Column(DbType = "NVarChar(256)", CanBeNull = true)]
        public string LinkPreview { get; set; }

        [Column(DbType = "NVarChar(50)", CanBeNull = true)]
        public string ShortNotes { get; set; }

        [Column(CanBeNull = true)]
        public bool MainPicture { get; set; }

    }

    [Table(Name = "GingerSettings")]
    public partial class GingerSettings
    {
        public GingerSettings() { }
        public GingerSettings (string name, string val)
        { this.Name = name; this.Value = val; }

        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(DbType = "NVarChar(150)", CanBeNull = true)]
        public string Name { get; set; }

        [Column(DbType = "NVarChar(250)", CanBeNull = true)]
        public string Value { get; set; }
    }

}
