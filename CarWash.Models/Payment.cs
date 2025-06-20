using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarWash.Models;

public class Payment
{
    [Key] public int Id { get; set; }
    public bool IsPaid { get; set; }
    
    public int UserId { get; set; }
    [ForeignKey("UserId")] public User User { get; set; }
}