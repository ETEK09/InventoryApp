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

        public void UpdateDistributor (Distributor distributorID) 
        {

            _conn.Execute("UPDATE distributor SET DName = @DName, Email = @Email, Phone = @Phone WHERE DistributorID = @DistributorID", new
            {
                DistributorID = distributorID.DistributorID,
                DName = distributorID.DName,
                Email = distributorID.Email,
                Phone = distributorID.Phone,
                
            }); 
        
        }

        public void InsertDistributor(Distributor distributor) 
        {
            _conn.Execute("INSERT INTO Distributor (distributorid, name, email, phone) VALUES (@distributorID, @name, @email, @phone)", new
            {
                distributorid = distributor.DistributorID,
                name = distributor.DName,
                Email = distributor.Email,
                phone = distributor.Phone

            });
               
        }

        public IEnumerable<Inventory> GetAllDistributorInventories(int distributorID)
        {
            return _conn.Query<Inventory>("SELECT distributor.DistributorID, inventory.Tag, inventory.ProductName, inventory.Description, inventory.DateAssigned, inventory.Custodian FROM Distributor LEFT JOIN Inventory ON distributor.DistributorID = inventory.DistributorID WHERE distributor.DistributorID = @id", new { id = distributorID });
        }

        public void DeleteDistributor(Distributor distributor)
        {

            _conn.Execute("Delete from distributor where distributorid = @id;", new
            {
                id = distributor.DistributorID

            });

        }

    }

}
