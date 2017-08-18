using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sixeyed.CarValet.LegacyServices.Entities
{
    public class ProductOption
    {
        public string OptionCode { get; set; }

        public string OptionName { get; set; }

        public static IEnumerable<ProductOption> Defaults
        {
            get
            {
                return new ProductOption[] {
                    new ProductOption() { OptionCode="1WS", OptionName="Wash"},
                    new ProductOption() { OptionCode="1WX", OptionName="Wax"},
                    new ProductOption() { OptionCode="1HV", OptionName="Hoover"},
                    new ProductOption() { OptionCode="1GP", OptionName="Glass Polish"},
                    new ProductOption() { OptionCode="1DI", OptionName="Deodorise Interior"},

                    new ProductOption() { OptionCode="2CC", OptionName="Carpet Clean"},
                    new ProductOption() { OptionCode="2UC", OptionName="Upholstery Clean"},

                    new ProductOption() { OptionCode="3WS", OptionName="Wheel Seal"},
                    new ProductOption() { OptionCode="3DE", OptionName="Degrease Engine Bay"},
                    new ProductOption() { OptionCode="3LC", OptionName="Leather Conditioner"},
                    
                };
            }
        }
    }
}