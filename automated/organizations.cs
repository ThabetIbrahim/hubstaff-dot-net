using System;
using Xunit;
namespace orgs_tests
{
    public class orgsTestClass
    {
        private config.config_class config = new config.config_class();
        public hubstaff.client hubstaff_api = new hubstaff.client(Environment.GetEnvironmentVariable("app_token"));
        public orgsTestClass()
        {
            hubstaff_api.set_auth_token((string)Environment.GetEnvironmentVariable("auth_token"));
        }
        [Fact]
        public void organizations()
        {
            var data = hubstaff_api.organizations(0);
            int org_id;
            Assert.True(Int32.TryParse((string)data["organizations"][0]["id"], out org_id));
        }
        [Fact]
        public void find_Organization()
        {
            int id = 27572;
            var data = hubstaff_api.find_organization(id);
            int org_id;
            Assert.True(Int32.TryParse((string)data["organization"]["id"], out org_id));
        }
        [Fact]
        public void find_Organization_projects()
        {
            int id = 27572;
            var data = hubstaff_api.find_org_projects(id);
            int project_id;
            Assert.True(Int32.TryParse((string)data["projects"][0]["id"], out project_id));
        }
        [Fact]
        public void find_Organization_members()
        {
            int id = 27572;
            var data = hubstaff_api.find_org_members(id);
            int user_id;
            Assert.True(Int32.TryParse((string)data["users"][0]["id"], out user_id));
        }
    }
}