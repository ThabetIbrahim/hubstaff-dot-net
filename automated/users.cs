using System.Collections.Generic;
using System;
namespace users_tests
{
    class usersTestClass
    {
        public hubstaff.client hubstaff_api = new hubstaff.client("pHR18-G-9c05NoyBtji3a8A2KsFKOuZcSZK4gT5V9vc");
        public Dictionary<int, string> users()
        {

            Dictionary<int, string> users_data = new Dictionary<int, string>();

            var data = hubstaff_api.users();

            int i = 0;
            foreach (var item in data["users"])
            {
                users_data.Add(i, (string)item["id"]);
                i++;
            }

            return users_data;
        }
        public Dictionary<int, string> find_User()
        {
            int id = Int32.Parse(users()[0]);

            var data = hubstaff_api.find_user(id);

            Dictionary<int, string> users_data = new Dictionary<int, string>();
            if (data["error"] == null)
            {
                users_data.Add(0, (string)data["user"]["id"]);
            }
            else
            {
                users_data.Add(0, (string)data["error"]);
            }
            return users_data;
        }
        public Dictionary<int, string> find_user_projects()
        {
            int id = Int32.Parse(users()[0]);
            var data = hubstaff_api.find_user_projects(id);
            Dictionary<int, string> proj_data = new Dictionary<int, string>();
            int i = 0;
            foreach (var item in data["projects"])
            {
                proj_data.Add(i, (string)item["id"]);
                i++;
            }

            return proj_data;
        }
        public Dictionary<int, string> find_user_orgs()
        {
            int id = Int32.Parse(users()[0]);
            var data = hubstaff_api.find_user_orgs(id);
            Dictionary<int, string> orgs_data = new Dictionary<int, string>();
            int i = 0;
            foreach (var item in data["organizations"])
            {
                orgs_data.Add(i, (string)item["id"]);
                i++;
            }
            return orgs_data;
        }
    }
}