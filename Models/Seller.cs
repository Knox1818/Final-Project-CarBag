using System.ComponentModel.DataAnnotations;

namespace Final_Project_CarBag.Models
{
    public class Seller{
        public int SellerID {get;set;}
        [StringLength(30, MinimumLength=3)]
        [Required]
        public string? Username {get;set;}
        [StringLength(200, MinimumLength=3)]
        [Required]
        public string? Address {get;set;}
        [StringLength(30, MinimumLength=3)]
        [Required]
        public string? Email {get;set;}
        public List<Car> Cars {get;set;}=new List<Car>();
    }
}