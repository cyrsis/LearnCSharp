using System;

namespace Cubo.Core.Domain
{
    public class CuboException : Exception
    {
        public string ErrorCode { get; }

        public CuboException()
        {
        }

        public CuboException(string errorCode) : this(errorCode, null, null, null)
        {
        }

        public CuboException(string message, params object[] args) 
            : this(null, null, message, args)
        {
        }

        public CuboException(string errorCode, string message, params object[] args) 
            : this(errorCode, null, message, args)
        {
        }

        public CuboException(Exception innerException, string message, params object[] args)
            : this(string.Empty, innerException, message, args)
        {
        }

        public CuboException(string errorCode, Exception innerException, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            ErrorCode = errorCode;
        }        
    }
}