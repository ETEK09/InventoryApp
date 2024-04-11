using InventoryApp.Models;

namespace InventoryApp
{
    public interface IDistributorRepository
    {
        public IEnumerable<Distributor> GetAllDistributors();
        public Distributor GetDistributor(int distributorID);

        public IEnumerable<Inventory> GetAllDistributorInventories(int distributorID);

        public void UpdateDistributor (Distributor distributor); //Why is the parameter Distributor instead of id and why return type is void/


    }
}
