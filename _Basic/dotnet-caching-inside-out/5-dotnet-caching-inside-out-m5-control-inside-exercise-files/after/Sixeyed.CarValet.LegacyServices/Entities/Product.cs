using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Sixeyed.CarValet.LegacyServices.Entities
{
    public class Product
    {
        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        [XmlIgnore]
        public Decimal BasePrice { get; set; }

        public static IEnumerable<Product> Defaults
        {
            get
            {
                return new Product[] {
                    new Product() { ProductCode="1S", ProductName="Silver", BasePrice=15},
                    new Product() { ProductCode="2G", ProductName="Gold", BasePrice=25},
                    new Product() { ProductCode="3P", ProductName="Platinum", BasePrice=40},
                };
            }
        }
    }
}