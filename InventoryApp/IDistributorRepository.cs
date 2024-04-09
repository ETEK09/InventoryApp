using InventoryApp.Models;

namespace InventoryApp
{
    public interface IDistributorRepository
    {
        public IEnumerable<Distributor> GetAllDistributors();
        public Distributor GetDistributor(int distributorID);

        public IEnumerable<Inventory> GetAllDistributorInventories(int distributorID);
    }
}
