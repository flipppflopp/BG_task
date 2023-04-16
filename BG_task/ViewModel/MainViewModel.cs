using Newtonsoft.Json.Linq;
using Services.Model;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Security.Permissions;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BG_task
{
    public class MainViewModel
    {
        CurrencyService currencyService;

        public ObservableCollection<Currency> TopTenObjects { get; set; }

        public MainViewModel()
        {
            currencyService = new CurrencyService();

            TopTenObjects = new ObservableCollection<Currency>();

            SetTenObjects();
        }

        public async void SetTenObjects()
        {
            foreach(var item in currencyService.GetTop10Currencies().Result) 
            {
                TopTenObjects.Add(item);
            }
        }
    }
}
