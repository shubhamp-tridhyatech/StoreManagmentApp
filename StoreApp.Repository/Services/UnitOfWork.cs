using Microsoft.EntityFrameworkCore;
using StoreApp.Data;
using StoreApp.Repository.Services.IRepository;
using System.Linq.Expressions;

namespace StoreApp.Repository.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        public PointOfSaleContext _context;
        public ICountryRepository Country { get; private set; }

        public UnitOfWork(PointOfSaleContext context)
        {
            _context = context;
            Country = new CountryRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
