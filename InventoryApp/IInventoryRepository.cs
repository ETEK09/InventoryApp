using InventoryApp.Models;

namespace InventoryApp
{
    public interface IInventoryRepository
    {

        public IEnumerable<Inventory> GetAllInventory();
    }
}
