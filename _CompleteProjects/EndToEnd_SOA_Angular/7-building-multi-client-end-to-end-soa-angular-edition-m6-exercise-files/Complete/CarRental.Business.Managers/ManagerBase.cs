using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using CarRental.Business.Entities;
using CarRental.Common;
using Core.Common.Contracts;
using Core.Common.Core;
using Core.Common.ServiceModel;

namespace CarRental.Business.Managers
{
    public class ManagerBase
    {
        public ManagerBase()
        {
            if (ObjectBase.Container != null)
                ObjectBase.Container.SatisfyImportsOnce(this);
        }

        protected T ExecuteFaultHandledOperation<T>(Func<T> codetoExecute)
        {
            try
            {
                return codetoExecute.Invoke();
            }
            catch (FaultException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        protected void ExecuteFaultHandledOperation(Action codetoExecute)
        {
            try
            {
                codetoExecute.Invoke();
            }
            catch (FaultException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
