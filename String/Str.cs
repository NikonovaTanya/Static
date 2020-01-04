using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    public static class Str
    {  public static string SubString(this string str, int j, int n)
        { string s = "";
            for (int i = j; i <= n;i++)
            { s += str[i];
            }
            return s;
        }
        public static string SubString(this string str, int j)
        {
            string s = "";
            for (int i = j; i <str.Length; i++)
            {
                s += str[i];
            }
            return s;
        }
        public static int IndexOfNew(this string str, string str1)
        {
            int index = -1;
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str1[j] && j<str1.Length)
                {  j++;
                }
                if (str1.Length == j)
                    return index = i -(j - 1);
                        
            }
            return index;
        }
        public static string ReplaceNew(this string sstr, string searchstr, string rstr)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < sstr.Length; i++)
            {
                if (isSubstr(sstr, i, searchstr))
                {
                    builder.Append(rstr);
                    i += searchstr.Length - 1;
                }
                else builder.Append(sstr[i]);
            }
            return builder.ToString();
        }

        private static bool isSubstr(string s, int j, string sstr)
        {
            for (int i = 0; i < sstr.Length; i++)
            { if (j < s.Length - 1)
                {
                    if (sstr[i] != s[j + i])
                        return false;
                }
                else return false;
            }
            return true;
        }
    }
}
