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

      public Seller Seller { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.sellers == null)
            {
                return NotFound();
            }

            var professor = await _context.sellers.Include(s => s.Cars).FirstOrDefaultAsync(s => s.SellerID == id);
            if (professor == null)
            {
                return NotFound();
            }
            else 
            {
                Seller = Seller;
            }
            return Page();
        }
        public IActionResult OnPostBuyCar(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Find the car in the database
            var Review = _context.cars.FirstOrDefault(c => c.CarID == CarIDToBuy);
            
            if (Review != null)
            {
                _context.Remove(Car); // "buy" the car
                _context.SaveChanges();
            }

            Seller = _context.sellers.Include(s => s.Cars).First(s => s.SellerID == id);

            return Page();
        }   
    }
}
