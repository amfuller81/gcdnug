using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetApp
{
    /// <summary>
    /// Gets the string to ouput
    /// </summary>
    public static class StringOut
    {
        public static string GetOutput()
        {
            var ouput = GetGreeting();
            return ouput;
        }

        private static string GetGreeting()
        {
            var s = "Hello, ".ToUpper();           
            return s.GetAudience().GetPunctuation();
        }

        private static string GetAudience(this string s)
        {
            s += "GCDNUG";
            return s;
        }

        private static string GetPunctuation(this string s)
        {
            s += "!";
            return s;
        } 
    }
}
