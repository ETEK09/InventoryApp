using System.Net.Http.Headers;

namespace InventoryApp.Models
{
    public class Inventory
    {

        ///ASP.MET means Activer Server Pages.NET. It is a framework developed by Microsoft for building dynamic web apps and services. It allows users to create scallable, robust, and interactive apps using programming languages such as C# or VB.Net
        ///

        public int ProductID { get; set; }
        public int InventoryTag { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public DateTime DateAssigned { get; set; }

        public string Distributor { get; set; }

        public string Custodian { get; set; }



    }
}
