using System;

namespace Common
{
    public class DataNotAvailableException: Exception
    {
        private readonly string failingObjectName; 

        public DataNotAvailableException(string failingObjectName, Exception innerException)
            : base(string.Format("Failed accessing {0}", failingObjectName), innerException)
        {
            this.failingObjectName = failingObjectName;
        }

        public string FailingObjectName
        {
            get
            {
                return this.failingObjectName;
            }
        }
    }
}
