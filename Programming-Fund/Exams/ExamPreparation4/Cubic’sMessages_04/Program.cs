using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Cubic_sMessages_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 1;
            string pattern = @"^([\d]+)([A-Za-z]+)([^A-Za-z\n]*)$";
            var decryptedMessages = new Dictionary<string, string>();

            while (input != "Over!")
            {
                int nChars = int.Parse(Console.ReadLine());
                Regex regex = new Regex(pattern);

                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string message = match.Groups[2].Value;
                    char[] digits = (match.Groups[1].Value + match.Groups[3].Value).ToCharArray();
                    string verificationCode = "";

                    if (message.Length == nChars)
                    {
                        for (int i = 0; i < digits.Length; i++)
                        {
                            if (int.TryParse(digits[i].ToString(), out int result))
                            {
                                try
                                {
                                    verificationCode += message[result];
                                }
                                catch
                                {
                                    verificationCode += " ";
                                }
                            }
                            else
                            {
                                verificationCode += " ";
                            }
                        }

                        decryptedMessages.Add(message, verificationCode);
                    }

                }
                input = Console.ReadLine();
                counter++;
            }

            foreach (var item in decryptedMessages)
            {
                Console.WriteLine($"{item.Key} == {item.Value}");
            }
        }
    }
}