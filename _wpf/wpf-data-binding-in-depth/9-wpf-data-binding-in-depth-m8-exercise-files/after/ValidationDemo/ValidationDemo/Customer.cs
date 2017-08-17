using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ValidationDemo
{
    public class Customer : EntityBase, INotifyPropertyChanged, INotifyDataErrorInfo//, IDataErrorInfo
    {
        private string _HomePhone;
        [RegularExpression(@"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$")]
        [Required]
        [StringLength(12)]
        public string HomePhone
        {
            get { return _HomePhone; }
            set
            {
                if (_HomePhone != value)
                {
                    //ValidatePhone(value);
                    ValidateProperty("HomePhone", value);
                    _HomePhone = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("HomePhone"));
                }
            }
        }

        private string _WorkPhone = "999-999-9999";
        public string WorkPhone
        {
            get { return _WorkPhone; }
            set
            {
                if (_WorkPhone != value)
                {
                    _WorkPhone = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("WorkPhone"));
                }
            }
        }

        private string _CellPhone;
        public string CellPhone
        {
            get { return _CellPhone; }
            set
            {
                if (_CellPhone != value)
                {
                    _CellPhone = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("CellPhone"));
                    // Trigger async validation check
                    GetErrorsForPhone(CellPhone).ContinueWith((errorsTask) =>
                    {
                        lock (_PropertyErrors)
                        {
                            _PropertyErrors["CellPhone"] = errorsTask.Result;
                            ErrorsChanged(this, new DataErrorsChangedEventArgs("CellPhone"));
                        }
                    });

                }
            }
        }



        private void ValidatePhone(string value)
        {
            if (string.IsNullOrEmpty(value))
                return;
            Regex regex = new Regex(@"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$");
            if (regex.Match(value) == Match.Empty)
                throw new ArgumentException("Invalid phone format");
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        //public string Error
        //{
        //    get { return null; }
        //}

        //public string this[string propertyName]
        //{
        //    get { return GetErrorForProperty(propertyName); }
        //}
        //private string GetErrorForProperty(string propertyName)
        //{
        //    switch (propertyName)
        //    {
        //        case "CellPhone":
        //           Regex regex = new Regex(@"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$");
        //           if (regex.Match(CellPhone) == Match.Empty)
        //               return "Invalid phone format";
        //           else return string.Empty;
        //        default:
        //            return string.Empty;
        //    }
        //}

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged = delegate { };

        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            lock (_PropertyErrors)
            {
                if (_PropertyErrors.ContainsKey(propertyName))
                    return _PropertyErrors[propertyName];
            }
            return null;
        }

        public bool HasErrors
        {
            get { return PropertyErrorsPresent(); }
        }

        Dictionary<string, List<string>> _PropertyErrors = new Dictionary<string, List<string>>();

        Task<List<string>> GetErrorsForPhone(string value)
        {
            // Simulate async call - typically to a web service
            return Task.Factory.StartNew<List<string>>(() =>
            {
                Thread.Sleep(5000);
                Regex regex = new Regex(@"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$");
                if (regex.Match(value) == Match.Empty)
                    return new List<string> { "Invalid phone format" };
                return null;
            });
        }

        private bool PropertyErrorsPresent()
        {
            bool errors = false;
            foreach (var key in _PropertyErrors.Keys)
            {
                if (_PropertyErrors[key] != null)
                {
                    errors = true;
                    break;
                }
            }
            return errors;
        }
    }
}
