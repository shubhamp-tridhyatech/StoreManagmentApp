using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static StoreApp.Models.Helper.Enums;

namespace StoreApp.Models.Model
{
    public class User : BaseModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
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
        public string ZipCode { get; set; }
        public int MyProperty { get; set; }
        [Required]
        public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; }

    }
}
