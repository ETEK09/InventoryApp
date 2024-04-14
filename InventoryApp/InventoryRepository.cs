using Dapper;
using InventoryApp.Models;
using MySql.Data.MySqlClient;
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

            //return _conn.Query<Inventory>("SELECT * FROM inventory");
            return _conn.Query<Inventory>("Select inventory.ProductID, inventory.Tag, inventory.ProductName, inventory.Description, inventory.DateAssigned, distributor.DName, inventory.Custodian FROM inventory LEFT JOIN distributor ON inventory.DistributorID = distributor.DistributorID");
        }

        public IEnumerable<Distributor> GetInventoriesAndDistributor(int id)
        {
            return _conn.Query<Distributor>("Select inventory.ProductID, inventory.Tag, inventory.ProductName, inventory.Description, inventory.DateAssigned, distributor.DName, inventory.Custodian FROM inventory LEFT JOIN distributor ON inventory.DistributorID = distributor.DistributorID WHERE inventory.ProductID = @id", new

            {
                id = id,
            });
        }

        public Inventory GetInventory(int id) 
        {

            return _conn.QuerySingle<Inventory>("Select * from inventory where productid = @id", new {id = id});
               
        }


        public void UpdateInventory(Inventory inventory)
        {

            _conn.Execute("Update inventory SET  ProductName = @productname", new
            {
              
                productname = inventory.ProductName
                
            });

        }

        public Inventory AssignDistributor()
        {
            var distributorlist = GetADistributor();
            var inventory = new Inventory();
            inventory.ListOfDistributors = distributorlist;
            return inventory;
        }




        public void InsertInventory(Inventory insertToInventory) 
        {
            _conn.Execute("Insert INTO inventory (productid, tag, productname, description, dateassigned, distributorID, Dname, custodian) VALUES (@productid, @tag, @productname, @description, @dateassigned, @distributorID, @dname, @custodian)", new
            {
                productid = insertToInventory.ProductID,
                tag = insertToInventory.Tag,
                productname = insertToInventory.ProductName,
                description = insertToInventory.Description,
                dateassigned = insertToInventory.DateAssigned,
                distributorid = insertToInventory.DistributorID,
                dname = insertToInventory.DName,
                custodian = insertToInventory.Custodian
            });


        }

        public IEnumerable<Distributor> GetADistributor()
        {
            return _conn.Query<Distributor>("SELECT * FROM distributor;");
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
