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
            return _conn.Query<Inventory>("SELECT * From Inventory");
        }

        public Inventory GetInventory(int id) 
        {
        
            return _conn.QuerySingle<Inventory>("Select * from inventory where productid = @id", new { id = id });
        
        }

        public void UpdateInventory(Inventory inventory) 
        {

            _conn.Execute("Update inventory SET custodian = @custodian, DateAssigned = @dateassigned, distributor = @distributor Where ProductID = @id", new { custodian = inventory.Custodian, dateAssigned = inventory.DateAssigned, distributor = inventory.Distributor, id = inventory.ProductID });
        
        }
    }
}
