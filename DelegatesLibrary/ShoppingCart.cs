using System.Collections.Generic;
using System.Linq;

namespace DelegatesLibrary
{
    public class ShoppingCart
    {
        public List<Product> Items { get; set; } = new List<Product>();
        public delegate void MentionDiscount(decimal baseSum);
        public decimal GetSumWithDiscount(MentionDiscount mentionDiscount)
        {
            decimal rawTotal = Items.Sum(i => i.Price);
            mentionDiscount(rawTotal);

            if (rawTotal > 100)
            {
                rawTotal *= 0.80M;
            }
            else if(rawTotal > 50)
            {
                rawTotal *= 0.85M;
            }
            else if(rawTotal>10)
            {
                rawTotal *= 0.90M;
            }
            return rawTotal;
        }
    }
}
