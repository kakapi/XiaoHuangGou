using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHG.Domain.Order
{
   public class OrderDetail
    {
       public Guid DetailId { get; set; }
       public Order Order { get; set; }
       public Product.Product Product { get; set; }
       public decimal Quantity { get; set; }
       /// <summary>
       /// 下单价格
       /// </summary>
       public decimal OrderPrice { get; set; }
    }
}
