using System;
using System.Collections.Generic;
using System.Text;

namespace NumberWorder
{
    public class ConverterHelper
    {
        public static string ConvertNumberToWord(string input)
        {
            StringBuilder outputBuilder = new StringBuilder();
            try
            {
                Convert.ToInt32(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                throw;
            }
            foreach (var newnummber in input)
            {

                var newInput = Convert.ToInt32(newnummber.ToString());
                outputBuilder.Append(((Program.Numbers)newInput).GetDescrition());
            }

            return outputBuilder.ToString();
        }
    }
}
