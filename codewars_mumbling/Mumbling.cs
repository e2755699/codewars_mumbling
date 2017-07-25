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

        private List<String> ToUpperFirstThenToLowerAndRepeat(string input)
        {
            List<String> output = new List<string>();
            for (int count = 0; count < input.Length; count++)
            {
                string upperChar = input[count].ToString().ToUpper();

                var subOutput = upperChar + toLowerAndRepeatChar(count, upperChar);

                output.Add(subOutput);
            }

            return output;
        }

        private string toLowerAndRepeatChar(int count, string @char)
        {
            return RepeatChar(count, @char.ToLower());
        }

        private static string RepeatChar(int count, string @char)
        {
            var subOutput = string.Empty;
 
            for (int i = 0; i < count; i++)
            {
                subOutput = string.Concat(subOutput, @char);
            }
            return subOutput;
        }
    }
}
