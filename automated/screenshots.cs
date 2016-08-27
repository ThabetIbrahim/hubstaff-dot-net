using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Xunit;
namespace screenshots_test
{
    public class screenshotsTestClass{
        private config.config_class config = new config.config_class();
        public hubstaff.client hubstaff_api = new hubstaff.client(Environment.GetEnvironmentVariable("app_token"));
        public screenshotsTestClass()
        {
            hubstaff_api.set_auth_token((string)Environment.GetEnvironmentVariable("auth_token"));
        }
        private Dictionary <string, string>  options = new Dictionary<string, string>();
        public void set_options()
        {
            this.options["organizations"] = "27572";
            this.options["projects"] = "112761";
            this.options["users"] = "61188";
        }
        [Fact]
        public void screenshots()
        {
            set_options();
            string starttime = "2016-05-01";
            string endtime = "2016-05-07";
            var data = hubstaff_api.screehshots(starttime,endtime,this.options,0);
            JToken data_val = "";
            Assert.True(data.TryGetValue("screenshots", out data_val));
        }

    }
}