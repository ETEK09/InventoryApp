namespace InventoryApp.Models
{
    public class DistributorInventoriesViewModel
    {
        public Distributor Distributor { get; set; }

        public IEnumerable<Inventory> ListOfInventories { get; set; }

    }
}
