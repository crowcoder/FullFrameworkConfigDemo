using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;

namespace FullFrameworkConfiguration.Controllers
{
    public class ValuesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            string machSetting = ConfigurationManager.AppSettings["MachineConfigSetting"];
            string xternal = ConfigurationManager.AppSettings["ExternalConfigSetting"];
            string envar = Environment.GetEnvironmentVariable("OS");

            return new string[] { machSetting, envar, xternal };
        }
    }
}
