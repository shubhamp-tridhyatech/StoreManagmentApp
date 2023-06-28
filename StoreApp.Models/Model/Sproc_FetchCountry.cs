using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models.Model
{
    public class Sproc_FetchCountry
    {
        [Key]
        public long RowNo { get; set; }
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(255)]
        public string CountryName { get; set; }
    }
}
