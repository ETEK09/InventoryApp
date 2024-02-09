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
            return _conn.Query<Inventory>("SELECT * FROM inventory");
        }

       public Inventory GetInventory(int id)
        {
            return _conn.QuerySingle<Inventory>("SELECT * From inventory where Productid = @id", new {id = id });
        }
    }
}
