using InventoryApp.Models;

namespace InventoryApp
{
    public interface IInventoryRepository

        //This interface is declaring a method called GetAllInventory that will return a collection of inventory objects/
    {
        public IEnumerable<Inventory>GetAllInventory();
    }
}
