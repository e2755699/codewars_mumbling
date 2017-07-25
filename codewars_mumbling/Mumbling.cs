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

            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            var output = new List<string>();
            var count = 0;

            foreach (char aChar in input)
            {
                string upperChar = aChar.ToString().ToUpper();
                var subOutput = upperChar;
                
                for (int i = 0; i < count; i++)
                {
                    string lowerChar = upperChar.ToLower();
                    subOutput = subOutput + lowerChar;
                }

                count++;

                output.Add(subOutput);
            }

            return String.Join("-", output);

        }
    }
}
