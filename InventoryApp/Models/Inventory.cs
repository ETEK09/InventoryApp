using System.Runtime.CompilerServices;

namespace InventoryApp.Models
{

    //Active Server Pages was developed by Microsoft for developing dynamic web apps and services. It allows users to create robust, scallable, and intereactive web apps using programming lanugages such as C# and VB.Net/

    //The model are objects that represent the shape of the business or data logic. In maintains the data of the application. 
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
