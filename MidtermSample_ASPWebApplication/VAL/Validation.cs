using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace MidtermSample_ASPWebApplication.VAL
{
    public static class Validation
    {
        public static bool IsValidId(string input)
        {
            // Empty ID
            if (input.Length == 0)
            {
                return false;
            }
            // If number
            for (int i = 0; i < input.Length; i++)
            {
                if ((Char.IsLetter(input[i])) || (Char.IsWhiteSpace(input[i])))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsValidPassword(string input)
        {
            // Empty Password
            if (input.Length == 0)
            {
                return false;
            }
            return true;
        }
    }
}