using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El ID del cliente es obligatorio")]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "El ID de la habitacion es obligatorio")]
        public int RoomId { get; set; }

        [Required(ErrorMessage = "La fecha de entrada es obligatoria")]
        public DateTime CheckInDate { get; set; }

        [Required(ErrorMessage = "La fecha de salida es obligatoria")]
        public DateTime CheckOutDate { get; set; }

        [Required(ErrorMessage = "El precio total es obligatorio")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio total debe ser un valor positivo")]
        public decimal TotalPrice { get; set; }

        [Required(ErrorMessage = "El estado de la reserva es obligatorio")]
        [EnumDataType(typeof(ReservationStatus), ErrorMessage = "Estado de reserva no válido")]
        public ReservationStatus Status { get; set; }
    }

    public enum ReservationStatus
    {
        Confirmed,
        Cancelled,
        Completed
    }
}