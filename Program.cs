using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject
{
   public class Product
    {
        Dictionary<string, double> products;
        public Product(Dictionary<string, double> products)
        {
            this.products = products;
        }

        public string GetProductInfo(string productName, double productPrice)
        {
            Double productAmmount = 0;
            var outString = string.Empty;
            if (products.TryGetValue(productName.ToLower().Trim(), out productAmmount))
            {
                if (productPrice <= productAmmount)
                {
                    outString= "Thank You";
                }
                else
                {
                    Console.WriteLine("Product Name : {0}, Product Price: {1}", productName, productPrice);

                }
            }
            return outString;
        }

        public string ResetProductVendingMachine(double CurrentAmmount)
        {
           return "Insert Coin and Current Ammount is "+ CurrentAmmount.ToString();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vending Machine is working");
            Dictionary<string, double> products = new Dictionary<string, double>();
            products.Add("cola", 1.0);
            products.Add("chips", 0.50);
            products.Add("candy", 0.65);
            Console.WriteLine("Enter Product");
            var productName = Console.ReadLine();
            Console.WriteLine("Insert Coin");
            var productAmmount = Convert.ToDouble(Console.ReadLine());
            Product objProduct = new Product(products);
            var outMsg= objProduct.GetProductInfo(productName, productAmmount);
            if (string.IsNullOrEmpty(outMsg))
            {
                Console.WriteLine("Product Name : {0}, Product Price: {1}", productName, productAmmount);
                Console.WriteLine(objProduct.ResetProductVendingMachine(productAmmount));
            }
            else
            {
                Console.WriteLine(outMsg);
                Console.WriteLine(objProduct.ResetProductVendingMachine(0.0));
            }
            Console.ReadLine();
        }
    }
}
