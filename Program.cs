using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject
{

    public class Coinis 
    {
        string coinType;
        double coinAmmount;
        double totalAmmount;

      public Coinis(string CoinType, double CoinAmmount, double totalAmmount)
        {
            this.coinType = CoinType;
            this.coinAmmount = CoinAmmount;
            this.totalAmmount = totalAmmount;
        }

        public bool ValidateCoins(string coinType)
        {
            if (string.IsNullOrEmpty(coinType))
            {
                return false;
            }
         
            return true;
        }

        public bool ValidateCoinsAmmount(string coinType, double coinAmmount)
        {
            if (!string.IsNullOrEmpty(coinType) && coinAmmount==0.01)
            {
                return false;
            }

            return true;
        }

        public string InsertValidCoinAndUpdateAmmount(string coinType, double coinAmmount)
        {
            string finalAmmount = string.Empty;
            if (!string.IsNullOrEmpty(coinType))
            {
                totalAmmount = totalAmmount + coinAmmount;
                finalAmmount= "Updated Ammount= " + totalAmmount;
            }
            return finalAmmount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double coinAmmount = 0.0;
            Console.WriteLine("Vending Machine is working");
            Console.WriteLine("Enter Total Ammount");
            double totalAmmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Coin Type");
            string coinType = Console.ReadLine();
            Console.WriteLine("Enter Coin Ammount");
            string coinAmmountStr = Console.ReadLine();
            if (!string.IsNullOrEmpty(coinAmmountStr))
            coinAmmount = Convert.ToDouble(coinAmmount);

            Coinis objCoinis = new Coinis(coinType, coinAmmount, totalAmmount);
            if (objCoinis.ValidateCoins(coinType))
                Console.WriteLine("Please Insert Coin");
            else if (objCoinis.ValidateCoinsAmmount(coinType, coinAmmount))
            {
                Console.WriteLine("Coins Rejected due to invalid ammount");
            }
            else 
            {
                Console.WriteLine(objCoinis.InsertValidCoinAndUpdateAmmount(coinType, coinAmmount));
            }
        }
    }
}
