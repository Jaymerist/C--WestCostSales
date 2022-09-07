/*
purpose: Find # of sales
author: Mihiri Kamiss
date: September 7, 2022
*/
namespace WestCostSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables and constants
            const double Percentage = 0.43; //const is short for constant
            double total = 5300000,
                   sales;

            // calculate 43% of total sales
            sales = Percentage * total;

            // display results
            Console.WriteLine($"The company earned {sales:c} on {total:c} sales"); //c stands for currency formatting 
        }
    }
}