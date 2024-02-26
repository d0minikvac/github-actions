using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_modifier
{
    public class StringModifier
    {
        public string CutFirstLetter(string input)
        {
            string newString = "";
            for (int i = 1; i < input.Length; i++)
            {
                newString += input[i];
            }
            return newString;
        }

        public string CutLastLetter(string input)
        {
            string newString = "";
            for (int i = 0; i < input.Length-1; i++)
            {
                newString += input[i];
            }
            return newString;
        }
    }
}
