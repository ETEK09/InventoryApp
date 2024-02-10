using InventoryApp.Models;

namespace InventoryApp
{
    //The interface declares a set of methods that represent common operations for interacting with data such as querying, updating, adding, and deleting records
    public interface IInventoryRepository
    {   
        //Method is used to retrieve a collection of data from the Inventory model//
        public IEnumerable<Inventory> GetAllInventory();

        Inventory GetInventory(int id);

        
    }
}
