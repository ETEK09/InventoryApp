using InventoryApp.Models;
using System.Data;

namespace InventoryApp
{
    //Interface retrieves a set of methods representing common operations for interacting with data such as querying, editing, adding, and deleting records.  
    public interface IInventoryRepository
    {
        public IEnumerable<Inventory> GetAllInventory();
        public IEnumerable<Distributor> GetInventoriesAndDistributor (int id);

        public Inventory GetInventory(int id);

        public void UpdateInventory(Inventory inventory);

        public void InsertInventory(Inventory insertToInventory);

        public IEnumerable<Distributor> GetADistributor();

        public Inventory AssignDistributor();

        public void DeleteInventory(Inventory inventory);

       


    }
}
