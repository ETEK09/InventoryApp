namespace InventoryApp.Models
{
    public class InventoryDistributorList
    {

        public Distributor Distributor { get; set; }

        public IEnumerable<Inventory> ListOfInventories { get; set; }


    }
}
