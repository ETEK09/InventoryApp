using InventoryApp.Models;

namespace InventoryApp
{
    //Interface has a set of methods that represent common operations for interacting with data such as querying, editing, adding, and deleting records.
    public interface IInventoryRepository
    {
        public IEnumerable<Inventory> GetAllInventory();

        public Inventory GetInventory(int id);

        public void UpdateInventory(Inventory inventory);

    }
}
