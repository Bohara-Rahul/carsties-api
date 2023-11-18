using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;
public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        SeedData(scope.ServiceProvider.GetService<AuctionDbContext>());
    }   

    public static void SeedData(AuctionDbContext context)
    {
        context.Database.Migrate();

        if (context.Auctions.Any())
        {
            Console.WriteLine("Already have data - no need to seed");
            return;
        }

        var auctions = new List<Auction>()
        {
            new Auction
            {
                Id = Guid.Parse("afbee524-5972-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(10),
                Item = new Item
                {
                    Make = "Ford",
                    Model = "GT",
                    Color = "White",
                    Mileage = 50000,
                    Year = 2020,
                    ImageUrl = "https://cdn.pixabay.com/photos/2016/05/06/16/32/car-1376190_960_720.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("abbee524-5972-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice =30000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(20),
                Item = new Item
                {
                    Make = "BMW",
                    Model = "X6",
                    Color = "blue",
                    Mileage = 50000,
                    Year = 2020,
                    ImageUrl = "https://cdn.pixabay.com/photos/2016/05/06/16/32/car-1376190_960_720.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("bdfeer524-5972-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 180000,
                Seller = "mike",
                AuctionEnd = DateTime.UtcNow.AddDays(30),
                Item = new Item
                {
                    Make = "Lamborghini",
                    Model = "Urus",
                    Color = "gray",
                    Mileage = 50000,
                    Year = 2020,
                    ImageUrl = "https://cdn.pixabay.com/photos/2016/05/06/16/32/car-1376190_960_720.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("afbee534-5972-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 25000,
                Seller = "john",
                AuctionEnd = DateTime.UtcNow.AddDays(10),
                Item = new Item
                {
                    Make = "Ford",
                    Model = "Mustang",
                    Color = "black",
                    Mileage = 50000,
                    Year = 2020,
                    ImageUrl = "https://cdn.pixabay.com/photos/2016/05/06/16/32/car-1376190_960_720.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("afbee600-5972-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 235000,
                Seller = "jane",
                AuctionEnd = DateTime.UtcNow.AddDays(50),
                Item = new Item
                {
                    Make = "Aston Martin",
                    Model = "DB7",
                    Color = "White",
                    Mileage = 15000,
                    Year = 2021,
                    ImageUrl = "https://cdn.pixabay.com/photos/2016/05/06/16/32/car-1376190_960_720.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("cdefs278-5972-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 200000,
                Seller = "rahul",
                AuctionEnd = DateTime.UtcNow.AddDays(60),
                Item = new Item
                {
                    Make = "Ferrari",
                    Model = "485 Italia",
                    Color = "red",
                    Mileage = 25000,
                    Year = 2022,
                    ImageUrl = "https://cdn.pixabay.com/photos/2016/05/06/16/32/car-1376190_960_720.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("afbee524-2582-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 45000,
                Seller = "mark",
                AuctionEnd = DateTime.UtcNow.AddDays(35),
                Item = new Item
                {
                    Make = "Toyota",
                    Model = "Camry",
                    Color = "White",
                    Mileage = 50000,
                    Year = 2019,
                    ImageUrl = "https://cdn.pixabay.com/photos/2016/05/06/16/32/car-1376190_960_720.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("abcrf129-5972-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "william",
                AuctionEnd = DateTime.UtcNow.AddDays(30),
                Item = new Item
                {
                    Make = "Mazda",
                    Model = "XC 9",
                    Color = "White",
                    Mileage = 50000,
                    Year = 2018,
                    ImageUrl = "https://cdn.pixabay.com/photos/2016/05/06/16/32/car-1376190_960_720.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("cbnqs524-5972-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "adrian",
                AuctionEnd = DateTime.UtcNow.AddDays(18),
                Item = new Item
                {
                    Make = "Suzuki",
                    Model = "Liana",
                    Color = "blue",
                    Mileage = 70000,
                    Year = 2023,
                    ImageUrl = "https://cdn.pixabay.com/photos/2016/05/06/16/32/car-1376190_960_720.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("afbee524-1357-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bobby",
                AuctionEnd = DateTime.UtcNow.AddDays(30),
                Item = new Item
                {
                    Make = "Cadillac",
                    Model = "Escalade",
                    Color = "maroon",
                    Mileage = 50000,
                    Year = 2020,
                    ImageUrl = "https://cdn.pixabay.com/photos/2016/05/06/16/32/car-1376190_960_720.jpg"
                }
            }
        };

        context.AddRange(auctions);
        context.SaveChanges();
    }
}
