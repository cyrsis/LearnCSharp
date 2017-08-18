using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Commerce.Engine.Configuration
{
    public class ModuleElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return (string)base["name"]; }
            set { base["name"] = value; }
        }

        [ConfigurationProperty("type", IsRequired = true, DefaultValue = "")]
        public string Type
        {
            get { return (string)base["type"]; }
            set { base["type"] = value; }
        }
    }
}
