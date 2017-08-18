using OrderRules.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;

namespace OrderRules.RuleChecker
{
    public static class DynamicOrderRuleLoader
    {
        public static List<DynamicOrderRule> LoadRules(string assemblyPath)
        {
            var rules = new List<DynamicOrderRule>();

            // TODO: Add code to dynamically load rules based on a path.

            return rules;
        }
    }
}
