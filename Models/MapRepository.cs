using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map.Models
{
    public class MapRepository : IMapRepository
    {
        private MapContext context;

        public MapRepository(MapContext context)
        {
            this.context = context;
        }

        public IQueryable<Place> Places =>context.Places;

        public IQueryable<User> Users => context.Users;

        public void SavePlace(Place place)
        {
            if (place.Id == 0)
            {
                context.Places.Add(place);
            }
            else
            {
                Place dbEntry = context.Places
                .FirstOrDefault(p => p.Id == place.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = place.Name;
                    dbEntry.Lat = place.Lat;
                    dbEntry.Lng = place.Lng;
                    dbEntry.Address = place.Address;
                    dbEntry.City = place.City;
                    dbEntry.Country = place.Country;
                    dbEntry.PlaceId = place.PlaceId;
                    dbEntry.Rating = place.Rating;
                    dbEntry.Site = place.Site;
                    dbEntry.State = place.State;
                    dbEntry.Street = place.Street;
                    dbEntry.Type = place.Type;
                    dbEntry.UserId = place.UserId;

                }
            }
            context.SaveChanges();
        }

        public void SaveUser(User user)
        {
            if (user.Id == 0)
            {
                context.Users.Add(user);
            }
            else
            {
                User  dbEntry = context.Users
                .FirstOrDefault(p => p.Id == user.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = user.Name;
                    dbEntry.CardId = user.CardId;
                    dbEntry.Address = user.Address;
                    dbEntry.Email = user.Email;
                    dbEntry.Phone = user.Phone;
                    dbEntry.Role = user.Role;
                }
            }
            context.SaveChanges();
        }

        public Place DeletePlace(int Id)
        {
            Place dbEntry = context.Places
            .FirstOrDefault(p => p.Id == Id);
            if (dbEntry != null)
            {
                context.Places.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public User DeleteUser(int Id)
        {
            User dbEntry = context.Users
            .FirstOrDefault(p => p.Id == Id);
            if (dbEntry != null)
            {
                context.Users.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
