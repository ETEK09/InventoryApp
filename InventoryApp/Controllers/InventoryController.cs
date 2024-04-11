using InventoryApp.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Mysqlx.Crud;

namespace InventoryApp.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IInventoryRepository repo;

        public InventoryController(IInventoryRepository repo) 
        {
        
            this.repo = repo;      
        
        }
        public IActionResult Index()
        {
            var inventory = repo.GetAllInventory();
            return View(inventory);
        }

        public IActionResult ViewInventory(int id) 
        {
        
            var inventory = repo.GetInventory(id);
            return View(inventory);
        
        
        }


        public IActionResult UpdateInventory(int id) ///Why is it id//?
        {
        
            Inventory inventory = repo.GetInventory(id);

            if(inventory == null) 
            {
            
              return View("Product not found");
            
            
            }

            return View(inventory);
                
        }

        public IActionResult UpdateInventoryToDatabase(Inventory inventory) 
        {

           repo.UpdateInventory(inventory);

            return RedirectToAction("ViewInventory", new {id = inventory.ProductID});
        
        
        }

        public IActionResult InsertInventory(Inventory insertToInventory) 
        {

            return View(insertToInventory);
        
        
        }

        public IActionResult InsertInventoryToDatabase(Inventory insertToInventory) 
        {

            repo.InsertInventory(insertToInventory);

            return RedirectToAction("Index");
          
        }


        public IActionResult DeleteInventory(Inventory inventory) 
        {
        
                repo.DeleteInventory(inventory);

            return RedirectToAction("Index");
        
        
        }


    }
}
