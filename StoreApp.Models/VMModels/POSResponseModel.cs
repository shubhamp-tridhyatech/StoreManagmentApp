using static StoreApp.Models.Helper.Enums;

namespace StoreApp.Models.VMModels
{
    public class POSResponseModel
    {
        public ResponseStatusCode SuccessCode { get; set; }
        public bool IsSuccess { get; set; }
        public dynamic Data { get; set; }
        public string Messsage { get; set; }
    }
}
