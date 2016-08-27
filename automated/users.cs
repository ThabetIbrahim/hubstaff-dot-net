using System;
using Xunit;

namespace user_tests.Test
{
    public class usersTestClass
    {
        private config.config_class config = new config.config_class();
        public hubstaff.client hubstaff_api = new hubstaff.client(Environment.GetEnvironmentVariable("app_token"));
        public usersTestClass()
        {
            hubstaff_api.set_auth_token((string)Environment.GetEnvironmentVariable("auth_token"));
        }
        [Fact]
        public void usersTest()
        {
            var data = hubstaff_api.users();
            int user_id;
            Console.WriteLine("Xxxx");
            Console.WriteLine(data);
            Assert.True(Int32.TryParse((string)data["users"][0]["id"], out user_id));
        }
        [Fact]
        public void find_UserTest()
        {
            int id = 61188;
            var data = hubstaff_api.find_user(id);
            int user_id;
            Assert.True(Int32.TryParse((string)data["user"]["id"], out user_id));
        }
        [Fact]
        public void find_user_projectsTest()
        {
            int id = 61188;
            var data = hubstaff_api.find_user_projects(id);
            int project_id;
            Assert.True(Int32.TryParse((string)data["projects"][0]["id"], out project_id));
        }
        [Fact]
        public void find_user_orgsTest()
        {
            int id = 61188;
            var data = hubstaff_api.find_user_orgs(id);
            int organization_id;
            Assert.True(Int32.TryParse((string)data["organizations"][0]["id"], out organization_id));
        }
    }
}