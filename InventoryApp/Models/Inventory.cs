namespace InventoryApp.Models
{ //ASP.NET stands for Active Server Pages.Net. Asp.Net is a frame work developed by microsoft that allow users to build dynamic web apps and services. Users will be able to build robust, scallable, and interactive web apps with codes such as C# and VB.NET

   ///The Model are objects that represent the shape of the data and business logic. It is where the data is stored.
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
