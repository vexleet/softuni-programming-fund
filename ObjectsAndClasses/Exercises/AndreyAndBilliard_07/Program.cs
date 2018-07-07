using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AndreyAndBilliard_07
{
    class Customer
    {
        public string Name;
        public Dictionary<string, decimal> ShoppingList;
        public decimal Bill;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var shopItems = new Dictionary<string, decimal>();
            int amountOfEntities = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfEntities; i++)
            {
                var currentItem = Console.ReadLine().Split('-').ToArray();
                string entity = currentItem[0];
                decimal price = decimal.Parse(currentItem[1]);

                if (!shopItems.ContainsKey(entity))
                {
                    shopItems.Add(entity, price);
                }
                shopItems[entity] = price;
                
            }

            string[] inputOfCustomers = Console.ReadLine().Split('-').ToArray();
            List<Customer> allCustomers = new List<Customer>();

            while (inputOfCustomers[0] != "end of clients")
            {
                Customer customer = new Customer();
                string[] aboutItem = inputOfCustomers[1].Split(',');
                string customerName = inputOfCustomers[0];
                string product = aboutItem[0];
                int quantity = int.Parse(aboutItem[1]);
                if (shopItems.ContainsKey(product))
                {
                    customer.Name = customerName;
                    customer.ShoppingList = new Dictionary<string, decimal>();
                    customer.ShoppingList.Add(product, quantity);
                    customer.Bill = customer.ShoppingList[product] * shopItems[product];

                    if (allCustomers.Any(x => x.Name == customerName))
                    {
                        Customer existingCustomer = allCustomers.First(c => c.Name == customerName);
                        
                        if (existingCustomer.ShoppingList.ContainsKey(product))
                        {
                            existingCustomer.ShoppingList[product] += quantity;
                            existingCustomer.Bill += quantity * shopItems[product];
                        }
                        else
                        {
                            existingCustomer.ShoppingList[product] = quantity;
                            existingCustomer.Bill += existingCustomer.ShoppingList[product] * shopItems[product];
                        }
                    }
                    else
                    {
                        allCustomers.Add(customer);
                    }
                }
                inputOfCustomers = Console.ReadLine().Split('-').ToArray();
            }


            foreach (var item in allCustomers.OrderBy(x => x.Name).ThenBy(x => x.Bill))
            {
                Console.WriteLine(item.Name);
                foreach (var shop in item.ShoppingList)
                {
                    Console.WriteLine($"-- {shop.Key} - {shop.Value}");
                }
                Console.WriteLine($"Bill: {item.Bill:f2}");
            }
            
            Console.WriteLine($"Total bill: {allCustomers.Sum(x => x.Bill):f2}");
            
        }
    }
}
