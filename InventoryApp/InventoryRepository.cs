using Dapper;
using InventoryApp.Models;
using System.Data;

namespace InventoryApp
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly IDbConnection _conn;

        public InventoryRepository(IDbConnection conn)
        {
            _conn = conn;
            
        }

        public IEnumerable<Inventory> GetAllInventory()
        {
            return _conn.Query<Inventory>("Select * from inventory");
        }

        public Inventory GetInventory(int id) 
        {
        
            return _conn.QuerySingle<Inventory>("Select * from inventory where productid = @id", new {id =id});
        
        
        }

        public void UpdateInventory(Inventory inventory) 
        {

            _conn.Execute("Update Inventory SET inventorytag = @inventorytag, custodian = @custodian, dateassigned = @dateassigned, distributor = @distributor, productname = @productname, description = @description where productid = @productid", new
            {
                inventorytag = inventory.InventoryTag,
                custodian = inventory.Custodian,
                dateassigned = inventory.DateAssigned,
                distributor = inventory.Distributor,
                productname = inventory.ProductName,
                description = inventory.Description,
                productid = inventory.ProductID
            });
              
        }
    }
}
