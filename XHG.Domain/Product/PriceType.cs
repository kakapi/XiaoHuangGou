using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHG.Domain.Product
{
    /// <summary>
    ///价格类别:零售.会员.会员套餐
    /// </summary>
    public class PriceType
    {
        public virtual Guid TypeId { get; set; }
        public string Name { get; set; }
      
    }
}
