using Dapper;
using InventoryApp.Models;
using System.Data;

namespace InventoryApp
{
    //The IDbconnection represents a connection to the datanase. 
    public class InventoryRepository : IInventoryRepository
    {
        private readonly IDbConnection _conn;

        public InventoryRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Inventory>GetAllInventory() 
        {

            return _conn.Query<Inventory>("SELECT * from Inventory");
        
        }

    }
}
