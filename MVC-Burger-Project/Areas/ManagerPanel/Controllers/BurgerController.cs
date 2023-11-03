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
    public class BurgerController : Controller
    {
        private readonly Context _context;

        public BurgerController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var context = _context.Burgers.Include(b => b.Category);
            return View(await context.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Burgers == null)
            {
                return NotFound();
            }

            var burger = await _context.Burgers
                .Include(b => b.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (burger == null)
            {
                return NotFound();
            }
            BurgerVM burgerVM = new BurgerVM();
            burgerVM.Burger = burger;
            return View(burger);
        }

        public IActionResult Create()
        {

            BurgerVM burgerVM = new BurgerVM();

            burgerVM.Categories= new SelectList(_context.Categories, "CategoryID", "Name");


            
            return View(burgerVM);
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Description,Picture,Quantity,CategoryID,ID,Name,Price,CreationDate")] Burger burger)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(burger);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "CategoryID", burger.CategoryID);

        //    return View(burger);
        //}

            [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Picture,Quantity,CategoryID,ID,Name,Price,CreationDate")] Burger burger)
        {

            BurgerVM burgerVM = new BurgerVM();
            burgerVM.Burger = burger;

            IFormFile picture = burgerVM.PictureFile;
            if (ModelState.IsValid)
            {
                if (picture != null && picture.Length > 0)
                {
                    // Resim yüklendiyse, işle ve resmin yolunu güncelle
                    string picturePath = "uploads/" + Guid.NewGuid().ToString() + Path.GetExtension(picture.FileName);
                    string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", picturePath);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await picture.CopyToAsync(stream);
                    }

                    burgerVM.Burger.Picture = picturePath;
                    burgerVM.Burger.Quantity = 1;
                }
                burger = burgerVM.Burger;
                
                _context.Add(burger);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            burgerVM.Categories = new SelectList(_context.Categories, "CategoryID", "Name");

            return View(burger);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            
            if (id == null || _context.Burgers == null)
            {
                return NotFound();
            }

            var burger = await _context.Burgers.FindAsync(id);
            if (burger == null)
            {
                return NotFound();
            }
            BurgerVM burgerVM = new BurgerVM();
           
            burgerVM.Burger = burger;


            burgerVM.Categories = new SelectList(_context.Categories, "CategoryID", "Name");

            //ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "Name", burger.Category.Name);
            return View(burgerVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Picture,Quantity,CategoryID,ID,Name,Price,CreationDate")] Burger burger)
        {
            if (id != burger.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(burger);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BurgerExists(burger.ID))
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
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "CategoryID", burger.CategoryID);
            return View(burger);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Burgers == null)
            {
                return NotFound();
            }

            var burger = await _context.Burgers
                .Include(b => b.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (burger == null)
            {
                return NotFound();
            }

            return View(burger);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Burgers == null)
            {
                return Problem("Entity set 'Context.Burgers'  is null.");
            }
            var burger = await _context.Burgers.FindAsync(id);
            if (burger != null)
            {
                _context.Burgers.Remove(burger);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BurgerExists(int id)
        {
          return (_context.Burgers?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
