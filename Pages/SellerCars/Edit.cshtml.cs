using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Project_CarBag.Models;

namespace Final_Project_CarBag.Pages.SellerCars
{
    public class EditModel : PageModel
    {
        private readonly Final_Project_CarBag.Models.Context _context;

        public EditModel(Final_Project_CarBag.Models.Context context)
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

            var seller =  await _context.sellers.FirstOrDefaultAsync(m => m.SellerID == id);
            if (seller == null)
            {
                return NotFound();
            }
            Seller = seller;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Seller).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SellerExists(Seller.SellerID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SellerExists(int id)
        {
          return (_context.sellers?.Any(e => e.SellerID == id)).GetValueOrDefault();
        }
    }
}
