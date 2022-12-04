using System.ComponentModel.DataAnnotations;

namespace Final_Project_CarBag.Models
{
    public class Car{
        public int CarID {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Make {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Model {get;set;}
        [StringLength(60, MinimumLength=1)]
        [Required]
        public string? Color {get;set;}
        [Required]
        public int Year {get;set;}
        [Required]
        public int Mileage {get;set;}
        [Required]
        [Range(0,99999999)]
        [DataType(DataType.Currency)]
        public double Price {get;set;}
        public Seller? Sellers {get;set;}
    }
}