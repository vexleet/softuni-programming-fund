using System;

namespace Lab
{
    class Program
    {
        static void receiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 30));
        }

        static void receiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void receiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        static void printReceipt()
        {
            receiptHeader();
            receiptBody();
            receiptFooter();
        }

        static void Main(string[] args)
        {
            printReceipt();
        }

        
    }
}
