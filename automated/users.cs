using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Xunit;
using Moq;

namespace user_tests.Test
{
    public class usersTestClass
    {
        public hubstaff_test.client hubstaff_api = new hubstaff_test.client();

        [Fact]
        public void usersTest()
        {
            var clientMock = new Mock<hubstaff_test.client>();
            var data = JObject.Parse("{'users':[{'id':61188,'name':'Raymond Cudjoe','last_activity':'2016-05-24T01:25:21Z','email':'rkcudjoe@hookengine.com'}]}");
            clientMock.Setup(r => r.users(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).Returns(data);
            clientMock.Object.users(1, 1, 1);
            clientMock.Verify(r => r.users(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()), Times.AtLeastOnce());
        }
        [Fact]
        public void find_UserTest()
        {
            var clientMock = new Mock<hubstaff_test.client>();
            var data = JObject.Parse("{'user':[{'id':61188,'name':'Raymond Cudjoe','last_activity':'2016-05-24T01:25:21Z','email':'rkcudjoe@hookengine.com'}]}");
            clientMock.Setup(r => r.find_user(It.IsAny<int>())).Returns(data);
            clientMock.Object.find_user(61188);
            clientMock.Verify(r => r.find_user(It.IsAny<int>()), Times.AtLeastOnce());            
        }
        [Fact]
        public void find_user_projectsTest()
        {
            var clientMock = new Mock<hubstaff_test.client>();
            var data = JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','last_activity':'2016-05-24T01:25:21Z'}]}");
            clientMock.Setup(r => r.find_user_projects(It.IsAny<int>(), It.IsAny<int>())).Returns(data);
            clientMock.Object.find_user_projects(61188, 0);
            clientMock.Verify(r => r.find_user_projects(It.IsAny<int>(), It.IsAny<int>()), Times.AtLeastOnce());            
        }
        [Fact]
        public void find_user_orgsTest()
        {
            var clientMock = new Mock<hubstaff_test.client>();
            var data = JObject.Parse("{'projects':[{'id':112761,'name':'Build Ruby Gem','last_activity':'2016-05-24T01:25:21Z','status':'Active','description':null},{'id':120320,'name':'Hubstaff API tutorial','last_activity':null,'status':'Active','description':null}]}");
            clientMock.Setup(r => r.find_user_orgs(It.IsAny<int>(), It.IsAny<int>())).Returns(data);
            clientMock.Object.find_user_orgs(61188, 0);
            clientMock.Verify(r => r.find_user_orgs(It.IsAny<int>(), It.IsAny<int>()), Times.AtLeastOnce());            
        }
    }
}