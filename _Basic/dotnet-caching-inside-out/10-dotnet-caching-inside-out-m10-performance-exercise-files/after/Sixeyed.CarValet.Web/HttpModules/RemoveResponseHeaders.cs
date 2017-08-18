using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Sixeyed.CarValet.Web.HttpModules
{
    public abstract class RemoveResponseHeaders : IHttpModule
    {
        protected abstract List<string> GetHeadersToRemove();

        public void Init(HttpApplication context)
        {
            context.EndRequest += new EventHandler(context_EndRequest);
        }

        private void context_EndRequest(object sender, EventArgs e)
        {
            var headers = GetHeadersToRemove();
            if (headers != null)
            {
                var context = HttpContext.Current;
                headers.ForEach(h => context.Response.Headers.Remove(h));
            }

        }

        public void Dispose() { }
    }
}