using Azure;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StoreApp.Data;
using StoreApp.Models.Model;
using StoreApp.Repository.Services.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Repository.Services
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        protected readonly IUnitOfWork _iUnitOfWork;
        public CountryRepository(PointOfSaleContext context) : base(context)
        {
        }

        //public List<Sproc_FetchCountry> FetchCountrys(Country country)
        //{
        //    throw new NotImplementedException();
        //}
        public List<Sproc_FetchCountry> FetchCountrys(int page, int pageSize, string sortBy, string whereClasue)
        {
            var pageVal = new SqlParameter("@page", page);
            var pageSizeVal = new SqlParameter("@size", pageSize);
            var sortByVal = new SqlParameter("@sort", (object)sortBy ?? DBNull.Value);
            var whereClasueVal = new SqlParameter("@whereCluse", (object)whereClasue ?? DBNull.Value);
            return this._context.SprocFetchCountry.FromSqlRaw<Sproc_FetchCountry>("EXEC Sproc_FetchCountry @page, @size, @sort, @whereCluse", pageVal, pageSizeVal, sortByVal, whereClasueVal).ToList();
        }
    }
}
