using InventoryApp.Models;

namespace InventoryApp
{
    //The interface declares several methods that represent common operations for interacting with data such as querying, adding, updating, and deleting records.
    public interface IInventoryRepository
    {
     public IEnumerable<Inventory>GetALLInventory();
       
    }
}
