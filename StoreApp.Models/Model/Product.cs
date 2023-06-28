using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models.Model
{
    public class Product : BaseModel
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductUnitId { get; set; }
        [ForeignKey("ProductUnitId")]
        public virtual ProductUnit ProductUnit { get; set; }
        public int ProductCategoryId { get; set; }
        [ForeignKey("ProductCategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }
        public int ProductTaxId { get; set; }
        [ForeignKey("ProductTaxId")]
        public virtual ProductTaxes ProductTaxes { get; set; }
        public int AlertUnits { get; set; }
        [Required]
        public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }
    }
}
