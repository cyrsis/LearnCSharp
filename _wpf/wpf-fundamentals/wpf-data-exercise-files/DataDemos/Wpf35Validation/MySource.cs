using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Wpf35Validation
{
    public class MySource : IDataErrorInfo
    {
        public string Name { get; set; }
        public double Age { get; set; }



        #region IDataErrorInfo Members

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "Age":
                        if (Name == "Ian" && Age < 34)
                        {
                            return "Yeah, and the rest";
                        }
                        break;


                    case "Name":
                        break;


                    default:
                        throw new ArgumentException("Unknown property: " + columnName, "columnName");
                }

                return "";
            }
        }

        #endregion
    }
}
