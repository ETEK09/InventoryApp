using System.Globalization;

namespace InventoryApp.Models
{

    //ASP.NET stands for Active Server Pages. It is a frame work developed by Microsoft that allow users to create dynamic applications and services. Users can create scallable, robust, and interactive web pages using programming languages such as C# and VB.NET.//
    //The Model class represents the shape of the object. It is used to store data in the application. 
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
