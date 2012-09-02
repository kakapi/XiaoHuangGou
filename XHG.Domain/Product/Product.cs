using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHG.Domain.Product
{
    /// <summary>
    /// 产品信息
    /// </summary>
    public class Product
    {
        public virtual Guid ProductId { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 产品描述
        /// </summary>
        public string Description { get; set; }

    }
}
