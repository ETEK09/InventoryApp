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
        
            _conn.Execute("Update inventory SET tag = @tag, custodian = @custodian, dateassigned = @dateassigned, distributor = @distributor, productname = @productname, description = @description where productid = @productid", new 
            { 
                tag = inventory.Tag,
                custodian = inventory.Custodian,
                dateassigned = inventory.DateAssigned,
                distributor = inventory.Distributor,
                productname = inventory.ProductName,
                description = inventory.Description,
                productid = inventory.ProductID
            });       
        
        }


        public void InsertInventory(Inventory insertToInventory) 
        {
            _conn.Execute("Insert INTO inventory (productid, tag, productname, description, dateassigned, distributor, custodian) VALUES (@productid, @tag, @productname, @description, @dateassigned, @distributor, @custodian)", new
            {
                productid = insertToInventory.ProductID,
                inventorytag = insertToInventory.Tag,
                productname = insertToInventory.ProductName,
                description = insertToInventory.Description,
                dateassigned = insertToInventory.DateAssigned,
                distributor = insertToInventory.Distributor,
                custodian = insertToInventory.Custodian
            });


        }

        public void DeleteInventory(Inventory inventory) 
        {

            _conn.Execute("Delete from inventory where productid = @id;", new
            {
                id = inventory.ProductID
            });
        
        
        
        }


    }

}
