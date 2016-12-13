using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace CustomDynamic
{
    public class HtmlElement : DynamicObject, IDictionary<string, object>
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


        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            if (binder.Name == "Render")
            {
                result = ToString();
                return true;
            }

            result = null;
            return false;
        }


        //public string Render()
        //{
        //    return "xyz";
        //}


        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _attributes.Keys.ToArray();
        }


        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return _attributes.GetEnumerator();
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(KeyValuePair<string, object> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<string, object> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<string, object> item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
        public bool ContainsKey(string key)
        {
            throw new NotImplementedException();
        }

        public void Add(string key, object value)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(string key, out object value)
        {
            throw new NotImplementedException();
        }

        public object this[string key]
        {
            get { return _attributes[key]; }
            set { _attributes[key] = value; }
        }

        public ICollection<string> Keys { get; }
        public ICollection<object> Values { get; }
    }    
}