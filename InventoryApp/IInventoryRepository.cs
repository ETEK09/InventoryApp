using InventoryApp.Models;

namespace InventoryApp
{
    //The interface declares a set of methods that represent common operations for interacting with data, such as querying, editing, adding, and deleting records.
    public interface IInventoryRepository
    {
        public IEnumerable<Inventory>GetAllInventory();

        Inventory GetInventory(int id);

        public void UpdateInventory(Inventory inventory);
    }
}
