using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common.Contracts;
using Core.Common.Core;

namespace CarRental.Business
{
    public class BusinessEngineFactory : IBusinessEngineFactory
    {
        #region IBusinessEngineFactory Members

        T IBusinessEngineFactory.GetBusinessEngine<T>()
        {
            return ObjectBase.Container.GetExportedValue<T>();
        }

        #endregion
    }
}
