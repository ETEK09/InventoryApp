namespace InventoryApp.Models
{
    public class Inventory
    {

        //ASP.NET means Active Server pages.NET. It is a framework developed by Microsoft for building wep applications and services. It allows developers to build and deploy robust, scalable, and interactive web apps

        public int ProductID { get; set; }
        public int InventoryTag { get; set; }
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string Description { get; set; }

        public DateTime DateAssigned { get; set; }

        public string Distributor { get; set; }

        public string Custodian { get; set; }

        //The model represents the shape and data of the business logic. It maintains the data of the app.

        //To add nuget packages, you will click on the project file. Click manage nuget packages, and search MYSQL.Data and ORM Dapper. Dapper, the Obeject relational mapping tool, is what connects the librabry MYSQL.Data.

    }
}
