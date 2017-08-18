﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using System.Web.Routing;
using Sixeyed.CarValet.Api.App_Start;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Thinktecture.IdentityModel.Http.Cors.WebApi;
using WebApiContrib.Formatting.Jsonp;
using System.Net.Http.Formatting;

namespace Sixeyed.CarValet.Api
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            RegisterCors(GlobalConfiguration.Configuration);
            //RegisterJsonp(GlobalConfiguration.Configuration);
            CustomizeJsonFormatting();
        }

        private void RegisterJsonp(HttpConfiguration httpConfiguration)
        {
            httpConfiguration.Formatters.Insert(0, new JsonpMediaTypeFormatter(new JsonMediaTypeFormatter()));
        }

        private void CustomizeJsonFormatting()
        {
            var jsonFormatter = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            var settings = new Newtonsoft.Json.JsonSerializerSettings()
            {
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
            };
            jsonFormatter.SerializerSettings = settings;
            jsonFormatter.SerializerSettings.Converters = new List<JsonConverter>() { new StringEnumConverter() };
        }

        public static void RegisterCors(HttpConfiguration httpConfig)
        {
            var corsConfig = new WebApiCorsConfiguration();
            corsConfig.RegisterGlobal(httpConfig);
            corsConfig.AllowAll();
        }
    }
}