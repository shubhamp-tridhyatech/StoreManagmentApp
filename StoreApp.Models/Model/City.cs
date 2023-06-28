using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models.Model
{
    public class City : BaseModel
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(255)]
        public string CityName { get; set; }
        [Required]
        public int StateId { get; set; }
        [ForeignKey("StateId ")]
        public virtual State State { get; set; }
    }
}
