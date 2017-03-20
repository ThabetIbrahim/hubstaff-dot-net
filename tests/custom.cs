using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Xunit;
using Moq;

namespace custom_test
{
    class customTestClass
    {
        public string start_date = "2016-05-01";
        public string end_date = "2016-05-07";
        public hubstaff_test.client hubstaff_api = new hubstaff_test.client();
        private Dictionary<string, string> options = new Dictionary<string, string>();
        public void set_options()
        {
            this.options["organizations"] = "27572";
            this.options["projects"] = "112761";
            this.options["users"] = "61188";
            this.options["show_tasks"] = "1";
            this.options["show_notes"] = "1";
            this.options["show_activity"] = "1";
            this.options["include_archived"] = "1";
        }
        [Fact]
        public void custom_date_team()
        {
            set_options();
            var data = JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','duration':7874,'activity_percent':38,'dates':[{'date':'2016-05-23','duration':7874,'activity_percent':38,'users':[{'id':61188,'name':'Raymond Cudjoe','duration':7874,'activity_percent':38,'projects':[{'id':112761,'name':'Build Ruby Gem','duration':7874,'activity_percent':38,'notes':[{'id':716530,'description':'Practice Notes'}]}]}]}]}]}");
            var clientMock = new Mock<hubstaff_test.client>();
            clientMock.Setup(r => r.custom_date_team(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>())).Returns(data);
            clientMock.Object.custom_date_team(this.start_date, this.end_date, this.options);
            clientMock.Verify(r => r.custom_date_team(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>()), Times.AtLeastOnce());
        }
        [Fact]
        public void custom_date_my()
        {
            set_options();
            var data = JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','duration':7874,'activity_percent':38,'dates':[{'date':'2016-05-23','duration':7874,'activity_percent':38,'users':[{'id':61188,'name':'Raymond Cudjoe','duration':7874,'activity_percent':38,'projects':[{'id':112761,'name':'Build Ruby Gem','duration':7874,'activity_percent':38,'notes':[{'id':716530,'description':'Practice Notes'}]}]}]}]}]}");
            var clientMock = new Mock<hubstaff_test.client>();
            clientMock.Setup(r => r.custom_date_my(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>())).Returns(data);
            clientMock.Object.custom_date_my(this.start_date, this.end_date, this.options);
            clientMock.Verify(r => r.custom_date_my(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>()), Times.AtLeastOnce());
        }
        [Fact]
        public void custom_member_team()
        {
            set_options();
            var data = JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','duration':7874,'activity_percent':38,'dates':[{'date':'2016-05-23','duration':7874,'activity_percent':38,'users':[{'id':61188,'name':'Raymond Cudjoe','duration':7874,'activity_percent':38,'projects':[{'id':112761,'name':'Build Ruby Gem','duration':7874,'activity_percent':38,'notes':[{'id':716530,'description':'Practice Notes'}]}]}]}]}]}");
            var clientMock = new Mock<hubstaff_test.client>();
            clientMock.Setup(r => r.custom_member_team(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>())).Returns(data);
            clientMock.Object.custom_member_team(this.start_date, this.end_date, this.options);
            clientMock.Verify(r => r.custom_member_team(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>()), Times.AtLeastOnce());
        }
        [Fact]
        public void custom_member_my()
        {
            set_options();
            var data = JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','duration':7874,'activity_percent':38,'dates':[{'date':'2016-05-23','duration':7874,'activity_percent':38,'users':[{'id':61188,'name':'Raymond Cudjoe','duration':7874,'activity_percent':38,'projects':[{'id':112761,'name':'Build Ruby Gem','duration':7874,'activity_percent':38,'notes':[{'id':716530,'description':'Practice Notes'}]}]}]}]}]}");
            var clientMock = new Mock<hubstaff_test.client>();
            clientMock.Setup(r => r.custom_member_my(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>())).Returns(data);
            clientMock.Object.custom_member_my(this.start_date, this.end_date, this.options);
            clientMock.Verify(r => r.custom_member_my(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>()), Times.AtLeastOnce());
        }
        [Fact]
        public void custom_project_team()
        {
            set_options();
            var data = JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','duration':7874,'activity_percent':38,'dates':[{'date':'2016-05-23','duration':7874,'activity_percent':38,'users':[{'id':61188,'name':'Raymond Cudjoe','duration':7874,'activity_percent':38,'projects':[{'id':112761,'name':'Build Ruby Gem','duration':7874,'activity_percent':38,'notes':[{'id':716530,'description':'Practice Notes'}]}]}]}]}]}");
            var clientMock = new Mock<hubstaff_test.client>();
            clientMock.Setup(r => r.custom_project_team(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>())).Returns(data);
            clientMock.Object.custom_project_team(this.start_date, this.end_date, this.options);
            clientMock.Verify(r => r.custom_project_team(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>()), Times.AtLeastOnce());
        }
        [Fact]
        public void custom_project_my()
        {
            set_options();
            var data = JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','duration':7874,'activity_percent':38,'dates':[{'date':'2016-05-23','duration':7874,'activity_percent':38,'users':[{'id':61188,'name':'Raymond Cudjoe','duration':7874,'activity_percent':38,'projects':[{'id':112761,'name':'Build Ruby Gem','duration':7874,'activity_percent':38,'notes':[{'id':716530,'description':'Practice Notes'}]}]}]}]}]}");
            var clientMock = new Mock<hubstaff_test.client>();
            clientMock.Setup(r => r.custom_project_my(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>())).Returns(data);
            clientMock.Object.custom_project_my(this.start_date, this.end_date, this.options);
            clientMock.Verify(r => r.custom_project_my(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>()), Times.AtLeastOnce());
        }
    }
}