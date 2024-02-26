namespace InventoryApp.Models
{
    //Active server pages was developed by Microsoft for creating dynamic web apps and services. It was developed to allow users to create robust, scallable, and interactive web applications using VB.NET and C#.

    //The model are objects that represents the shape of the data logic. It stores the data in the application/
    public class Inventory
    {
        public int ProductId { get; set; }

        public int InventoryTag { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public DateTime DateAssigned { get; set; }

        public string Distributor { get; set; }

        public string Custodian { get; set; }

    }

}
