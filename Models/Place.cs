using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Map.Models
{

   public  enum State
    {
        Detached = 0, 
        Added,
        Proven,
        Recommended
    }

    public enum Type
    {
        Hotel = 1,
        Eat,
        Entertainment, 
        Shopping
    }

    public class Place
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "Пожалуйста введите название")]
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Country { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string City { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Street { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Type { get; set; }
        public State State { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Site { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите координаты")]
        [Column(TypeName = "decimal(20, 17)")]
        public decimal Lat { get; set; }
        [Required(ErrorMessage = "Пожалуйста введите координаты")]
        [Column(TypeName = "decimal(20, 17)")]
        public decimal Lng { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string PlaceId { get; set; }
        public int Rating { get; set; }
        public int UserId { get; set; }

    }

}
