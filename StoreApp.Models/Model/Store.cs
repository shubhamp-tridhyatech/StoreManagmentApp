using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApp.Models.Model
{
    public class Store : BaseModel
    {
        [Required]
        [StringLength(100)]
        public string StoreDisplayID { get; set; }
        [Required]
        [StringLength(100)]
        public string StoreName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int CityId { get; set; }
        [ForeignKey("StateId")]
        public virtual City City { get; set; }
        public int StateId { get; set; }
        [ForeignKey("StateId")]
        public virtual State State { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        [StringLength(10)]
        public string Zipcode { get; set; }
        [StringLength(10)]
        public string PhoneNo { get; set; }
        [StringLength(10)]
        public string PhoneExtension { get; set; }
        public int CurrencyId { get; set; }
        public string StoreLogoPath { get; set; }
        public string StoreDetailDescription { get; set; }
        public string EmailId { get; set; }
    }
}
