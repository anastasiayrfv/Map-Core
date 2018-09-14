using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map.Models
{
    public interface IMapRepository
    {
        IQueryable<Place> Places { get; }
        IQueryable<User> Users { get; }
        void SavePlace(Place place);
        void SaveUser(User user);

        Place DeletePlace(int Id);
        User DeleteUser(int Id);
    }
}
