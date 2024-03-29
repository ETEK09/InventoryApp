using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Controllers
{
    public class DistributorController : Controller
    {
        private readonly IInventoryRepository repo;

        public DistributorController (IInventoryRepository repo) 
        {
        
            this.repo = repo;
        
        }

        public IActionResult IndexDistributor()
        {
            var distributor = repo.GetALLDistributors();
            return View(distributor);
        }

        public IActionResult ViewDistributor(int id)
        {
            var distributor = repo.GetDistributor(id);
            return View(distributor);
            

        }

    }
}
