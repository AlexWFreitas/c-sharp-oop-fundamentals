using System;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts space before each Capital letter in a string
        /// </summary>
        /// <param name="source">Passed string</param>
        /// <returns>Handled string</returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
