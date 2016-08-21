using System.Collections.Generic;
using System;

namespace orgs_tests
{
    class orgsTestClass
    {
        public hubstaff.client hubstaff_api = new hubstaff.client("pHR18-G-9c05NoyBtji3a8A2KsFKOuZcSZK4gT5V9vc");
        public Dictionary<int, string> organizations()
        {
            Dictionary<int, string> orgs_data = new Dictionary<int, string>();

            var data = hubstaff_api.organizations(0);
            int i = 0;
            foreach (var item in data["organizations"])
            {
                orgs_data.Add(i, (string)item["id"]);
                i++;
            }
            return orgs_data;
        }
        public Dictionary<int, string> find_Organization()
        {
            int id = Int32.Parse(organizations()[0]);
            var data = hubstaff_api.find_organization(id);
            Dictionary<int, string> org_data = new Dictionary<int, string>();
            org_data.Add(0, (string)data["organization"]["id"]);
            return org_data;
        }
        public Dictionary<int, string> find_Organization_projects()
        {
            int id = Int32.Parse(organizations()[0]);
            var data = hubstaff_api.find_org_projects(id);
            Dictionary<int, string> proj_data = new Dictionary<int, string>();
            int i = 0;
            foreach (var item in data["projects"])
            {
                proj_data.Add(i, (string)item["id"]);
                i++;
            }

            return proj_data;
        }
        public Dictionary<int, string> find_Organization_members()
        {
            int id = Int32.Parse(organizations()[0]);
            var data = hubstaff_api.find_org_members(id);
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