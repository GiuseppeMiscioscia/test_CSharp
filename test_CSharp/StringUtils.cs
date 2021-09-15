using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_CSharp
{
    public static class StringUtils
    {
        public static string Reverse(string original)
        {
            string result = "";
            for (int i = original.Length-1; i >= 0; i--)
            {
                char c = original[i];
                result += c;
            }
            return result;
        }
    }
}
