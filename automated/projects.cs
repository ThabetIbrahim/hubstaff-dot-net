using System;
using System.Collections.Generic;
namespace projects_tests
{
    class projectsTestClass
    {
        public hubstaff.client hubstaff_api = new hubstaff.client();
        public Dictionary<int, string> projects()
        {
            Dictionary<int, string> projs_data = new Dictionary<int, string>();

            var data = hubstaff_api.projects("active", 0);
            int i = 0;
            foreach (var item in data["projects"])
            {
                projs_data.Add(i, (string)item["id"]);
                i++;
            }
            return projs_data;
        }
        public Dictionary<int, string> find_Project()
        {
            int id = Int32.Parse(projects()[0]);
            var data = hubstaff_api.find_project(id);
            Dictionary<int, string> projs_data = new Dictionary<int, string>();
            projs_data.Add(0, (string)data["project"]["id"]);
            return projs_data;
        }
        public Dictionary<int, string> find_Project_members()
        {
            int id = Int32.Parse(projects()[0]);
            var data = hubstaff_api.find_project_members(id);
            Dictionary<int, string> members_data = new Dictionary<int, string>();
            int i = 0;
            foreach (var item in data["users"])
            {
                members_data.Add(i, (string)item["id"]);
                i++;
            }
            return members_data;
        }
    }
}