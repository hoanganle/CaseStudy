using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CaseStudy.Models
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("BrandsId")]
        public Brands Brand { get; set; } // generates FK
        [Required]
        public int BrandsId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(20)]
        public string GraphicName { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal CostPrice { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal MSRP { get; set; }
        [Required]
        public int QtyOnHand { get; set; }
        [Required]
        public int QtyOnBackOrder { get; set; }
        [Required]
        [StringLength(2000)]
        public string Description { get; set; }
        
    }
}

