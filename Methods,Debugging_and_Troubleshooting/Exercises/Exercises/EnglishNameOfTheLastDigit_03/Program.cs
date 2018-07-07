using System;

namespace EnglishNameOfTheLastDigit_03
{
    class Program
    {
        static string DigitToItsName(string num)
        {
            string getLastDigit = num.Substring(num.Length - 1);

            switch (getLastDigit)
            {
                case "0":
                    return "zero";
                case "1":
                    return "one";
                case "2":
                    return "two";                   
                case "3":
                    return "three";                  
                case "4":
                    return "four";              
                case "5":
                    return "five";                   
                case "6":
                    return "six";                   
                case "7":
                    return "seven";                   
                case "8":
                    return "eight";                    
                case "9":
                    return "nine";               
            }
            return "";
        }

        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string result = DigitToItsName(num);
            Console.WriteLine(result);
        }
    }
}
