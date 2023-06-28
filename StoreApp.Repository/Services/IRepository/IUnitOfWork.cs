using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Repository.Services.IRepository
{
    public interface IUnitOfWork
    {
        ICountryRepository Country { get; }
        void Save();
    }
}
