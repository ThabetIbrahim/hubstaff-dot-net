using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Xunit;
using Moq;

namespace notes_test
{
    public class notesTestClass{
        public hubstaff_test.client hubstaff_api = new hubstaff_test.client();
        private Dictionary <string, string>  options = new Dictionary<string, string>();
        public void set_options()
        {
            this.options["organizations"] = "27572";
            this.options["projects"] = "112761";
            this.options["users"] = "61188";
        }
        [Fact]
        public void notes()
        {
            set_options();
            var data = JObject.Parse("{'notes':[{'id':716530,'description':'Practice Notes','time_slot':'2016-05-23T22:20:00Z','recorded_at':'2016-06-04T19:08:22Z','user_id':61188,'project_id':112761}]}");
            string starttime = "2016-05-23";
            string endtime = "2016-05-25";
            var clientMock = new Mock<hubstaff_test.client>();
            clientMock.Setup(r => r.notes(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>(), It.IsAny<int>())).Returns(data);
            clientMock.Object.notes(starttime, endtime, this.options, 0);
            clientMock.Verify(r => r.notes(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, string>>(), It.IsAny<int>()), Times.AtLeastOnce());

        }
        [Fact]
        public void get_note()
        {
            var clientMock = new Mock<hubstaff_test.client>();
            var data = JObject.Parse("{'note':{'id':716530,'description':'Practice Notes','time_slot':'2016-05-23T22:20:00Z','recorded_at':'2016-06-04T19:08:22Z','user_id':61188,'project_id':112761}}");
            clientMock.Setup(r => r.find_note(It.IsAny<int>())).Returns(data);
            clientMock.Object.find_note(716530);
            clientMock.Verify(r => r.find_note(It.IsAny<int>()), Times.AtLeastOnce());            
        }

    }
}