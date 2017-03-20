using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Xunit;
using Moq;

namespace orgs_tests
{
    public class orgsTestClass
    {
        public hubstaff_test.client hubstaff_api = new hubstaff_test.client();
        [Fact]
        public void organizations()
        {
            var clientMock = new Mock<hubstaff_test.client>();
            var data = JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','last_activity':'2016-05-24T01:25:21Z'}]}");
            clientMock.Setup(r => r.organizations(It.IsAny<int>())).Returns(data);
            clientMock.Object.organizations(0);
            clientMock.Verify(r => r.organizations(It.IsAny<int>()), Times.AtLeastOnce());
        }
        [Fact]
        public void find_organization()
        {
            var clientMock = new Mock<hubstaff_test.client>();
            var data = JObject.Parse("{'organization':[{'id':27572,'name':'Hook Engine','last_activity':'2016-05-24T01:25:21Z'}]}");
            clientMock.Setup(r => r.find_organization(It.IsAny<int>())).Returns(data);
            clientMock.Object.find_organization(27572);
            clientMock.Verify(r => r.find_organization(It.IsAny<int>()), Times.AtLeastOnce());
        }
        [Fact]
        public void find_organization_projects()
        {
            var clientMock = new Mock<hubstaff_test.client>();
            var data = JObject.Parse("{'projects':[{'id':112761,'name':'Build Ruby Gem','last_activity':'2016-05-24T01:25:21Z','status':'Active','description':null},{'id':120320,'name':'Hubstaff API tutorial','last_activity':null,'status':'Active','description':null}]}");
            clientMock.Setup(r => r.find_org_projects(It.IsAny<int>(), It.IsAny<int>())).Returns(data);
            clientMock.Object.find_org_projects(27572);
            clientMock.Verify(r => r.find_org_projects(It.IsAny<int>(),It.IsAny<int>()), Times.AtLeastOnce());
        }
        [Fact]
        public void find_organization_members()
        {
            var clientMock = new Mock<hubstaff_test.client>();
            var data = JObject.Parse("{'users':[{'id':61188,'name':'Raymond Cudjoe','last_activity':'2016-05-24T01:25:21Z','email':'rkcudjoe@hookengine.com','pay_rate':'No rate set'}]}");
            clientMock.Setup(r => r.find_org_members(It.IsAny<int>(), It.IsAny<int>())).Returns(data);
            clientMock.Object.find_org_members(27572);
            clientMock.Verify(r => r.find_org_members(It.IsAny<int>(),It.IsAny<int>()), Times.AtLeastOnce());
        }
    }
}