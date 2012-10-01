using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XHG.IRepository;
namespace XHG.Domain
{
   public class DomainBase<T>:IRepository<T>
    {
      
       public IRepository<T> Reposi
       {
           get;
           set;
       }
    }
}
