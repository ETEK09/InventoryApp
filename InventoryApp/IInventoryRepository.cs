using InventoryApp.Models;

namespace InventoryApp

    //The interface declares a set of methods that represents common operations for interacting with data, such as querying, adding, updating, and deleting records//
{
    public interface IInventoryRepository
    {
        public IEnumerable<Inventory>GetAllInventory();

        public Inventory GetInventory(int id);

    }
}
