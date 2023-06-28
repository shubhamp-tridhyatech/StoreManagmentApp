using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models.Model
{
    public class Country : BaseModel
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(255)]
        public string CountryName { get; set; }
    }
}
