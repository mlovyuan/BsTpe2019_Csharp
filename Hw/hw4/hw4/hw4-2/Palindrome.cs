using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_2
{
    public class Palindrome
    {
        public static bool PalindromeJudge(string input)
        {
            var len = input.Length;
            bool ans;
            if (len % 2 == 0)
            {
                ans = Judge(input, true);
            }
            else
            {
                ans = Judge(input, false);
            }
            return ans;
        }
        private static bool Judge(string input, bool even)
        {
            var len = input.Length;
            var judge = true;
            if (even == true)
            {
                for (int i = 0; i < len; i++)
                {
                    if (input[i] != input[input.Length - i - 1])
                    {
                        judge = false;
                        break;
                    }
                    if (i == len / 2)
                    {
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < len; i++)
                {
                    if (i == len / 2 )
                    {
                        break;
                    }
                    if (input[i] != input[input.Length - i - 1])
                    {
                        judge = false;
                        break;
                    }
                }
            }
            return judge;
        }
    }
}
