using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Xunit;
using Moq;

namespace projects_tests
{
    public class projectsTestClass
    {
        public hubstaff_test.client hubstaff_api = new hubstaff_test.client();
        [Fact]
        public void projects()
        {
            var clientMock = new Mock<hubstaff_test.client>();
            var data = JObject.Parse("{'projects':[{'id':112761,'name':'Build Ruby Gem','last_activity':'2016-05-24T01:25:21Z','status':'Active','description':null},{'id':120320,'name':'Hubstaff API tutorial','last_activity':null,'status':'Active','description':null}]}");
            clientMock.Setup(r => r.projects(It.IsAny<string>(), It.IsAny<int>())).Returns(data);
            clientMock.Object.projects("active", 0);
            clientMock.Verify(r => r.projects(It.IsAny<string>(), It.IsAny<int>()), Times.AtLeastOnce());
        }
        [Fact]
        public void find_Project()
        {
            var clientMock = new Mock<hubstaff_test.client>();
            var data = JObject.Parse("{'project':{'id':112761,'name':'Build Ruby Gem','last_activity':'2016-05-24T01:25:21Z','status':'Active','description':null}}");
            clientMock.Setup(r => r.find_project(It.IsAny<int>())).Returns(data);
            clientMock.Object.find_project(112761);
            clientMock.Verify(r => r.find_project(It.IsAny<int>()), Times.AtLeastOnce());
        }
        [Fact]
        public void find_Project_members()
        {
            var clientMock = new Mock<hubstaff_test.client>();
            var data = JObject.Parse("{'users':[{'id':61188,'name':'Raymond Cudjoe','last_activity':'2016-05-24T01:25:21Z','email':'rkcudjoe@hookengine.com'}]}");
            clientMock.Setup(r => r.find_project_members(It.IsAny<int>(), It.IsAny<int>())).Returns(data);
            clientMock.Object.find_project_members(112761);
            clientMock.Verify(r => r.find_project_members(It.IsAny<int>(), It.IsAny<int>()), Times.AtLeastOnce());
        }
    }
}