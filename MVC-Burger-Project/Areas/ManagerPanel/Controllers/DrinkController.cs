using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Burger_Project.DAL;
using MVC_Burger_Project.Models.Entities;
using MVC_Burger_Project.ModelVM;

namespace MVC_Burger_Project.Areas.ManagerPanel.Controllers
{
    [Area("ManagerPanel")]
    [Authorize(Roles = "Manager")]

    [Authorize(Policy = "RequireAdminRole")]
    public class DrinkController : Controller
    {
        private readonly Context _context;

        public DrinkController(Context context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
              return _context.Drinks != null ? 
                          View(await _context.Drinks.ToListAsync()) :
                          Problem("Entity set 'Context.Drinks'  is null.");
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Drinks == null)
            {
                return NotFound();
            }

            var drink = await _context.Drinks
                .FirstOrDefaultAsync(m => m.ID == id);
            if (drink == null)
            {
                return NotFound();
            }

            return View(drink);
        }

        
        public IActionResult Create()
        {
            BurgerVM burgerVM = new BurgerVM();

            return View(burgerVM);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Picture,Quantity,ID,Name,Price,CreationDate")] Drink drink)
        {
            //if (ModelState.IsValid)
            //{
            //    _context.Add(drink);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(drink);


            BurgerVM burgerVM = new BurgerVM();
            burgerVM.Drink = drink;
            IFormFile picture = burgerVM.PictureFile;
            if (ModelState.IsValid)
            {
                if (picture != null && picture.Length > 0)
                {
                    
                    string picturePath = "uploads/" + Guid.NewGuid().ToString() + Path.GetExtension(picture.FileName);
                    string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", picturePath);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await picture.CopyToAsync(stream);
                    }

                    burgerVM.Drink.Picture = picturePath;
                }
                drink = burgerVM.Drink;

                _context.Add(drink);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            return View(drink);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Drinks == null)
            {
                return NotFound();
            }

            var drink = await _context.Drinks.FindAsync(id);
            if (drink == null)
            {
                return NotFound();
            }
            BurgerVM burgerVM = new BurgerVM();
            burgerVM.Drink = drink;
            return View(burgerVM);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Picture,Quantity,ID,Name,Price,CreationDate")] Drink drink)
        {
            if (id != drink.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drink);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrinkExists(drink.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(drink);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Drinks == null)
            {
                return NotFound();
            }

            var drink = await _context.Drinks
                .FirstOrDefaultAsync(m => m.ID == id);
            if (drink == null)
            {
                return NotFound();
            }

            return View(drink);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Drinks == null)
            {
                return Problem("Entity set 'Context.Drinks'  is null.");
            }
            var drink = await _context.Drinks.FindAsync(id);
            if (drink != null)
            {
                _context.Drinks.Remove(drink);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrinkExists(int id)
        {
          return (_context.Drinks?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
