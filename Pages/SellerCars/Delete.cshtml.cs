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
      public Seller Seller { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.sellers == null)
            {
                return NotFound();
            }

            var seller = await _context.sellers.FirstOrDefaultAsync(m => m.SellerID == id);

            if (seller == null)
            {
                return NotFound();
            }
            else 
            {
                Seller = seller;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.sellers == null)
            {
                return NotFound();
            }
            var seller = await _context.sellers.FindAsync(id);

            if (seller != null)
            {
                Seller = seller;
                _context.sellers.Remove(Seller);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
