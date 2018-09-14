using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            
            MapContext context = app.ApplicationServices.GetRequiredService<MapContext>();
            context.Database.Migrate();
                if (!context.Places.Any())
                {
                    context.Places.AddRange(
                      new Place { Name = "Place1" },
                      new Place { Name = "Place2" },
                      new Place { Name = "Place3" }
                    );
                    context.SaveChanges();
                }
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                  new User { Name = "User1" },
                  new User { Name = "User2" },
                  new User { Name = "User2" }
                );
                context.SaveChanges();
            }
        }
        
    }
}

