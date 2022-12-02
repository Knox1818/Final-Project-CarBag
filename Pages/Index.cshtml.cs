using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Final_Project_CarBag.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_CarBag.Pages;

public class IndexModel : PageModel
{
    private readonly Context _context;

    private readonly ILogger<IndexModel> _logger;
    public List <Car> Cars {get;set;}=default!;

    public IndexModel(Context context, ILogger<IndexModel> logger)
    {
        _context= context;
        _logger = logger;
    }

    public void OnGet()
    {
        Cars= _context.cars.ToList();
    }
}

