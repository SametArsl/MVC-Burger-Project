using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVC_Burger_Project.DAL;
using MVC_Burger_Project.Models.Entities;
using MVC_Burger_Project.ModelVM;

namespace MVC_Burger_Project.Areas.ManagerPanel.Controllers
{
    [Area("ManagerPanel")]
    [Authorize(Roles = "Manager")]

    [Authorize(Policy = "RequireAdminRole")]
    public class SideController : Controller
    {
        private readonly Context _context;

        public SideController(Context context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
              return _context.Sides != null ? 
                          View(await _context.Sides.ToListAsync()) :
                          Problem("Entity set 'Context.Sides'  is null.");
        }

       
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sides == null)
            {
                return NotFound();
            }

            var side = await _context.Sides
                .FirstOrDefaultAsync(m => m.ID == id);
            if (side == null)
            {
                return NotFound();
            }

            return View(side);
        }

        
        public IActionResult Create()
        {
            BurgerVM burgerVM = new BurgerVM();
            return View(burgerVM);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Picture,Quantity,ID,Name,Price,CreationDate")] Side side)
        {
            //if (ModelState.IsValid)
            //{
            //    _context.Add(side);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(side);

            BurgerVM burgerVM = new BurgerVM();
            burgerVM.Side = side;

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
                    burgerVM.Side.Picture = picturePath;
                }
                side = burgerVM.Side;
                _context.Add(side);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(side);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sides == null)
            {
                return NotFound();
            }

            var side = await _context.Sides.FindAsync(id);
            if (side == null)
            {
                return NotFound();
            }
            BurgerVM burgerVM = new BurgerVM();
            burgerVM.Side = side;
            return View(burgerVM);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Picture,Quantity,ID,Name,Price,CreationDate")] Side side)
        {
            if (id != side.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(side);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SideExists(side.ID))
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
            return View(side);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sides == null)
            {
                return NotFound();
            }

            var side = await _context.Sides
                .FirstOrDefaultAsync(m => m.ID == id);
            if (side == null)
            {
                return NotFound();
            }

            return View(side);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sides == null)
            {
                return Problem("Entity set 'Context.Sides'  is null.");
            }
            var side = await _context.Sides.FindAsync(id);
            if (side != null)
            {
                _context.Sides.Remove(side);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SideExists(int id)
        {
          return (_context.Sides?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
