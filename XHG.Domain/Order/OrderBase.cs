using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHG.Domain.Order
{
    /// <summary>
    /// 套餐订单
    /// </summary>
    public class SuitOrder : Order
    {
        public int Type1Count { get; set; }
        public int Type2Count { get; set; }
        public bool IsFreezed { get; set; }
        public DateTime UnfreezeTime { get; set; }
    }
}
