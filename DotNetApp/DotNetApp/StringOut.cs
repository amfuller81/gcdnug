namespace DotNetApp
{
    /// <summary>
    /// Gets the string to ouput
    /// </summary>
    public static class StringOut
    {
        public static string GetOutput()
        {
            return GetGreeting();
            
        }

        private static string GetGreeting()
        {
            return "Hello, ".GetAudience();
        }

        private static string GetAudience(this string s)
        {
            
            return s += "Gulf Coast .NET User Group".GetPunctuation();
        }

        private static string GetPunctuation(this string s)
        {        
            return s += "!";
        } 
    }
}
