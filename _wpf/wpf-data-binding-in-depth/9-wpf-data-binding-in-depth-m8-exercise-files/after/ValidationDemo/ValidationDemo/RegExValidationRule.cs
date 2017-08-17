using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ValidationDemo
{
    public class RegexValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (Expression == null)
                return ValidationResult.ValidResult;

            Regex m_RegEx = new Regex(Expression);
            Match match = m_RegEx.Match(value.ToString());
            if (match == null || match == Match.Empty)
                return new ValidationResult(false, "Invalid input format");
            else
                return ValidationResult.ValidResult;
        }

        public string Expression { get; set; }

    }
}
