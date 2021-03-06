using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace hubstaff_test
{
    public class client
    {
        public virtual JObject users(int organization_memberships = 1, int project_memberships = 1,int offset = 0)
        {
            return JObject.Parse("{'users':[{'id':61188,'name':'Raymond Cudjoe','last_activity':'2016-05-24T01:25:21Z','email':'rkcudjoe@hookengine.com'}]}");
        }
        public virtual JObject find_user(int id)
        {
            return JObject.Parse("{'user':[{'id':61188,'name':'Raymond Cudjoe','last_activity':'2016-05-24T01:25:21Z','email':'rkcudjoe@hookengine.com'}]}");
        }
        public virtual JObject find_user_orgs(int id,int offset = 0)
        {
            return JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','last_activity':'2016-05-24T01:25:21Z'}]}");
        }
        public virtual JObject find_user_projects(int id, int offset = 0)
        {
            return JObject.Parse("{'projects':[{'id':112761,'name':'Build Ruby Gem','last_activity':'2016-05-24T01:25:21Z','status':'Active','description':null},{'id':120320,'name':'Hubstaff API tutorial','last_activity':null,'status':'Active','description':null}]}");
        }

        public virtual JObject organizations(int offset = 0)
        {
            return JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','last_activity':'2016-05-24T01:25:21Z'}]}");
        }

        public virtual JObject find_organization(int id)
        {
            return JObject.Parse("{'organization':[{'id':27572,'name':'Hook Engine','last_activity':'2016-05-24T01:25:21Z'}]}");
        }
        public virtual JObject find_org_projects(int id,int offset = 0)
        {
            return JObject.Parse("{'projects':[{'id':112761,'name':'Build Ruby Gem','last_activity':'2016-05-24T01:25:21Z','status':'Active','description':null},{'id':120320,'name':'Hubstaff API tutorial','last_activity':null,'status':'Active','description':null}]}");
        }
        public virtual JObject find_org_members(int id, int offset = 0)
        {
            return JObject.Parse("{'users':[{'id':61188,'name':'Raymond Cudjoe','last_activity':'2016-05-24T01:25:21Z','email':'rkcudjoe@hookengine.com','pay_rate':'No rate set'}]}");
        }

        public virtual JObject projects(string status = "", int offset = 0)
        {
            return JObject.Parse("{'projects':[{'id':112761,'name':'Build Ruby Gem','last_activity':'2016-05-24T01:25:21Z','status':'Active','description':null},{'id':120320,'name':'Hubstaff API tutorial','last_activity':null,'status':'Active','description':null}]}");
        }

        public virtual JObject find_project(int id)
        {
            return JObject.Parse("{'project':{'id':112761,'name':'Build Ruby Gem','last_activity':'2016-05-24T01:25:21Z','status':'Active','description':null}}");
        }
        public virtual JObject find_project_members(int id, int offset = 0)
        {
            return JObject.Parse("{'users':[{'id':61188,'name':'Raymond Cudjoe','last_activity':'2016-05-24T01:25:21Z','email':'rkcudjoe@hookengine.com'}]}");
        }
        public virtual JObject activities(string starttime, string stoptime, Dictionary<string, string> options,int offset = 0)
        {
            return JObject.Parse("{'activities':[]}");
        }

        public virtual JObject screehshots(string starttime, string stoptime, Dictionary<string, string> options, int offset = 0)
        {
            return JObject.Parse("{'screenshots':[{'id':173200938,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/c0ee59a20ef67f9537057e50fcd2132f515cc45e/0.jpg','time_slot':'2016-05-23T22:00:00Z','recorded_at':'2016-05-23T22:08:36Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173200946,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/07411361cb290b3b6f1990ae543f2d8b4e1eb463/0.jpg','time_slot':'2016-05-23T22:10:00Z','recorded_at':'2016-05-23T22:11:15Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173202151,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/3012270d9192734d93d861ed0eb9de66d68721ca/0.jpg','time_slot':'2016-05-23T22:20:00Z','recorded_at':'2016-05-23T22:23:05Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173209073,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/5f482abab2d06ec9d21837bb064e2407ba86cb4a/0.jpg','time_slot':'2016-05-23T22:30:00Z','recorded_at':'2016-05-23T22:38:57Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173209082,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/fe8468512d27fb73f5b11224f8319901831e7243/0.jpg','time_slot':'2016-05-23T22:40:00Z','recorded_at':'2016-05-23T22:48:26Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173212560,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/cd51a2a8b0f381ee0cf535a807f3de3a7b9aae6a/0.jpg','time_slot':'2016-05-23T22:50:00Z','recorded_at':'2016-05-23T22:52:03Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173214487,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/ec4ad9d53abdc6ef0415f9b7f120234100e5c95b/0.jpg','time_slot':'2016-05-23T23:00:00Z','recorded_at':'2016-05-23T23:05:51Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173218383,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/aa8435d4e083915b96d4813dc969554b3ba8cec5/0.jpg','time_slot':'2016-05-23T23:10:00Z','recorded_at':'2016-05-23T23:12:51Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173218389,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/4a794505873b26e068256ddcb99b80be50cf152c/0.jpg','time_slot':'2016-05-23T23:20:00Z','recorded_at':'2016-05-23T23:20:54Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173222901,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/2419fd9aad3293a1322b45c8671caa471cf8f931/0.jpg','time_slot':'2016-05-23T23:30:00Z','recorded_at':'2016-05-23T23:35:04Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173225033,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/fad4d39d397276fac908a80fe56cc08453adcf9b/0.jpg','time_slot':'2016-05-23T23:40:00Z','recorded_at':'2016-05-23T23:42:35Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173227360,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/617337f02ca3bf3e7cf14b4fef6e75d7c6356d79/0.jpg','time_slot':'2016-05-23T23:50:00Z','recorded_at':'2016-05-23T23:51:45Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173233089,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/9c78aee48c75b8441a4d6fcfde11b4a92631df11/0.jpg','time_slot':'2016-05-24T00:00:00Z','recorded_at':'2016-05-24T00:05:03Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173233095,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/b49ef1b5b9fb33f1835c2a165c422059705bc5a9/0.jpg','time_slot':'2016-05-24T00:10:00Z','recorded_at':'2016-05-24T00:19:11Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173236951,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/bf60b31559277b2139fdb7949c14f598af35adcf/0.jpg','time_slot':'2016-05-24T00:20:00Z','recorded_at':'2016-05-24T00:28:51Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0},{'id':173236957,'url':'https://hubstaff-production.s3.amazonaws.com/screenshots/61188/2016/21/112761/e89877b6237e22e5dd54dd2eaf2e752290c775b7/0.jpg','time_slot':'2016-05-24T00:30:00Z','recorded_at':'2016-05-24T00:37:09Z','user_id':61188,'project_id':112761,'offset_x':0,'offset_y':0,'width':1440,'height':900,'screen':0}]}");
        }
        public virtual JObject notes(string starttime, string stoptime, Dictionary<string, string> options,int offset = 0)
        {
            return JObject.Parse("{'notes':[{'id':716530,'description':'Practice Notes','time_slot':'2016-05-23T22:20:00Z','recorded_at':'2016-06-04T19:08:22Z','user_id':61188,'project_id':112761}]}");
        }

        public virtual JObject find_note(int id)
        {
            return JObject.Parse("{'note':{'id':716530,'description':'Practice Notes','time_slot':'2016-05-23T22:20:00Z','recorded_at':'2016-06-04T19:08:22Z','user_id':61188,'project_id':112761}}");
        }

        public virtual JObject weekly_team(Dictionary<string, string> options)
        {
            return JObject.Parse("{'organizations':[]}");
        }
        public virtual JObject weekly_my(Dictionary<string, string> options)
        {
            return JObject.Parse("{'organizations':[]}");
        }

        public virtual JObject custom_date_team(string start_date, string end_date, Dictionary<string, string> options)
        {
            return JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','duration':7874,'activity_percent':38,'dates':[{'date':'2016-05-23','duration':7874,'activity_percent':38,'users':[{'id':61188,'name':'Raymond Cudjoe','duration':7874,'activity_percent':38,'projects':[{'id':112761,'name':'Build Ruby Gem','duration':7874,'activity_percent':38,'notes':[{'id':716530,'description':'Practice Notes'}]}]}]}]}]}");
        }

        public virtual JObject custom_date_my(string start_date, string end_date, Dictionary<string, string> options)
        {
            return JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','duration':7874,'activity_percent':38,'dates':[{'date':'2016-05-23','duration':7874,'activity_percent':38,'users':[{'id':61188,'name':'Raymond Cudjoe','duration':7874,'activity_percent':38,'projects':[{'id':112761,'name':'Build Ruby Gem','duration':7874,'activity_percent':38,'notes':[{'id':716530,'description':'Practice Notes'}]}]}]}]}]}");
        }
        public virtual JObject custom_member_team(string start_date, string end_date, Dictionary<string, string> options)
        {
            return JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','duration':7874,'activity_percent':38,'dates':[{'date':'2016-05-23','duration':7874,'activity_percent':38,'users':[{'id':61188,'name':'Raymond Cudjoe','duration':7874,'activity_percent':38,'projects':[{'id':112761,'name':'Build Ruby Gem','duration':7874,'activity_percent':38,'notes':[{'id':716530,'description':'Practice Notes'}]}]}]}]}]}");
        }

        public virtual JObject custom_member_my(string start_date, string end_date, Dictionary<string, string> options)
        {
            return JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','duration':7874,'activity_percent':38,'dates':[{'date':'2016-05-23','duration':7874,'activity_percent':38,'users':[{'id':61188,'name':'Raymond Cudjoe','duration':7874,'activity_percent':38,'projects':[{'id':112761,'name':'Build Ruby Gem','duration':7874,'activity_percent':38,'notes':[{'id':716530,'description':'Practice Notes'}]}]}]}]}]}");
        }
        public virtual JObject custom_project_team(string start_date, string end_date, Dictionary<string, string> options)
        {
            return JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','duration':7874,'activity_percent':38,'dates':[{'date':'2016-05-23','duration':7874,'activity_percent':38,'users':[{'id':61188,'name':'Raymond Cudjoe','duration':7874,'activity_percent':38,'projects':[{'id':112761,'name':'Build Ruby Gem','duration':7874,'activity_percent':38,'notes':[{'id':716530,'description':'Practice Notes'}]}]}]}]}]}");
        }
        public virtual JObject custom_project_my(string start_date, string end_date, Dictionary<string, string> options)
        {
            return JObject.Parse("{'organizations':[{'id':27572,'name':'Hook Engine','duration':7874,'activity_percent':38,'dates':[{'date':'2016-05-23','duration':7874,'activity_percent':38,'users':[{'id':61188,'name':'Raymond Cudjoe','duration':7874,'activity_percent':38,'projects':[{'id':112761,'name':'Build Ruby Gem','duration':7874,'activity_percent':38,'notes':[{'id':716530,'description':'Practice Notes'}]}]}]}]}]}");
        }
    }
}
