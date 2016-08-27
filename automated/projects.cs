using System;
using Xunit; 
namespace projects_tests
{
    public class projectsTestClass
    {
        private config.config_class config = new config.config_class();
        public hubstaff.client hubstaff_api = new hubstaff.client(Environment.GetEnvironmentVariable("app_token"));
        public projectsTestClass()
        {
            hubstaff_api.set_auth_token((string)Environment.GetEnvironmentVariable("auth_token"));
        }
        [Fact]
        public void projects()
        {
            var data = hubstaff_api.projects("active", 0);
            int project_id;
            Assert.True(Int32.TryParse((string)data["projects"][0]["id"], out project_id));
        }
        [Fact]
        public void find_Project()
        {
            int id = 112761;
            var data = hubstaff_api.find_project(id);
            int project_id;
            Assert.True(Int32.TryParse((string)data["project"]["id"], out project_id));

        }
        [Fact]
        public void find_Project_members()
        {
            int id = 112761;
            var data = hubstaff_api.find_project_members(id);
            int user_id;
            Assert.True(Int32.TryParse((string)data["users"][0]["id"], out user_id));
        }
    }
}