using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Controllers
{
    public class InventoryController : Controller
    {
        private IInventoryRepository repo;

        public InventoryController(IInventoryRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index() 
        {
            var inventory = repo.GetAllInventory();
            return View(inventory);
        
        }
    }
}
