using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Xunit;
using Moq;

namespace weekly_test
{
    public class weeklyTestClass
    {
        public hubstaff_test.client hubstaff_api = new hubstaff_test.client();
        private Dictionary<string, string> options = new Dictionary<string, string>();
        public void set_options()
        {
            this.options["organizations"] = "27572";
            this.options["projects"] = "112761";
            this.options["users"] = "61188";
            this.options["date"] = "2016-05-01";
        }
        [Fact]
        public void weekly_team()
        {
            set_options();
            var data = JObject.Parse("{'organizations':[]}");
            var clientMock = new Mock<hubstaff_test.client>();
            clientMock.Setup(r => r.weekly_team( It.IsAny<Dictionary<string, string>>())).Returns(data);
            clientMock.Object.weekly_team(this.options);
            clientMock.Verify(r => r.weekly_team(It.IsAny<Dictionary<string, string>>()), Times.AtLeastOnce());
        }
        [Fact]
        public void weekly_my()
        {
            var data = JObject.Parse("{'organizations':[]}");
            var clientMock = new Mock<hubstaff_test.client>();
            clientMock.Setup(r => r.weekly_my( It.IsAny<Dictionary<string, string>>())).Returns(data);
            clientMock.Object.weekly_my(this.options);
            clientMock.Verify(r => r.weekly_my(It.IsAny<Dictionary<string, string>>()), Times.AtLeastOnce());
        }
    }
}