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

            return _conn.QuerySingle<Inventory>("Select * from inventory where productid = @id", new {id = id});
               
        }

        public void UpdateInventory(Inventory inventory) 
        {
        
            _conn.Execute("Update inventory SET inventorytag = inventorytag, custodian = @custodian, dateassigned = @dateassigned, distributor = @distributor, productname = @productname, description = @description where productid = @productid", new 
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


        public void InsertInventory(Inventory inventoryToInsert) 
        {

            _conn.Execute("INSERT INTO inventory (productid, inventorytag, productname, description, dateassigned, distributor, custodian) VALUES (@productid, @inventorytag, @productname, @description, @dateassigned, @distributor, @custodian)", new 
            {
                productid = inventoryToInsert.ProductID,
                inventorytag = inventoryToInsert.InventoryTag,
                productname = inventoryToInsert.ProductName,
                description = inventoryToInsert.Description,
                dateassigned = inventoryToInsert.DateAssigned,
                distributor = inventoryToInsert.Distributor,
                custodian = inventoryToInsert.Custodian,
                
                
            });

        }
    }
}
