using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC4_mobile
{
    internal class Patterns
    {
        public static string regexrule = "^([9][1])[ ]?([7-9][0-9]{9})$";
        public bool Stringvalid(string lastname)
        {
            return Regex.IsMatch(lastname, regexrule);

        }
    }
}
