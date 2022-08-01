
using regex;

Patterns patterns = new Patterns();
//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
if (patterns.validateString("Hiba"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
Console.ReadKey();
