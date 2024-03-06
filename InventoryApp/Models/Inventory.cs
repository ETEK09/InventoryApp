namespace InventoryApp.Models
{
    //Active Server Pages net was developed by Microsoft to build dynamic and web apps. and services. It was created for users to build robust, scallable, and interactive websites using program languages such as C# and VB.NET

    //Model is the objects that represent the business logic and data. It stores the data 

    public class Inventory
    {

        public int ProductID { get; set; }

        public int InventoryTag { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public DateTime DateAssigned { get; set; }

        public string Distributor { get; set; }

        public string Custodian { get; set; }

    }

}
