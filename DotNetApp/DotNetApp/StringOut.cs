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
            var s = "Hello, ";           
            return s.GetAudience();
        }

        private static string GetAudience(this string s)
        {
            s += "Gulf Coast .NET User Group";
            return s.GetPunctuation();
        }

        private static string GetPunctuation(this string s)
        {
            s += "!";
            return s;
        } 
    }
}
