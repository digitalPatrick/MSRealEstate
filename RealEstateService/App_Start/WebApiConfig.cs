using System;
using System.Web.Http;
using RealEstateService.Models;
using Microsoft.WindowsAzure.Mobile.Service;
using System.Data.Entity.Migrations;
using RealEstateService.Migrations;
using Newtonsoft.Json.Serialization;

namespace RealEstateService
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            // Use this class to set configuration options for your mobile service
            ConfigOptions options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));

            //Use JSON serialization to resolve custom APIs
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

            var migrator = new DbMigrator(new Configuration());
            migrator.Update();

        }
    }
}

