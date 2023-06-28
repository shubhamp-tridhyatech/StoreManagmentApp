using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models.Model
{
    public class State : BaseModel
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(255)]
        public string StateName { get; set; }
        [Required]
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country{ get; set; }
    }
}
