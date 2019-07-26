using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaseStudy.Models
{
    public class Tray
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(9, 2)")]
        public decimal TotalPrice { get; set; }
        
    }
}
    

