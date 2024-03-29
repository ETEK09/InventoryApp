namespace InventoryApp.Models
{
    //APS.NET is active server pages that was developed by Windows to allow users to create dynamic web apps and services. It allowed users to create robust, scallable, interactive web apps using program languages such as C# and VB.NET.

    //Model is objects that are shapes representing the business and data logic. The model maintains the data in the application
    public class Inventory
    {
        public int ProductID { get; set; }

        public int Tag { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public DateTime DateAssigned { get; set; }

        public string Distributor { get; set; }

        public string Custodian { get; set; }
    }
}
