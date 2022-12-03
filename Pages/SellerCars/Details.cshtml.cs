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
    public class DetailsModel : PageModel
    {
        private readonly Final_Project_CarBag.Models.Context _context;

        public DetailsModel(Final_Project_CarBag.Models.Context context)
        {
            _context = context;
        }

      public Car Car { get; set; } = default!;
      public Seller Seller { get; set; } = default!; 
      [BindProperty]
      public int CarIDToBuy {get; set;}


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.cars == null)
            {
                return NotFound();
            }

            var car = await _context.cars.Include(c => c.Sellers).FirstOrDefaultAsync(s => s.CarID == id);
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
    }
}
