using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, List<double>>();
            string inputCommand = Console.ReadLine();

            while (inputCommand!="buy")
            {
                string[] tokans = inputCommand.Split();
                string nameOfProductcts = tokans[0];
                double price = double.Parse(tokans[1]);
                double quontity = double.Parse(tokans[2]);
                var priceAndQuontity = new List<double>();

                if (!products.ContainsKey(nameOfProductcts))
                {
                    priceAndQuontity.Add(price);
                    priceAndQuontity.Add(quontity);
                    products.Add(nameOfProductcts,priceAndQuontity);
                }
                else
                {
                    foreach (var product in products.Where(p=>p.Key==nameOfProductcts))
                    {
                        product.Value[0] = price;
                        product.Value[1]+=quontity;
                       // products[nameOfProductcts][0] = price;
                       // products[nameOfProductcts][1]+=quontity;

                    }
                    
                }
                inputCommand = Console.ReadLine();
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0]*product.Value[1]:f2}");
            }
        }
    }
}
