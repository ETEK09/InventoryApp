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

        public IEnumerable<Inventory> GetALLInventory()
        {
            return _conn.Query<Inventory>("Select * from inventory");
        }
    }
}
