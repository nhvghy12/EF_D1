using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_D1.Data.Entities;

// [Table("Students")]
public class Student
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string? FirstName { get; set; }

    [Required, MaxLength(50)]
    public string? LastName { get; set; }

    [MaxLength(20)]
    public string? City { get; set; }

    [NotMapped]
    public string? State { get; set; }
    // public virtual Group Group { get; set; }
}