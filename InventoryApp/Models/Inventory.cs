namespace InventoryApp.Models
{
    //ASP.NET stands for Active Server Pgaes.NET. It is a framework developed by Microsoft that allow users to build dynamic wep apps and services. This allow web developers to create scallable, robust, and intereactive web apps using C# and VB.NET
    //The Model consists of objects that represent the shape of data. It maintains the data of the application.
    public class Inventory
    {
        public int ProductId { get; set; }

        public int InventoryTag { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public DateTime DateAssigned { get; set; }

        public string Distributor { get; set; }

        public string Custodian { get; set; }

        //public bool IsValid()
        //{
        //    // Validate required properties
        //    if (ProductId == 0 || InventoryTag == 0 || string.IsNullOrEmpty(ProductName) || DateAssigned == default(DateTime) || string.IsNullOrEmpty(Distributor) || string.IsNullOrEmpty(Custodian))
        //    {
        //        return false;
        //    }

        //    // Additional validation logic as needed

        //    return true; // All validation criteria passed
        //}

    }
}
