using Microsoft.EntityFrameworkCore;

//Here I seed the data with sellers, each with a car or cars to sell
namespace Final_Project_CarBag.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider){
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>())){
                if (context.sellers.Any())
                {
                    return;
                }
                context.sellers.AddRange(
                    new Seller{
                        Username= "Walter White",
                        Address= "308 Negra Arroyo Lane, Albuquerque, New Mexico",
                        Email= "walterwhite@gmail.com",
                        Cars= new List<Car>{
                            new Car {Make="Aston Martin", Model="One-77", Color="Silver", Year=2012, Mileage=300, Price=2000000M},
                            new Car {Make="Porsche", Model="918 Spyder", Color="Acid Green", Year=2014, Mileage=1000, Price=1800000M},
                            new Car {Make="Lexus", Model="LFA", Color="Yellow", Year=2010, Mileage=5000, Price=375000M},
                        }
                    },
                    new Seller{
                        Username= "Gustavo Fring",
                        Address= "188 Willow Grove, Austin, Texas",
                        Email= "gustavofring@gmail.com",
                        Cars= new List<Car>{
                            new Car {Make="Ferrari", Model="812 Superfast", Color="Red with yellow stripe", Year=2020, Mileage=10000, Price=400000M},
                            new Car {Make="Dodge", Model="Viper ACR", Color="Silver with black and red stripe", Year=2016, Mileage=8000, Price=200000M}
                        }
                    },
                    new Seller{
                        Username= "Jimmy McGill",
                        Address= "220 Mountain View Road, Helena, Montana",
                        Email= "jimmymcgill@gmail.com",
                        Cars= new List<Car>{
                            new Car {Make="Lamborghini", Model="Veneno", Color="Silver with red accents", Year=2013, Mileage=200, Price=12000000M}
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}