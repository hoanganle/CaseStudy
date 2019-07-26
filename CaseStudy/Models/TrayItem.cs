using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaseStudy.Models
{
    public class TrayItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int TrayId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Qty { get; set; }
        [ForeignKey("TrayId")]
        public Tray Tray { get; set; }
        [ForeignKey("ProductId")]
        public Products products
        {
            get; set;
        }
    }
}
