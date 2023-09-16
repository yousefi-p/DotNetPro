using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public static class Helper
    {
        public static bool NumericCheck(string str)
        {
            if (!string.IsNullOrEmpty(str) || !string.IsNullOrWhiteSpace(str))
            {
                foreach (char c in str)
                {
                    if (Char.IsLetter(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }


        public static bool AlphaCheck(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                foreach (char c in str)
                {
                    if (Char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }


        public static bool AlphaNumericCheck(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                foreach (char c in str)
                {
                    if (Char.IsLetterOrDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public static bool YearCheck(string str)
        {
            if (!string.IsNullOrEmpty(str) && str.Length == 4)
            {
                if ( NumericCheck(str))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
