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
            return string.Format("{0} {1}{2}", GetGreeting(), GetAudience(), GetPunctuation());
        }

        private static string GetGreeting()
        {
            return "Hello";
        }

        private static string GetAudience()
        {
            return "GCDNUG";
        }

        private static string GetPunctuation()
        {
            return "!";
        } 
    }
}
