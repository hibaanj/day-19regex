using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Uc9_email
{
    internal class Pattern
    {
        public static string RegexRule = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public bool Stringvalid(string lastname)
        {
            return Regex.IsMatch(lastname, RegexRule);

        }
    }
}
