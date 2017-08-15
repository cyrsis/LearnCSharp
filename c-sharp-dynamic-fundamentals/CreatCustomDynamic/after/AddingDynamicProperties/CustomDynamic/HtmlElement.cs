using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace CustomDynamic
{
    public class HtmlElement : DynamicObject
    {
        private readonly Dictionary<string, object> _attributes =
            new Dictionary<string, object>();

        public string TagName { get; }

        public HtmlElement(string tagName)
        {
            TagName = tagName;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            string attribute = binder.Name;

            _attributes[attribute] = value;

            return true;
        }


        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            string attribute = binder.Name;

            result = _attributes[attribute];

            return true;
        }
    }    
}