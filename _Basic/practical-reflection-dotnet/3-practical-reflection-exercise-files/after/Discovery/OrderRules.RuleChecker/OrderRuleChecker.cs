using OrderRules.Interface;
using OrderTaker.SharedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRules.RuleChecker
{
    public class OrderRuleChecker
    {
        private List<DynamicOrderRule> orderRules;
        public List<DynamicOrderRule> BrokenRules { get; private set; }

        public OrderRuleChecker(string rulePath)
        {
            orderRules = DynamicOrderRuleLoader.LoadRules(rulePath);
        }

        public bool CheckRules(Order order)
        {
            BrokenRules = new List<DynamicOrderRule>();
            foreach (var rule in orderRules)
            {
                var result = rule.OrderRule.CheckRule(order);
                if (!result.Result)
                {
                    rule.Message = result.Message;
                    BrokenRules.Add(rule);
                }
            }
            return BrokenRules.Count == 0;
        }
    }
}
