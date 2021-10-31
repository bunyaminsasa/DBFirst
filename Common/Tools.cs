using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleHouse.Common
{
    public class Tools
    {
        public static string UrlConverter(string _text)
        {
            return _text.ToLower().Replace(" ", "-").Replace("ç", "c").Replace("ü", "u").Replace("ı", "i").Replace("ö", "o").Replace("ğ", "g").Replace("ş", "s");
        }
    }
}
