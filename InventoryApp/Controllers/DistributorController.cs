using InventoryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Controllers
{
    public class DistributorController : Controller
    {
        private readonly IDistributorRepository repo;

        public DistributorController (IDistributorRepository repo) 
        {
        
            this.repo = repo;
        
        }

        public IActionResult IndexDistributor()
        {
            var distributors = repo.GetAllDistributors();
            return View(distributors);
        }

        public IActionResult ViewDistributor(int id) //What does the "id" value do in this method"
        {
            var distributorInventoryVM = new DistributorInventoriesViewModel
            {
                Distributor = repo.GetDistributor(id),
                ListOfInventories = repo.GetAllDistributorInventories(id)
            };

            return View(distributorInventoryVM);


        }

    }
}
