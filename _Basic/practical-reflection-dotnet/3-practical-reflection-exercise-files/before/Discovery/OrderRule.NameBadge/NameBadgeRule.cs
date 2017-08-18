using OrderRules.Interface;
using OrderTaker.SharedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRule.NameBadge
{
    public class NameBadgeRule : IOrderRule
    {
        public string RuleName
        {
            get { return "Name Badge Rule"; }
        }

        public OrderRuleResult CheckRule(Order order)
        {
            var passed = true;
            var message = string.Empty;

            foreach (var item in order.OrderItems)
                if (item.ProductItem.ProductName.Contains("Name Badge") &&
                    !item.ProductItem.ProductName.Contains(order.Customer.FirstName))
                {
                    passed = false;
                    message = string.Format("Customer Name ({0}) does not match Name Badge",
                                            order.Customer.FirstName);
                }

            return new OrderRuleResult(passed, message);
        }
    }
}
