using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesTaxes.Business.ShoppingCart
{
    public class ShoppingCart
    {

        private readonly IList<Entities.Item> items = new List<Entities.Item>();

        public void AddItem(Entities.Item item)
        {
            if(item != null)
            {
                items.Add(item);
            }
        }

        public string PrintResult()
        {
            var result = new StringBuilder();
            decimal total = 0.0m;
            var totalPrice = items.Sum(x => x.Price);
            foreach(var product in items)
            {
                var price = product.GetItemPrice();
                total += price;
                result.AppendLine($"{product.Product.Name}: {price}");
            }
            result.AppendLine($"Sales Taxes: {total - totalPrice}");
            result.AppendLine($"Total: {total}");
            return result.ToString();
        }
    }
}
