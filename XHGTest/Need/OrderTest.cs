using System;
using System.Collections.Generic;
using System.Linq;
using XHG.Domain;
using XHG.Domain.Member;
using XHG.Domain.Order;
using System.Text;
using NUnit.Framework;
namespace XHGTest.Need
{
    [TestFixture]
    /// <summary>
    /// 订单
    
    /// case2:会员选择套餐
    /// case3:会员定制套餐(种类,数量)
    /// </summary>
    public class OrderTest
    {
        [Test]
        public void OrderSuitTest()
        { 
           //会员预订一个套餐
            Member member = new Member();
            SuitOrder Suit = new SuitOrder();
            //肉类数量
            Suit.MeatCount = 3;
             //蔬菜数量
            Suit.VegeTableCoount= 5;
           //配送时间
            Suit.DistributinonTime = DayOfWeek.Thursday | DayOfWeek.Saturday;
            //会员
            Suit.Member = member;
            //Asserts
           

        }
    }

}
