using StoreApp.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Repository.Services.IRepository
{
    public interface ICountryRepository : IRepository<Country>
    {
        List<Sproc_FetchCountry> FetchCountrys(int page, int pageSize, string sortBy, string whereClasue);
    }
}
