using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string pattern = @"#[A-Z][a-z]+[.][A-Z][a-z]+";         
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
