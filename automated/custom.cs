using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Xunit;
namespace custom_test
{
    class customTestClass
    {
        private config.config_class config = new config.config_class();
        public string start_date = "2016-05-01";
        public string end_date = "2016-05-07";
        public hubstaff.client hubstaff_api = new hubstaff.client(Environment.GetEnvironmentVariable("app_token"));
        public customTestClass()
        {
            hubstaff_api.set_auth_token((string)Environment.GetEnvironmentVariable("auth_token"));
        }
        private Dictionary<string, string> options = new Dictionary<string, string>();
        public void set_options()
        {
            this.options["organizations"] = "27572";
            this.options["projects"] = "112761";
            this.options["users"] = "61188";
            this.options["show_tasks"] = "1";
            this.options["show_notes"] = "1";
            this.options["show_activity"] = "1";
            this.options["include_archived"] = "1";
        }
        [Fact]
        public void custom_date_team()
        {
            set_options();
            var data = hubstaff_api.custom_date_team(this.start_date, this.end_date, this.options);
            JToken data_val = "";
            Assert.True(data.TryGetValue("organizations", out data_val));
        }
        [Fact]
        public void custom_date_my()
        {
            set_options();
            var data = hubstaff_api.custom_date_my(this.start_date, this.end_date, this.options);
            JToken data_val = "";
            Assert.True(data.TryGetValue("organizations", out data_val));
        }
        [Fact]
        public void custom_member_team()
        {
            set_options();
            var data = hubstaff_api.custom_member_team(this.start_date, this.end_date, this.options);
            JToken data_val = "";
            Assert.True(data.TryGetValue("organizations", out data_val));
        }
        [Fact]
        public void custom_member_my()
        {
            set_options();
            var data = hubstaff_api.custom_member_my(this.start_date, this.end_date, this.options);
            JToken data_val = "";
            Assert.True(data.TryGetValue("organizations", out data_val));
        }
        [Fact]
        public void custom_project_team()
        {
            set_options();
            var data = hubstaff_api.custom_project_team(this.start_date, this.end_date, this.options);
            JToken data_val = "";
            Assert.True(data.TryGetValue("organizations", out data_val));
        }
        [Fact]
        public void custom_project_my()
        {
            set_options();
            var data = hubstaff_api.custom_project_my(this.start_date, this.end_date, this.options);
            JToken data_val = "";
            Assert.True(data.TryGetValue("organizations", out data_val));
        }
    }
}