using System;

namespace StockMarketAppExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsStock stock = new clsStock("Amazon");
            stock.Price = 100;
            stock.OnStockChanged += Stock_OnStockChanged;

            stock.ChangeStockPriceBy(0.05M);
            stock.ChangeStockPriceBy(-0.02M);
            stock.ChangeStockPriceBy(0.00M);

            Console.ReadKey();
        }

        private static void Stock_OnStockChanged(object sender, clsStockEventArgs e)
        {
            //if (!(sender is clsStock))
            //    return;

            //clsStock stock = (clsStock)sender;

            //if (stock.Price > e?.OldPrice)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //}
            //else if (stock.Price < e?.OldPrice)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Gray;
            //}

            if (e?.Stock?.Price > e?.OldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (e?.Stock?.Price < e?.OldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine(e?.Stock);
        }
    }
}
