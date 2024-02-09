namespace InventoryApp.Models
{
    //ASP.Net stands for Active Server Pages.NET. It was developed by Microsoft for creating dynamic web apps and services. It allows users to create robust, scallable, and interactive applications using programming languages such as C# and VB.NET//
    //The Model represents the shape of the data and the business logic. It stores and maintains the data in the application//
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
