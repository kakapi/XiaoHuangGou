using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHG.Domain.Product
{
    /// <summary>
    /// 产品价格信息
    /// </summary>
    public class Product
    {
        public virtual Guid PriceId { get; set; }
        public PriceType PriceType { get; set; }
        /// <summary>
        /// 价格数值
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 价格单位:个/箱/斤/公斤/等
        /// </summary>
        public string Unit { get; set; }
    }
}
