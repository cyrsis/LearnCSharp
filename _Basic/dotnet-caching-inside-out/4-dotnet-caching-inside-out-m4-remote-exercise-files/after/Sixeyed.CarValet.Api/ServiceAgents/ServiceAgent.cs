using Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes;
using Sixeyed.CarValet.Api.ServiceAgents.Wcf.Content;
using Sixeyed.CarValet.Api.ServiceAgents.Wcf.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sixeyed.CarValet.Api.ServiceAgents
{
    public static class ServiceAgent
    {
        public static QuoteServiceSoapClient Quotes
        {
            get { return new QuoteServiceSoapClient(); }
        }

        public static VehicleServiceClient Vehicle
        {
            get { return new VehicleServiceClient(); }
        }

        public static ContentServiceClient Content
        {
            get { return new ContentServiceClient(); }
        }
    }
}