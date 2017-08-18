using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.ServiceModel;
using CarRental.Business.Contracts;
using CarRental.Business.Entities;
using CarRental.Data.Contracts;
using Core.Common.Contracts;
using Core.Common.Exceptions;
using System.Security.Permissions;
using CarRental.Common;

namespace CarRental.Business.Managers
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall,
                     ConcurrencyMode = ConcurrencyMode.Multiple,
                     ReleaseServiceInstanceOnTransactionComplete = false)]
    public class AccountManager : ManagerBase, IAccountService
    {
        public AccountManager()
        {
        }

        public AccountManager(IDataRepositoryFactory dataRepositoryFactory)
        {
            _DataRepositoryFactory = dataRepositoryFactory;
        }

        [Import]
        IDataRepositoryFactory _DataRepositoryFactory;

        #region IAccountService operations

        public Account GetCustomerAccountInfo(string loginEmail)
        {
            return ExecuteFaultHandledOperation(() =>
            {
                IAccountRepository accountRepository = _DataRepositoryFactory.GetDataRepository<IAccountRepository>();

                Account accountEntity = accountRepository.GetByLogin(loginEmail);
                if (accountEntity == null)
                {
                    NotFoundException ex = new NotFoundException(string.Format("Account with login {0} is not in database", loginEmail));
                    throw new FaultException<NotFoundException>(ex, ex.Message);
                }

                return accountEntity;
            });
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void UpdateCustomerAccountInfo(Account account)
        {
            ExecuteFaultHandledOperation(() =>
            {
                IAccountRepository accountRepository = _DataRepositoryFactory.GetDataRepository<IAccountRepository>();
                
                Account updatedAccount = accountRepository.Update(account);
            });
        }
        
        #endregion
    }
}
