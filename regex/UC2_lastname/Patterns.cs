using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC2_lastname
{
    internal class Patterns
    {
        public static string RegexRule = "^[A-Z][a-z]{3,}$";
        public bool Stringvalid(string lastname)
        {
            return Regex.IsMatch(lastname, RegexRule);

        }
    }
}
