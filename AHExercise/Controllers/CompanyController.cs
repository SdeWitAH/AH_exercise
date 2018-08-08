using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using AHExercise.DAL;
using AHExercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace AHExercise.Controllers
{
    public class CompanyController : Controller
    {
        DatabaseContext_ _context;
        public CompanyController(DatabaseContext_ context) 
        {
            _context = context;
        }
        // Navigation 
        public IActionResult Index()
        {
            var model = _context.Companies.Select(x => x);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        // **


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Company CmpRec)
        {
            if (id != CmpRec.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
              _context.Update(CmpRec);
              await _context.SaveChangesAsync();
                
                
              return RedirectToAction(nameof(Index));
            }
            return View(CmpRec);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Company CmpRec)
        {
       
            if (ModelState.IsValid)
            {
                _context.Add(CmpRec);
                await _context.SaveChangesAsync();


                return RedirectToAction(nameof(Index));
            }
            return View(CmpRec);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var CmpRec = _context.Companies.Find(id);
            if (CmpRec == null)
            {
                return NotFound();
            }

            _context.Companies.Remove(CmpRec);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}