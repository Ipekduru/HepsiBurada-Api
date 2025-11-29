using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Application.Exceptions
{
    // HATA MESAJLARI HEP BU KISIMDA DÖNSÜN 
    public class ExceptinModel:ErrorStatusCode
    {
        // gelen errorslar bu kısımda deserilaze edilir 
        public IEnumerable<string> Errors { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    // singleresponsibilitye uyması açısından bu şekilde ayrıldı 
    public class ErrorStatusCode
    {
        public int StatusCode { get;set;}
    }
}
