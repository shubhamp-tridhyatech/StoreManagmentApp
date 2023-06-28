using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.Models.Model
{
    public class ProductTaxes : BaseModel
    {
        [Required]
        [StringLength(50)]
        public string TaxName { get; set; }        
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal TaxRate { get; set; }
        [StringLength(500)]
        public string TaxDescription { get; set; }
        [Required]
        public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }
    }
}
