using Dapper;
using InventoryApp.Models;
using System.Data;

namespace InventoryApp
{

    //The repository class acts as a mediator between the 
    public class InventoryRepository : IInventoryRepository
    {
        private readonly IDbConnection _conn; ///This field is used to manage connection to a database
       
       public InventoryRepository(IDbConnection conn)
        {
            _conn = conn;
        }


        public IEnumerable<Inventory> GetAllInventory()
      {
            return _conn.Query<Inventory>("SELECT * FROM Inventory");

      }

    }
}
