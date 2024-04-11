using Dapper;
using InventoryApp.Models;
using System.Data;

namespace InventoryApp
{
    public class DistributorRepository : IDistributorRepository
    {
        private readonly IDbConnection _conn;

        public DistributorRepository(IDbConnection conn)
        {
            _conn = conn;
        }


        public IEnumerable<Distributor> GetAllDistributors()
        {

            return _conn.Query<Distributor>("SELECT * FROM Distributor");


        }

        public Distributor GetDistributor(int distributorID)
        {
            return _conn.QuerySingle<Distributor>("SELECT * FROM Distributor where distributorID = @id", new { id = distributorID });
            
        }

        public void UpdateDistributor (Distributor disstributorID) 
        {

            _conn.Execute("UPDATE distributor SET DistributorID = @DistributorID, Name = @Name, Email = @Email, Phone = @Phone", new
            {
                DistributorID = disstributorID.DistributorID,
                Name = disstributorID.Name,
                Email = disstributorID.Email,
                Phone = disstributorID.Phone,
            }); 
        
        }

        public IEnumerable<Inventory> GetAllDistributorInventories(int distributorID)
        {
            return _conn.Query<Inventory>("SELECT distributor.DistributorID, inventory.Tag, inventory.ProductName, inventory.Description, inventory.DateAssigned, inventory.Custodian FROM Distributor LEFT JOIN Inventory ON distributor.DistributorID = inventory.DistributorID WHERE distributor.DistributorID = @id", new { id = distributorID });
        }

        
    }
}
