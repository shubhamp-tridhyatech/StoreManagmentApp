using Microsoft.AspNetCore.Mvc;
using StoreApp.Models.VMModels;
using StoreApp.Repository.Services.IRepository;
using static StoreApp.Models.Helper.Enums;

namespace StoreApp.API.Controllers
{
    public class BaseController : ControllerBase
    {
        protected readonly IUnitOfWork _iUnitOfWork;
        public BaseController(IUnitOfWork iUnitOfWork)
        {
            _iUnitOfWork = iUnitOfWork;
        }
        protected POSResponseModel GenerateResponse(bool isSuccess, dynamic data, ResponseStatusCode statusCode, string message)
        {
            POSResponseModel posResponseModel = new POSResponseModel();
            posResponseModel.Data = data;
            posResponseModel.IsSuccess = isSuccess;
            posResponseModel.SuccessCode = statusCode;
            posResponseModel.Messsage = message;
            return posResponseModel;
        }
    }
}
