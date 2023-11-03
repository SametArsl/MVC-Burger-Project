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
    public class SauceController : Controller
    {
        private readonly Context _context;

        public SauceController(Context context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
              return _context.Sauces != null ? 
                          View(await _context.Sauces.ToListAsync()) :
                          Problem("Entity set 'Context.Sauces'  is null.");
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sauces == null)
            {
                return NotFound();
            }

            var sauce = await _context.Sauces
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sauce == null)
            {
                return NotFound();
            }

            return View(sauce);
        }

        
        public IActionResult Create()
        {
            BurgerVM burgerVM = new BurgerVM();
            return View(burgerVM);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Picture,Quantity,ID,Name,Price,CreationDate")] Sauce sauce)
        {
            //if (ModelState.IsValid)
            //{
            //    _context.Add(sauce);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(sauce);

            BurgerVM burgerVM = new BurgerVM();
            burgerVM.Sauce = sauce;
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

                    burgerVM.Sauce.Picture = picturePath;
                }
                sauce = burgerVM.Sauce;

                _context.Add(sauce);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            return View(sauce);
        }

    
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sauces == null)
            {
                return NotFound();
            }

            var sauce = await _context.Sauces.FindAsync(id);
            if (sauce == null)
            {
                return NotFound();
            }
            BurgerVM burgerVM = new BurgerVM();
            burgerVM.Sauce = sauce;
            return View(burgerVM);
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Picture,Quantity,ID,Name,Price,CreationDate")] Sauce sauce)
        {
            if (id != sauce.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sauce);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SauceExists(sauce.ID))
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
            return View(sauce);
        }

       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sauces == null)
            {
                return NotFound();
            }

            var sauce = await _context.Sauces
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sauce == null)
            {
                return NotFound();
            }

            return View(sauce);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sauces == null)
            {
                return Problem("Entity set 'Context.Sauces'  is null.");
            }
            var sauce = await _context.Sauces.FindAsync(id);
            if (sauce != null)
            {
                _context.Sauces.Remove(sauce);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SauceExists(int id)
        {
          return (_context.Sauces?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
