using InventoryApp.Models;

namespace InventoryApp
{

    ///The Interface declares a set of methods that represent the common operations interacting with data such as querying, editing, adding, and deleting records.
    public interface IInventoryRepository
    {
        public IEnumerable<Inventory> GetAllInventory();

        public Inventory GetInventory(int id);

        public void UpdateInventory(Inventory inventory);

    }
}
