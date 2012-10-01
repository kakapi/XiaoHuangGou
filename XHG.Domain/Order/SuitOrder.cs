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
        public int MeatCount { get; set; }
        public int VegeTableCoount { get; set; }
        public DayOfWeek DistributinonTime { get; set; }

    }
}
