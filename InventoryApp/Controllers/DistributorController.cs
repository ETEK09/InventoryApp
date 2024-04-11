using InventoryApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

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

        public IActionResult ViewDistributor(int id) 
        {
        
            var distributor = repo.GetDistributor(id);
            return View(distributor);
        
        
        }
        public IActionResult ViewDistributorInventory(int id) //What does the "id" value do in this method"
        {
            var distributorInventoryVM = new DistributorInventoriesViewModel
            {
                Distributor = repo.GetDistributor(id),
                ListOfInventories = repo.GetAllDistributorInventories(id)
            };

            return View(distributorInventoryVM);

        }


        public IActionResult UpdateDistributor(int id) 
        {

            Distributor distributor = repo.GetDistributor(id);
            {
                if (distributor == null) 
                {
                
                    return View (null);
                
                }

                return View(distributor);

            }      
        
        }

        public IActionResult UpdateDistributorToDatabase(Distributor distributor) 
        {

            repo.UpdateDistributor(distributor);
            return RedirectToAction("ViewDistributor", new {id = distributor.DistributorID});
        
              
        }

    }
}
