using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Xunit;
using Moq;

namespace activities_test
{

    public class activitiesTestClass{
        [Fact]
        public void activities()
        {
            var starttime = "2016-03-14";
            var stoptime = "2016-03-20";
            Dictionary <string, string>  options = new Dictionary <string, string>();
            options["organizations"] = "27572";
            options["projects"] = "112761";
            options["users"] = "61188";
            var data = JObject.Parse("{'activities':[]}");
            var clientMock = new Mock<hubstaff_test.client>();
            clientMock.Setup(r => r.activities(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>(), It.IsAny<int>())).Returns(data);
            clientMock.Object.activities(starttime, stoptime, options, 0);
            clientMock.Verify(r => r.activities(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>(), It.IsAny<int>()), Times.AtLeastOnce());
        }
    }
}