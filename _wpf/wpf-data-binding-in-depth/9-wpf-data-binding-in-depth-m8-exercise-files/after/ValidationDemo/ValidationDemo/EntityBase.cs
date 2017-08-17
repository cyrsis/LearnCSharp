using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDemo
{
    public class EntityBase
    {
        protected virtual void ValidateProperty(string propertyName, object value)
        {
            ValidationContext context = new ValidationContext(this, null, null);
            context.MemberName = propertyName;
            Validator.ValidateProperty(value, context);
        }
    }
}
