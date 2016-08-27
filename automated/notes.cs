using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Xunit;
namespace notes_test
{
    public class notesTestClass{
        private config.config_class config = new config.config_class();
        public hubstaff.client hubstaff_api = new hubstaff.client(Environment.GetEnvironmentVariable("app_token"));
        public notesTestClass()
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
        public void notes()
        {
            set_options();
            string starttime = "2016-05-23";
            string endtime = "2016-05-25";
            var data = hubstaff_api.notes(starttime,endtime,this.options,0);
            JToken data_val = "";
            Assert.True(data.TryGetValue("notes", out data_val));
        }
        [Fact]
        public void get_note()
        {
            int id = 716530;
            var data = hubstaff_api.find_note(id);
            JToken data_val = "";
            Assert.True(data.TryGetValue("note", out data_val));
        }

    }
}