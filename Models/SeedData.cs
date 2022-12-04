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
                        Location= "308 Negra Arroyo Lane, Albuquerque, New Mexico",
                        Email= "walterwhite@gmail.com",
                        Cars= new List<Car>{
                            new Car {Make="Aston Martin", Model="One-77", Color="Silver", Year=2012, Mileage=300, Price=2000000},
                            new Car {Make="Porsche", Model="918 Spyder", Color="Acid Green", Year=2014, Mileage=1000, Price=1800000},
                            new Car {Make="Lexus", Model="LFA", Color="Yellow", Year=2010, Mileage=5000, Price=375000},
                            new Car {Make="Ferrari", Model="LaFerrari", Color="Red", Year=2013, Mileage=100, Price=3500000},
                            new Car {Make="Ferrari", Model="F40", Color="Red", Year=1988, Mileage=2000, Price=1500000},
                            new Car {Make="Ford", Model="GT", Color="Dark blue", Year=2021, Mileage=1000, Price=700000},
                            new Car {Make="McLaren", Model="Senna", Color="Kyanos blue with orange accents", Year=2019, Mileage=250, Price=1900000},
                            new Car {Make="Mclaren", Model="P1", Color="Volcano Orange", Year=2013, Mileage=300, Price=2000000},
                            new Car {Make="Aston Martin", Model="Vulcan", Color="Charcoal gray with bright blue accents", Year=2016, Mileage=800, Price=2500000}
                        }
                    },
                    new Seller{
                        Username= "Gustavo Fring",
                        Location= "188 Willow Grove, Austin, Texas",
                        Email= "gustavofring@gmail.com",
                        Cars= new List<Car>{
                            new Car {Make="Ferrari", Model="812 Superfast", Color="Red with yellow stripe", Year=2020, Mileage=10000, Price=400000},
                            new Car {Make="Dodge", Model="Viper ACR", Color="Silver with black and red stripe", Year=2016, Mileage=8000, Price=200000},
                            new Car {Make="Mercedes-AMG", Model="GT Black Series", Color="Orange", Year=2021, Mileage=200, Price=350000},
                            new Car {Make="Chevrolet", Model="Camaro", Color="Forest green", Year=1969, Mileage=10000, Price=120000},
                            new Car {Make="Ford", Model="Mustang Boss", Color="Yellow with black accents", Year=1969, Mileage=5000, Price=100000},
                            new Car {Make="Ford", Model="Falcon", Color="Blue with silver accents", Year=1974, Mileage=10000, Price=80000},
                            new Car {Make="Pontiac", Model="Firebird Trans-Am", Color="White with blue striping", Year=1969, Mileage=8000, Price=250000},
                            new Car {Make="Chevrolet", Model="Corvette ZR1", Color="Red", Year=1970, Mileage=12000, Price=220000},
                            new Car {Make="Chevrolet", Model="Corvette ZR1", Color="Orange", Year=2019, Mileage=5000, Price=170000},
                            new Car {Make="Ford", Model="Mustang GT-500", Color="Blue with white stripes", Year=2021, Mileage=2500, Price=130000}
                        }
                    },
                    new Seller{
                        Username= "Jimmy McGill",
                        Location= "220 Mountain View Road, Helena, Montana",
                        Email= "jimmymcgill@gmail.com",
                        Cars= new List<Car>{
                            new Car {Make="Lamborghini", Model="Veneno", Color="Silver with red accents", Year=2013, Mileage=200, Price=12000000},
                            new Car {Make="Koenigsegg", Model="Jesko", Color="Silver with bright green accents", Year=2021, Mileage=500, Price=3000000},
                            new Car {Make="BMW", Model="M8", Color="Isle of Man green", Year=2022, Mileage=750, Price=150000},
                            new Car {Make="Pontiac", Model="GTO", Color="Mint turquoise", Year=1970, Mileage=15000, Price=75000},
                            new Car {Make="Ford", Model="Mach 1", Color="Red with black striping", Year=1972, Mileage=10000, Price=80000},
                            new Car {Make="AMC", Model="Javelin", Color="Green with black striping", Year=1973, Mileage=20000, Price=60000},
                            new Car {Make="Dodge", Model="Coronet Super Bee", Color="Plum Crazy", Year=1970, Mileage=80000, Price=70000},
                            new Car {Make="Dodge", Model="Charger Daytona", Color="Orange with white tail", Year=1969, Mileage=65000, Price=1000000},
                            new Car {Make="Plymouth", Model="Barracuda", Color="Limelight green", Year=1970, Mileage=5000, Price=300000}
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}