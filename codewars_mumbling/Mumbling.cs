using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars_mumbling
{
    internal class Mumbling
    {
        internal string Accum(string input)
        {
            return string.Join("-", LoopEachCharToGenerateSubString(input));
        }

        private IEnumerable<string> LoopEachCharToGenerateSubString(string input)
        {
            for (int count = 0; count < input.Length; count++)
            {
                yield return string.Concat(ToUpperChar(input[count]), RepeatChar(count, ToLowerChar(input[count])));
            }

        }

        private char ToLowerChar(char @char)
        {
            return char.ToLower(@char);
        }

        private char ToUpperChar(char @char)
        {
            return char.ToUpper(@char);
        }

        private string RepeatChar(int count, char @char)
        {
            return string.Concat(Enumerable.Repeat(@char, count));
        }

    }
}
