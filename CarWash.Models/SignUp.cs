using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarWash.Models;

public class SignUp
{
    [Key] public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public bool Active { get; set; }
    
    public int PaymentId { get; set; }
    [ForeignKey("PaymentId")] public Payment Payment { get; set; }
    
    public int UserId { get; set; }
    [ForeignKey("UserId")] public User User { get; set; }
    
    public int ServiceId { get; set; }
    [ForeignKey("ServiceId")] public Service Service { get; set; }
}