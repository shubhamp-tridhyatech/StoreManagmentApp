using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.Models.Model
{
    public class ProductRates : BaseModel
    {
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rate { get; set; }
        public int Qty { get; set; }
        public bool IsDefualtRate { get; set; }
        [Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [Required]
        public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }
    }
}
