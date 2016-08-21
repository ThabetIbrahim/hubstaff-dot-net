using System.Collections.Generic;
namespace screenshots_test
{
    class screenshotsTestClass{
		private connection.connection_class connection = new connection.connection_class();
    	public hubstaff.client hubstaff_api = new hubstaff.client("pHR18-G-9c05NoyBtji3a8A2KsFKOuZcSZK4gT5V9vc");
        public orgs_tests.orgsTestClass orgs = new orgs_tests.orgsTestClass();
        public projects_tests.projectsTestClass projects = new projects_tests.projectsTestClass();
        public users_tests.usersTestClass users = new users_tests.usersTestClass();
        private Dictionary <string, string>  options = new Dictionary<string, string>();
        public void set_options()
        {
            options["organizations"] = orgs.organizations()[0];
            options["projects"] = projects.projects()[0];
            options["users"] = users.users()[0];
        }
        
        public Dictionary<int, string> screenshots()
        {
            set_options();
            string starttime = "2016-05-01";
            string endtime = "2016-05-07";
            var data = hubstaff_api.screehshots(starttime,endtime,options,0);
            Dictionary<int, string> screehshots_data = new Dictionary<int, string>();
            int i = 0;
            if(data["screehshots"].HasValues)
            {
                foreach(var item in data["activities"])
                {
                    screehshots_data.Add(i, (string)item["id"]);
                    i++;
                }
            }else
            {
                screehshots_data.Add(0, "No data found");
            }

            return screehshots_data;
        }

    }
}