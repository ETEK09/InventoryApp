using InventoryApp.Models;

namespace InventoryApp
{
    //This interface declares a set of methods that represent common                                                    operations interacting with data, that includes adding, querying,                                                   updating, and deleting records.
    public interface IInventoryRepository 
    {

        public IEnumerable<Inventory> GetAllInventory(); //This method is responsible for retrieving a collection of Inventory objects. IInventory interface is declaring the GetAllInventory method to retrieve a collection of inventory objects


    }
}
