using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw4_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_2.Tests
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void PalindromeJudge_Input_12321_Out_True()
        {
            string input = "12321";
            var actual = Palindrome.PalindromeJudge(input);
            var expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PalindromeJudge_Input_3443_Out_True()
        {
            string input = "3443";
            var actual = Palindrome.PalindromeJudge(input);
            var expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PalindromeJudge_Input_12345_Out_False()
        {
            string input = "12345";
            var actual = Palindrome.PalindromeJudge(input);
            var expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}