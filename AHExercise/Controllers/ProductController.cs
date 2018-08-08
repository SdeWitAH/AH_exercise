using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AHExercise.DAL;
using AHExercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace AHExercise.Controllers
{
    public class ProductController : Controller
    {

        // variable : _context = Get access to the database tables like _context.Companies

        DatabaseContext_ _context;
        public ProductController(DatabaseContext_ context)
        {
            _context = context;
        }


        // ActionResult Index is required to access the page : Views/Product/Index.cshtml 
        public IActionResult Index()
        {


            var model = ""; //TODO 4 : Fill in the missing code 
            return View(model);
        }


        // TODO 5 : Implement ActionResult Create,Delete,Edit



        //Uncomment this functions and fix the errors

//        [HttpGet]
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            //var product = await _context.*TODO 6 : Fill in the missing code*.FindAsync(id);
//            if (product == null)
//            {
//                return NotFound();
//            }
//            return View(product);
//        }
//        [HttpPost]
//        public async Task<IActionResult> Edit(int id, Products ProductRec)
//        {
//            if (id != ProductRec./*TODO 7 : Fill in the missing code*/)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                _context.Update(/*TODO 8 : Fill in the missing code */);
//                await _context.SaveChangesAsync();


//                return RedirectToAction(nameof(Index));
//            }
//            return View(ProductRec);
//        }
//        [HttpPost]
//        public async Task<IActionResult> Create(Products ProductRec)
//        {

//            if (ModelState.IsValid)
//            {
//                _context.Add(ProductRec);

//                /* TODO 9 : Fill in the missing code */



//                return RedirectToAction(nameof(Index));
//            }
//            return View(ProductRec);
//        }
//        [HttpGet]
//        public IActionResult Delete(int id)
//        {
//            var ProductRec = _context.Products.Find(/* TODO 10 : Fill in the missing code */);
//            if (ProductRec == null)
//            {
//                return NotFound();
//            }

//            _context.Products.Remove(/* TODO 11 : Fill in the missing code */);
//            _context.SaveChanges();
//            return RedirectToAction(nameof(Index));
//        }

//    }
//}

    // Remove this when uncommit
   }
}

