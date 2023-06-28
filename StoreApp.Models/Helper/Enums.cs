using System.ComponentModel.DataAnnotations;

namespace StoreApp.Models.Helper
{
    public class Enums
    {
        public enum Gender
        {
            [Display(Name = "Male")]
            Male = 1,
            [Display(Name = "Female")]
            Female = 2
        }
        public enum ResponseStatusCode
        {
            Information = 100,
            SuccessFully = 200,
            Redirection = 300,
            ClientError = 400,
            ServerError = 500
        }
    }
}
