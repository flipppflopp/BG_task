using Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interaces
{
    interface ICurrencyRepository
    {
        public Task<List<Currency>> GetTop10Currencies();

        public Task<Currency> GetCurrencyByID(string id);
    }
}
