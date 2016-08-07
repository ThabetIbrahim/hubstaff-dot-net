using System.Collections.Generic;
using System;
namespace activities_test
{
    class activitiesTestClass{
		private connection.connection_class connection = new connection.connection_class();
		public hubstaff.client hubstaff_api = new hubstaff.client();

        public Dictionary <int, string> activities()
        {
            orgs_tests.orgsTestClass orgs = new orgs_tests.orgsTestClass();
            projects_tests.projectsTestClass projects = new projects_tests.projectsTestClass();
            users_tests.usersTestClass users = new users_tests.usersTestClass();
            var starttime = "2016-03-14";
            var stoptime = "2016-03-20";
            Dictionary <string, string>  options = new Dictionary <string, string>();
            options["organizations"] = orgs.organizations()[0];
            options["projects"] = projects.projects()[0];
            options["users"] = users.users()[0];
            var data = hubstaff_api.activities(starttime, stoptime, options, 0);
            Dictionary <int, string> activities_data = new Dictionary <int, string>();
            int i = 0;
            Console.WriteLine(data["activities"].HasValues);
            if(data["activities"].HasValues)
            {
                foreach(var item in data["activities"])
                {
                    activities_data.Add(i, (string)item["id"]);
                    i++;
                }
            }else
            {
                activities_data.Add(0, "No data found");
            }
            return activities_data;
        }
    }
}