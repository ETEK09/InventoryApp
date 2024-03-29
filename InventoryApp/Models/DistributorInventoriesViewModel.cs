namespace InventoryApp.Models
{
    public class DistributorInventoriesViewModel
    {
        public Distributor Distributor { get; set; }

        public IEnumerable<Inventory> DistributorInventories { get; set; }

    }
}
