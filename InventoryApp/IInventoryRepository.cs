using InventoryApp.Models;

namespace InventoryApp
{
    ///Interface retrieves a set of methods with common operations interacting with data, such as querying, ediitng, adding, and deleting records. 
    public interface IInventoryRepository
    {
        public IEnumerable<Inventory> GetAllInventory();

        public Inventory GetInventory(int id);

        public void UpdateInventory(Inventory inventory);


    }
}
