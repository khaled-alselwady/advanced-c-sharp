using System;

namespace StockMarketAppExample
{
    public class clsStock
    {
        private string _name;
        private decimal _price;

        public string Name => _name;
        public decimal Price { get => _price; set => _price = value; }

        public event EventHandler<clsStockEventArgs> OnStockChanged;

        public clsStock(string stockName)
        {
            _name = stockName;
        }

        public void ChangeStockPriceBy(decimal percent)
        {
            decimal oldPrice = _price;
            _price += Math.Round(_price * percent, 2);

            OnStockChanged?.Invoke(this, new clsStockEventArgs(this, oldPrice));
        }

        public override string ToString()
        {
            return $"{_name}: {_price}";
        }
    }
}
