using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToyStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app ) 
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>(); 

            if (context.Database.GetPendingMigrations().Any()) 
            {
                context.Database.Migrate();
            } 

            if (!context.Products.Any())  
            {
                context.Products.AddRange(
                    new Product 
                    {
                    Name = "Bicycle", 
                    Description = "A small bicycle for one person",
                    Category = "Mixed", 
                    Price = 275
                    }, 
                    new Product {
                    Name = "Toy train",
                    Description = "Toy train made out of plastic",
                    Category = "Mixed", 
                    Price = 48.95m
                    },
                    new Product {
                    Name = "Soccer ball",
                    Description = "Durable ball for soccer",
                    Category = "Boys", 
                    Price = 19.50m
                    },
                    new Product {
                    Name = "Doll",
                    Description = "Its a doll with ability to rotate its joints",
                    Category = "Girls", 
                    Price = 34.95m
                    },
                    new Product {
                    Name = "Teddy bear",
                    Description = "A plush teddy bear to be your childs friend",
                    Category = "Mixed", 
                    Price = 79500
                    },
                    new Product {
                    Name = "Crayons",
                    Description = "Used for drawing but DO NOT eat them",
                    Category = "Mixed", 
                    Price = 16
                    },
                    new Product {
                    Name = "Toy car",
                    Description = "A favourite toy of young kids",
                    Category = "Boys", 
                    Price = 29.95m
                    },
                    new Product {
                    Name = "Toy gun",
                    Description = "A toy gun made out of plastic",
                    Category = "Boys", 
                    Price = 250
                    },
                    new Product {
                    Name = "Custom necklace",
                    Description = "Set of parts that can be assembled into a neclace",
                    Category = "Girls", 
                    Price = 390
                    },
                    new Product {
                    Name = "Boogie board",
                    Description = "A drawing board that uses magnets",
                    Category = "Girls", 
                    Price = 29.95m
                    }
                );
                context.SaveChanges(); 
            }
        }
    }
}
