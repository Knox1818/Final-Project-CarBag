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
    public class IndexModel : PageModel
    {
        private readonly Final_Project_CarBag.Models.Context _context;

        public IndexModel(Final_Project_CarBag.Models.Context context)
        {
            _context = context;
        }

        public IList<Seller> Seller { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.sellers != null)
            {
                Seller = await _context.sellers.ToListAsync();
            }
        }
    }
}
