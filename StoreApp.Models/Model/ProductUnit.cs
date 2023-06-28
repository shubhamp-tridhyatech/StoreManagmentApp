using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.Models.Model
{
    public class ProductUnit : BaseModel
    {
        [Required]
        [StringLength(100)]
        public string UnitName { get; set; }
        [StringLength(500)]
        public string Fomula { get; set; }
        [Required]
        public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }
    }
}
