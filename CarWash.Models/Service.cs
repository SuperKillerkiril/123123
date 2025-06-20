using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarWash.Models;

public class Service
{
    [Key] public int Id { get; set; }
    public string Description { get; set; }
}