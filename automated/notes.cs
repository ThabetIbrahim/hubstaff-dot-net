using System;
using System.Collections.Generic;
namespace notes_test
{
    class notesTestClass{
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
        
        public Dictionary<int, string> notes()
        {
            set_options();
            string starttime = "2016-05-01";
            string endtime = "2016-05-07";
            var data = hubstaff_api.screehshots(starttime,endtime,options,0);
            Dictionary<int, string> notes_data = new Dictionary<int, string>();
            int i = 0;
            if(data["notes"].HasValues)
            {
                foreach(var item in data["notes"])
                {
                    notes_data.Add(i, (string)item["id"]);
                    i++;
                }
            }else
            {
                notes_data.Add(0, "No data found");
            }

            return notes_data;
        }

        public Dictionary<int, string> get_note()
        {
            int id = Int32.Parse(notes()[0]);
            var data = hubstaff_api.find_user(id);
            Dictionary<int, string> note_data = new Dictionary<int, string>();
            note_data.Add(0, (string)data["user"]["id"]);
            return note_data;
        }

    }
}