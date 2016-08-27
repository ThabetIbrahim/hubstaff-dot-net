using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Xunit;
namespace weekly_test
{
    public class weeklyTestClass
    {
        private config.config_class config = new config.config_class();
        public hubstaff.client hubstaff_api = new hubstaff.client(Environment.GetEnvironmentVariable("app_token"));
        public weeklyTestClass()
        {
            hubstaff_api.set_auth_token((string)Environment.GetEnvironmentVariable("auth_token"));
        }
        private Dictionary<string, string> options = new Dictionary<string, string>();
        public void set_options()
        {
            this.options["organizations"] = "27572";
            this.options["projects"] = "112761";
            this.options["users"] = "61188";
            this.options["date"] = "2016-05-01";
        }
        [Fact]
        public void weekly_team()
        {
            set_options();
            var data = hubstaff_api.weekly_team(this.options);
            JToken data_val = "";
            Assert.True(data.TryGetValue("organizations", out data_val));
        }
        [Fact]
        public void weekly_my()
        {
            set_options();
            var data = hubstaff_api.weekly_my(this.options);
            JToken data_val = "";
            Assert.True(data.TryGetValue("organizations", out data_val));
        }
    }
}