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
            return String.Join("-", ToUpperFirstThenToLowerAndRepeat(input));
        }

        private IEnumerable<String> ToUpperFirstThenToLowerAndRepeat(string input)
        {
            for (int count = 0; count < input.Length; count++)
            {
                yield return ToUpper(input[count]) + RepeatChar(count, ToLoAwer(input[count]));
            }

        }

        private char ToLoAwer(char @char)
        {
            return char.ToLower(@char);
        }

        private char ToUpper(char @char)
        {
            return char.ToUpper(@char);
        }

        private string RepeatChar(int count, char @char)
        {
            return string.Concat(Enumerable.Repeat(@char, count).ToArray());
        }

    }
}
