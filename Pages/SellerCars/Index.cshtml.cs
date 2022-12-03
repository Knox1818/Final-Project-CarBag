using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project_CarBag.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final_Project_CarBag.Pages.SellerCars
{
    public class IndexModel : PageModel
    {
        private readonly Final_Project_CarBag.Models.Context _context;

        public IndexModel(Final_Project_CarBag.Models.Context context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;
        public SelectList SortList {get; set;} = default!;

        public async Task OnGetAsync()
        {
            if (_context.cars != null)
            {
               var query = _context.cars.Select(c => c);
                List<SelectListItem> sortItems = new List<SelectListItem> {
                    new SelectListItem { Text = "Make Ascending", Value = "first_asc" },
                    new SelectListItem { Text = "Make Descending", Value = "first_desc"}
                };
                SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

                switch (CurrentSort)
                {
                    case "first_asc": 
                        query = query.OrderBy(c => c.Make);
                        break;
                    case "first_desc":
                        query = query.OrderByDescending(c => c.Make);
                        break;
                    case "second_asc": 
                        query = query.OrderBy(c => c.Model);
                        break;
                    case "second_desc":
                        query = query.OrderByDescending(c => c.Model);
                        break;
                    case "third_asc": 
                        query = query.OrderBy(c => c.Color);
                        break;
                    case "third_desc":
                        query = query.OrderByDescending(c => c.Color);
                        break;
                    case "fourth_asc": 
                        query = query.OrderBy(c => c.Year);
                        break;
                    case "fourth_desc":
                        query = query.OrderByDescending(c => c.Year);
                        break;
                    case "fifht_asc": 
                        query = query.OrderBy(c => c.Mileage);
                        break;
                    case "fifth_desc":
                        query = query.OrderByDescending(c => c.Mileage);
                        break;
                    case "sixth_asc": 
                        query = query.OrderBy(c => c.Price);
                        break;
                    case "sixth_desc":
                        query = query.OrderByDescending(c => c.Price);
                        break;
                }
            }
        }
    }
}