using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapstoneTest3.Models;

public class Order
{
    public int Id { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }
    [StringLength(80)]
    public string Description { get; set; } = string.Empty;
    [Column(TypeName = "decimal(11,2)")]
    public decimal Total { get; set; }
    [StringLength(20)]
    public string Status { get; set; } = string.Empty;

    //FK
    //Create column in db
    public int CustomerId { get; set; }
    //Create the virtual instance
    public virtual Customer? Customer {get; set;}
}
