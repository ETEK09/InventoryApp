namespace InventoryApp.Models
{
    public class Distributor
    {
       public int DistributorID { get; set; }

       public string Name { get; set; }

        public int ProductID { get; set; }

        public int Tag { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public DateTime DateAssigned { get; set; }


        public string Custodian { get; set; }


    }
}
