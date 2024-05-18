using System;
using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El numero de habitacion es obligatorio")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "El tipo de habitacion es obligatorio")]
        public RoomType Type { get; set; }

        [Required(ErrorMessage = "El precio por noche es obligatorio")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser un valor positivo")]
        public decimal PricePerNight { get; set; }

        [Required(ErrorMessage = "El estado de la habitacion es obligatorio")]
        [EnumDataType(typeof(RoomStatus), ErrorMessage = "Estado no válido")]
        public RoomStatus Status { get; set; }

        public string Description { get; set; } // Campo opcional para descripciones adicionales
    }

    public enum RoomType
    {
        Single,
        Double,
        Suite,
        Family
    }

    public enum RoomStatus
    {
        Available,
        Occupied,
        Maintenance
    }
}