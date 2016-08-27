using System.Collections.Generic;
using Xunit;
using Newtonsoft.Json.Linq;
using System;

namespace activities_test
{
    public class activitiesTestClass{
        private config.config_class config = new config.config_class();
        public hubstaff.client hubstaff_api = new hubstaff.client(Environment.GetEnvironmentVariable("app_token"));
        public activitiesTestClass()
        {
            hubstaff_api.set_auth_token((string)Environment.GetEnvironmentVariable("auth_token"));
        }
        [Fact]
        public void activities()
        {
            var starttime = "2016-03-14";
            var stoptime = "2016-03-20";
            Dictionary <string, string>  options = new Dictionary <string, string>();
            options["organizations"] = "27572";
            options["projects"] = "112761";
            options["users"] = "61188";
            var data = hubstaff_api.activities(starttime, stoptime, options, 0);
            JToken data_val = "";
            Assert.True(data.TryGetValue("activities", out data_val));
        }
    }
}