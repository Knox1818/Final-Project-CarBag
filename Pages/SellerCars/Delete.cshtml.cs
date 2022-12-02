using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project_CarBag.Models;

namespace Final_Project_CarBag.Pages.SellerCars
{
    public class DeleteModel : PageModel
    {
        private readonly Final_Project_CarBag.Models.Context _context;

        public DeleteModel(Final_Project_CarBag.Models.Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Car Car { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.cars == null)
            {
                return NotFound();
            }

            var car = await _context.cars.FirstOrDefaultAsync(m => m.CarID == id);

            if (car == null)
            {
                return NotFound();
            }
            else 
            {
                Car = car;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.cars == null)
            {
                return NotFound();
            }
            var car = await _context.cars.FindAsync(id);

            if (car != null)
            {
                Car = car;
                _context.cars.Remove(Car);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
