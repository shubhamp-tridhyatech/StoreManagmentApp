using Microsoft.AspNetCore.Mvc;
using StoreApp.Models.VMModels;
using StoreApp.Models.Model;
using StoreApp.Repository.Services.IRepository;
using static StoreApp.Models.Helper.Enums;

namespace StoreApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : BaseController
    {
        public CountryController(IUnitOfWork iUnitOfWork) : base(iUnitOfWork)
        {
        }
        [HttpPost("[action]")]
        public POSResponseModel GetCountryList(VMPaginationModel vMPaginationModel)
        {
            POSResponseModel posResponseModel = new POSResponseModel();
            try
            {
                // _iUnitOfWork._context
                IEnumerable<Country> countryList = _iUnitOfWork.Country.GetAll();
                var list = _iUnitOfWork.Country.FetchCountrys(vMPaginationModel.PageNumber, vMPaginationModel.PageSize, null, null);

                return this.GenerateResponse(true, list, ResponseStatusCode.SuccessFully, null);
            }
            catch (Exception ex)
            {
                return this.GenerateResponse(false, ex, ResponseStatusCode.ServerError, null);
            }
        }
    }
}
