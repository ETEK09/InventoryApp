using InventoryApp.Models;

namespace InventoryApp
{
    public interface IInventoryRepository
    {
        public IEnumerable<Inventory> GetAllInventory();

        Inventory GetInventory(int id);

        void UpdateInventory(Inventory inventory);

        public void InsertInventory(Inventory inventoryToInsert);

        public void DeleteInventory (Inventory inventory);




        //public Inventory AssignInventory();
    }
}
