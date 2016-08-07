using System.Collections.Generic;
using System;
namespace custom_test
{
    class customTestClass
    {
        private connection.connection_class connection = new connection.connection_class();
        public string start_date = "2016-05-01";
        public string end_date = "2016-05-07";
        public hubstaff.client hubstaff_api = new hubstaff.client();
        public orgs_tests.orgsTestClass orgs = new orgs_tests.orgsTestClass();
        public projects_tests.projectsTestClass projects = new projects_tests.projectsTestClass();
        public users_tests.usersTestClass users = new users_tests.usersTestClass();
        private Dictionary<string, string> options = new Dictionary<string, string>();
        public void set_options()
        {
            options["organizations"] = orgs.organizations()[0];
            options["projects"] = projects.projects()[0];
            options["users"] = users.users()[0];
            options["show_tasks"] = "1";
            options["show_notes"] = "1";
            options["show_activity"] = "1";
            options["include_archived"] = "1";
        }
        public Dictionary<int, string> custom_date_team()
        {
            set_options();
            var data = hubstaff_api.custom_date_team(start_date, end_date, options);
            Dictionary<int, string> custom_data = new Dictionary<int, string>();
            int i = 0;
            if (data["organizations"].HasValues)
            {
                foreach (var item in data["organizations"])
                {
                    custom_data.Add(i, (string)item["id"]);
                    i++;
                }
            }
            else
            {
                custom_data.Add(0, "No data found");
            }

            return custom_data;
        }
        public Dictionary<int, string> custom_date_my()
        {
            set_options();
            var data = hubstaff_api.custom_date_my(start_date, end_date, options);
            Dictionary<int, string> custom_data = new Dictionary<int, string>();
            int i = 0;
            if (data["organizations"].HasValues)
            {
                foreach (var item in data["organizations"])
                {
                    custom_data.Add(i, (string)item["id"]);
                    i++;
                }
            }
            else
            {
                custom_data.Add(0, "No data found");
            }

            return custom_data;
        }
        public Dictionary<int, string> custom_member_team()
        {
            set_options();
            var data = hubstaff_api.custom_member_team(start_date, end_date, options);
            Dictionary<int, string> custom_data = new Dictionary<int, string>();
            int i = 0;
            if (data["organizations"].HasValues)
            {
                foreach (var item in data["organizations"])
                {
                    custom_data.Add(i, (string)item["id"]);
                    i++;
                }
            }
            else
            {
                custom_data.Add(0, "No data found");
            }

            return custom_data;
        }
        public Dictionary<int, string> custom_member_my()
        {
            set_options();
            var data = hubstaff_api.custom_member_my(start_date, end_date, options);
            Dictionary<int, string> custom_data = new Dictionary<int, string>();
            int i = 0;
            if (data["organizations"].HasValues)
            {
                foreach (var item in data["organizations"])
                {
                    custom_data.Add(i, (string)item["id"]);
                    i++;
                }
            }
            else
            {
                custom_data.Add(0, "No data found");
            }

            return custom_data;
        }
        public Dictionary<int, string> custom_project_team()
        {
            set_options();
            var data = hubstaff_api.custom_project_team(start_date, end_date, options);
            Dictionary<int, string> custom_data = new Dictionary<int, string>();
            int i = 0;
            if (data["organizations"].HasValues)
            {
                foreach (var item in data["organizations"])
                {
                    custom_data.Add(i, (string)item["id"]);
                    i++;
                }
            }
            else
            {
                custom_data.Add(0, "No data found");
            }

            return custom_data;
        }
        public Dictionary<int, string> custom_project_my()
        {
            set_options();
            var data = hubstaff_api.custom_project_my(start_date, end_date, options);
            Dictionary<int, string> custom_data = new Dictionary<int, string>();
            int i = 0;
            if (data["organizations"].HasValues)
            {
                foreach (var item in data["organizations"])
                {
                    custom_data.Add(i, (string)item["id"]);
                    i++;
                }
            }
            else
            {
                custom_data.Add(0, "No data found");
            }

            return custom_data;
        }
    }
}