using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            int param1 = 5;
            int param2 = 10;
            int paramSum;

            paramSum = SumMethod(param1, param2);

            Console.WriteLine(paramSum.ToString());
            

            Product prod1 = new Product();
            prod1.SetCost(500);
            prod1.SetProductID(123);

            Product prod2 = new Product();
            prod2.SetCost(900);
            prod2.SetProductID(432);

            double totalCost = Product.GetTotalCost(prod1, prod2);

            Console.WriteLine("ProductID:   " + prod1.GetProductID());
            Console.WriteLine("ProductID:   " + prod1.GetCost());
            Console.WriteLine("Product Cost:   " + prod2.GetProductID());
            Console.WriteLine("Product Cost:   " + prod2.GetCost());

            Product.SetTotalNoProducts(5000);
            Console.WriteLine("Total No of Products:   " + Product.GetTotalNoProducts());
            Console.WriteLine("Total Cost:   " + totalCost);


            Console.ReadKey();
        }

        public static int SumMethod (int a, int b)
        {
            int c = a + b;
            return c;
        }
    }

    public class Product
    {
        //fields
        private int ProductID;
        private double Cost;
        public static int TotalNoProducts;

        //constructor
        public Product()
        {
            //dateOfPurchase = DateTime.Now.ToShortDateString();
        }

        public void SetProductID(int productID)
        {
            ProductID = productID;
        }

        public int GetProductID()
        {
            return ProductID;
        }
        public void SetCost(int cost)
        {
            Cost = cost;
        }

        public double GetCost()
        {
            return Cost;
        }

        public static void SetTotalNoProducts(int value)
        {
            TotalNoProducts = value;
        }
        public static int GetTotalNoProducts()
        {
            return TotalNoProducts;
        }

        public static double GetTotalCost(Product a, Product b)
        {
            return (a.GetCost() + b.GetCost());
        }


    }
}
