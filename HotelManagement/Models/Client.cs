using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models;

public class Client
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string LastName { get; set; }
    
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string PhoneNumber { get; set; }
    
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Adress { get; set; }
    
    
}