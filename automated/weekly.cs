using System.Collections.Generic;

namespace weekly_test
{
    class weeklyTestClass
    {
        private connection.connection_class connection = new connection.connection_class();
        public hubstaff.client hubstaff_api = new hubstaff.client("pHR18-G-9c05NoyBtji3a8A2KsFKOuZcSZK4gT5V9vc");
        public orgs_tests.orgsTestClass orgs = new orgs_tests.orgsTestClass();
        public projects_tests.projectsTestClass projects = new projects_tests.projectsTestClass();
        public users_tests.usersTestClass users = new users_tests.usersTestClass();
        private Dictionary<string, string> _options = new Dictionary<string, string>();
        private Dictionary<string, string> options = new Dictionary<string, string>();
        public void set_options()
        {
            options["organizations"] = orgs.organizations()[0];
            options["projects"] = projects.projects()[0];
            options["users"] = users.users()[0];
            options["date"] = "2016-05-01";
        }
        public Dictionary<int, string> weekly_team()
        {
            set_options();
            var data = hubstaff_api.weekly_team(options);
            Dictionary<int, string> weekly_data = new Dictionary<int, string>();
            int i = 0;
            if (data["notes"].HasValues)
            {
                foreach (var item in data["users"])
                {
                    weekly_data.Add(i, (string)item["id"]);
                    i++;
                }
            }
            else
            {
                weekly_data.Add(0, "No data found");
            }

            return weekly_data;
        }
        public Dictionary<int, string> weekly_my()
        {
            set_options();
            var data = hubstaff_api.weekly_my(options);
            Dictionary<int, string> weekly_data = new Dictionary<int, string>();
            int i = 0;
            if (data["notes"].HasValues)
            {
                foreach (var item in data["users"])
                {
                    weekly_data.Add(i, (string)item["id"]);
                    i++;
                }
            }
            else
            {
                weekly_data.Add(0, "No data found");
            }

            return weekly_data;
        }
    }
}