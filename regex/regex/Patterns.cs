using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regex
{
    class Patterns
    {
        public static string RegexRules = "^[A-Z][a-z]{3,}$";
        //^[1-9][0-9]{2}[ ]?[0-9]{3}$
        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }
    }
    //name-^[A-Z][a-z]{3,}$
    


}
