using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CarBook.Application.Tools
{
    public class JwtTokenDefaults
    {
        public const string ValidAuidience= "https://localhost";
        public const string ValidIssuer = "https://localhost";
        public const string Key = "carbookcarbook01+=projeCarBookKeyCarBook";
        public const int Expire = 3;

    }
}
