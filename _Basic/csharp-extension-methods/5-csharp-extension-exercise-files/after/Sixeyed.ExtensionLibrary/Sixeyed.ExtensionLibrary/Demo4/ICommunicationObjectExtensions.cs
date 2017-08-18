
using System;
using System.ServiceModel;
namespace Sixeyed.ExtensionLibrary
{
    public static class ICommunicationObjectExtensions
    {
        public static void DisposeSafely(this ICommunicationObject communicationObject)
        {
            if (communicationObject.State == CommunicationState.Faulted)
            {
                communicationObject.Abort();
            }
            else
            {
                communicationObject.Close();
            }
            var disposable = communicationObject as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }
        }
    }
}
