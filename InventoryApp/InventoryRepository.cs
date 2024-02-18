using Dapper;
using InventoryApp.Models;
using System.Data;
using System.Net.Http.Headers;

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

            return _conn.QuerySingle<Inventory>("SELECT * From Inventory where Productid = @id", new { id = id });

        }

        public void UpdateInventory(Inventory inventory)
        {
            _conn.Execute("Update inventory SET custodian = @custodian, dateassigned = @dateassigned, distributor = @distributor, productname = @productname, inventoryTag = @inventorytag Where productid = @productid", new { 
                custodian = inventory.Custodian, 
                dateassigned = inventory.DateAssigned, 
                distributor = inventory.Distributor, 
                productName = inventory.ProductName, 
                inventoryTag = @inventory.InventoryTag, 
                productid = inventory.ProductId 
            });

        }


        public void InsertInventory(Inventory inventoryToInsert)
        {

            _conn.Execute("INSERT INTO Inventory (ProductId, InventoryTag, ProductName, Description, DateAssigned, Distributor, Custodian) VALUES (@ProductId, @InventoryTag, @ProductName, @Description, @DateAssigned, @Distributor, @Custodian);",
                new
                {
                    ProductId = inventoryToInsert.ProductId,
                    InventoryTag = inventoryToInsert.InventoryTag,
                    ProductName = inventoryToInsert.ProductName,
                    Description = inventoryToInsert.Description,
                    DateAssigned = inventoryToInsert.DateAssigned,
                    Distributor = inventoryToInsert.Distributor,
                    Custodian = inventoryToInsert.Custodian
                });
        }

        public void DeleteInventory(Inventory inventory)
        {
            _conn.Execute("Delete from inventory where productID = @id", new { id = inventory.ProductId });
            //_conn.Execute("Delete from ProductName where productID = @id", new {id = inventory.InventoryTag});
            //_conn.Execute("Delete from Description where productID = @id", new {id = inventory.ProductName});
            //_conn.Execute("Delete from DateAssigned where productID = @id", new {id = inventory.DateAssigned});
            //_conn.Execute("Delete from Distributor where productID = @id", new { id = inventory.Distributor });
            //_conn.Execute("Delete from Custodian where productID = @id", new {id = inventory.Custodian});


        }

    }
}


