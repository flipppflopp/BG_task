using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Services.Interaces;
using Services.Model;

namespace Services.Services
{
    public class CurrencyService : ICurrencyRepository
    {
        public async Task<Currency> GetCurrencyByID(string id)
        {
            Currency result = new Currency();

            return result;
        }

        public async Task<List<Currency>> GetTop10Currencies()
        {
            var client = new HttpClient();

            var response = await client.GetAsync("https://api.coincap.io/v2/assets");

            client.Dispose();

            string dataStr = response.Content.ReadAsStringAsync().Result;

            Response data = JsonSerializer.Deserialize<Response>(dataStr);

            return data.data.ToList<Currency>();
        }
    }
}
