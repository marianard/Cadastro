using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cadastro.Helpers
{
    class TelephoneHelper
    {
        const string TelephoneRegex = @"^\(\d{2}\)\ \d{5}\-\d{4}$";

        public static bool IsValid(string telephone)
        {
            var regex = new Regex(TelephoneRegex);
            var math = regex.Match(telephone);
            return math.Success;
        }
    }
}
