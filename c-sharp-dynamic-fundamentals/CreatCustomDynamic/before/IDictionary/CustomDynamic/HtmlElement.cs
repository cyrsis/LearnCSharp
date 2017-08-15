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
            return _attributes.TryGetValue(binder.Name, out result);
        }


        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _attributes.Keys.ToArray();
        }


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"<{TagName} ");

            foreach (KeyValuePair<string, object> attribute in _attributes)
            {
                sb.Append($"{attribute.Key}='{attribute.Value}' ");
            }

            sb.Append("/>");

            return sb.ToString();
        }
    }    
}