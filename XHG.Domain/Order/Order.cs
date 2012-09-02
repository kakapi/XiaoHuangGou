using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XHG.Domain.Member;
namespace XHG.Domain.Order
{
    /// <summary>
    /// 订单类.
    /// </summary>
 public  class Order
    {
     public Guid OrderId { get; set; }
     public Member.Member Member { get; set; }
     public List<OrderDetail> Details { get; set; }
     /// <summary>
     /// 下单总价
     /// </summary>
     public decimal TotalPrice {
         get {
             decimal amount = 0;
             foreach (OrderDetail detail in Details)
             {
                 amount += detail.OrderPrice;
             }
             return amount;
         }
     }
    }
}
