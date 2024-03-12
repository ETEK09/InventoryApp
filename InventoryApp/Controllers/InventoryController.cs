﻿using InventoryApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

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


        public IActionResult UpdateInventory (int id) 
        {

            Inventory inventory = repo.GetInventory(id);

            if(inventory == null) 
            {
            
                return View("Item not found");
            
            }
            return View(inventory);
        
        }


        public IActionResult UpdateInventoryToDatabase (Inventory inventory) 
        {

            repo.UpdateInventory(inventory);

            return RedirectToAction("ViewInventory", new {id = inventory.ProductID});
        
        
        }
    }
}
