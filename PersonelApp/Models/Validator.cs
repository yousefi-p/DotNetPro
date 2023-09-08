using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Models
{
    internal class Validator
    {
        public static bool CheckIsAlphabet(string str)
        {
            for (int c = 0; c <= str.Length; c++)
            {
                if (char.IsDigit(str[c]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsNumber(string str)
        {
            for (int c = 0; c <= str.Length; c++)
            {
                if (char.IsLetter(str[c]))
                {
                    return false;
                }
            }
            return true;
        }

        public static string CellPhoneValidating(string str)
        {
            if (str.Length == 11 && str.Substring(0, 2).Equals("09"))
            {
                return str;

            }
            if (str.Length == 13 && str.Substring(0, 3).Equals("+98"))
            {
                return '0' + str.Substring(3);
            }
            else if (str.Length == 14 && str.Substring(0, 4).Equals("0098"))
            {
                return str.Replace("0098", "0");
            }
            else
            {
                return "Worng Number";
            }
        }

        public static bool IsCellPhone(string str)
        {
            if (IsNumber(str) && str.Length > 10 && str.Length < 15)
            {
                return true;
            }
            return false;
        }

        public static bool NationalIdChecked(string str)
        {
            if (str.Length < 10 && IsNumber(str))
            {
                return true;
            }
            return false;
        }

        public static string PersianToEnglish(string persianStr)
        {
            Dictionary<char, char> LettersDictionary = new Dictionary<char, char>
            {
                ['۰'] = '0',
                ['۱'] = '1',
                ['۲'] = '2',
                ['۳'] = '3',
                ['۴'] = '4',
                ['۵'] = '5',
                ['۶'] = '6',
                ['۷'] = '7',
                ['۸'] = '8',
                ['۹'] = '9'
            };
            foreach (var item in persianStr)
            {
                persianStr = persianStr.Replace(item, LettersDictionary[item]);
            }
            return persianStr;
        }
    }
}
