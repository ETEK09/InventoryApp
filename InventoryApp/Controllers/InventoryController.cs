using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace InventoryApp.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IInventoryRepository repo;

        public InventoryController (IInventoryRepository repo)
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
