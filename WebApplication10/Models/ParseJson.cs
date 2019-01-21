using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace WebApplication10.Models
{
    public class ParseJson // структура данных Json в представление EF core
    {
        public string disclaimer { get; set; }
        public string licence { get; set; }
        public int timestamp { get; set; }
       // public string base { get; set;}
       public Rates[] rates { get; set; }
                
    }

    public class Rates // структура данных валют
    {
        public float RUB { get; set; }
        public float EUR { get; set; }
        public float JPY { get; set; }
        public float GPG { get; set; }
        
    }
    
    public class Parsejs // парсер данных JSON с гет запроса на сайт через WebClient(реализация через Ajax,JQuery не знакома) 
    {
        public void PasreUrl()
        {
            string url = "https://openexchangerates.org/api/historical/2001-02-16.json?app_id=bcf546b9a0ea43518b0cbcff6a43a1d6";
            var parse = JsonConvert.DeserializeObject<ParseJson>(new WebClient().DownloadString(url));
        }
    }

}
