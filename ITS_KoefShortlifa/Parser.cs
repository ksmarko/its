using System;

namespace ITS_KoefShortlifa
{
    class Parser
    {
        public static double Parse(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            var number = Double.TryParse(text, out var result);

            if (number)
                return result;

            return 0;
        }
    }
}
