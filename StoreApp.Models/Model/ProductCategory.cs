using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.Models.Model
{
    public class ProductCategory : BaseModel
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(500)]
        public string CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        [Required]
        public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }
    }
}
