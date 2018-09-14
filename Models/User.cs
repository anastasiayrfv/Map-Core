using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map.Models
{
    public enum Role
    {
        User = 1,
        Moderator,
        Admin
    }
    public class User
    {
            public int Id { get; set; }
            public string CardId { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public Role Role { get; set; }   
    }
}
