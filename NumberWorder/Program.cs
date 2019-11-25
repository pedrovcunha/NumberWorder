using System;
using System.ComponentModel;

namespace NumberWorder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var numberToConvert = Console.ReadLine();

            var output = ConverterHelper.ConvertNumberToWord(numberToConvert);

            Console.WriteLine($"{output}");
            Console.ReadKey();
        }

        
        public enum Numbers
        {
            [Description("Zero")]
           Zero,
           [Description("One")]
            One,
            [Description("Two")]
            Two,
            [Description("Three")]
            Three,
            [Description("Four")]
            Four,
            [Description("Five")]
            Five,
            [Description("Six")]
            Six,
            [Description("Seven")]
            Seven,
            [Description("Eight")]
            Eight,
            [Description("Nine")]
            Nine
        }

    }

    

}


