using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.Models.Model
{
    public class ProductImage : BaseModel
    {
        public string StorePath { get; set; }
        [Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [StringLength(100)]
        public string FileName { get; set; }
        [StringLength(150)]
        public string OriginalFileName { get; set; }
        [Required]
        public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }
    }
}
