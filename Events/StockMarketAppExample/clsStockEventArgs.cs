using System;

namespace StockMarketAppExample
{
    public class clsStockEventArgs : EventArgs
    {
        public decimal OldPrice { get; }
        public clsStock Stock { get; }

        public clsStockEventArgs(clsStock stock, decimal oldPrice)
        {
            Stock = stock;
            OldPrice = oldPrice;
        }
    }
}
