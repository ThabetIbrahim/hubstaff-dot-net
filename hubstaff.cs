using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace aspnetcoreapp
{


    public class hubstaff_api
    {
        public IHttpContextAccessor _httpContextAccessor;

        void ServerSentEventController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        private config.config_class config = new config.config_class();

        public string auth()
        {
            auth_space.authClass _auth = new auth_space.authClass();
            var auth_token = "";
            if (config.auth_token == "")
            {
                JObject auth_token_json = JObject.Parse(_auth.gen_auth(config.App_token, config.email, config.password, config.base_url + config.auth_url, 1).Result);
                auth_token = auth_token_json["user"]["auth_token"].ToString();
            }
            else
            {
                auth_token = config.auth_token;
            }           
            return auth_token;
        }

        public string users(int offset = 0)
        {
            user_space.userClass _users = new user_space.userClass();
            return _users.get_users(config.App_token, config.auth_token, 0,0,offset, config.base_url + config.users).Result;
        }

        public string find_user(int id)
        {
            user_space.userClass _users = new user_space.userClass();
            return _users.find_user(config.App_token, config.auth_token, config.base_url + string.Format(config.find_user, id)).Result;
        }
        public string find_user_orgs(int id,int offset = 0)
        {
            user_space.userClass _users = new user_space.userClass();
            return _users.find_user_orgs(config.App_token, config.auth_token,offset,config.base_url + string.Format(config.find_user_org, id)).Result;
        }
        public string find_user_projects(int id, int offset = 0)
        {
            user_space.userClass _users = new user_space.userClass();
            return _users.find_user_projects(config.App_token, config.auth_token,offset,config.base_url + string.Format(config.find_user_projects, id)).Result;
        }

        public string organizations(int offset = 0)
        {
            orgs_space.orgsClass _org = new orgs_space.orgsClass();
            return _org.get_organizations(config.App_token, config.auth_token, offset, config.base_url + config.orgs).Result;
        }

        public string find_organization(int id)
        {
            orgs_space.orgsClass _org = new orgs_space.orgsClass();
            return _org.find_organization(config.App_token, config.auth_token, config.base_url + string.Format(config.find_org, id)).Result;
        }
        public string find_org_projects(int id,int offset = 0)
        {
            orgs_space.orgsClass _org = new orgs_space.orgsClass();
            return _org.find_org_projects(config.App_token, config.auth_token,offset,config.base_url + string.Format(config.find_org_proj, id)).Result;
        }
        public string find_org_members(int id, int offset = 0)
        {
            orgs_space.orgsClass _org = new orgs_space.orgsClass();
            return _org.find_org_members(config.App_token, config.auth_token,offset,config.base_url + string.Format(config.find_org_members, id)).Result;
        }

        public string projects(string status = "", int offset = 0)
        {
            projects_space.projectsClass _proj = new projects_space.projectsClass();
            return _proj.get_projects(config.App_token, config.auth_token, status, offset, config.base_url + config.proj).Result;
        }

        public string find_project(int id)
        {
            projects_space.projectsClass _proj = new projects_space.projectsClass();
            return _proj.find_project(config.App_token, config.auth_token, config.base_url + string.Format(config.find_proj, id)).Result;
        }
        public string find_project_members(int id, int offset = 0)
        {
            projects_space.projectsClass _proj = new projects_space.projectsClass();
            return _proj.find_project_members(config.App_token, config.auth_token,offset,config.base_url + string.Format(config.find_proj_members, id)).Result;
        }
        public string activities(string starttime, string stoptime, Dictionary<string, string> options,int offset = 0)
        {
            activities_space.activitiesClass _act= new activities_space.activitiesClass();
            return _act.get_activities(config.App_token, config.auth_token,starttime,stoptime,options,offset,config.base_url+config.activities).Result;
        }

        public string screehshots(string starttime, string stoptime, Dictionary<string, string> options,int offset = 0)
        {
            screenshots_space.screenshotsClass _screenshots= new screenshots_space.screenshotsClass();
            return _screenshots.get_screenshots(config.App_token, config.auth_token,starttime,stoptime,options,offset,config.base_url+config.screenshots).Result;
        }


        public string notes(string starttime, string stoptime, Dictionary<string, string> options,int offset = 0)
        {
            notes_space.notesClass _note = new notes_space.notesClass();
            return _note.get_notes(config.App_token, config.auth_token,starttime,stoptime,options,offset,config.base_url+config.screenshots).Result;
        }

        public string find_note(int id)
        {
            notes_space.notesClass _note = new notes_space.notesClass();
            return _note.find_note(config.App_token, config.auth_token, config.base_url + string.Format(config.find_note, id)).Result;
        }

        public string weekly_team(Dictionary<string, string> options)
        {
            weekly_space.weeklyClass _weekly = new weekly_space.weeklyClass();
            return _weekly.weekly_team(config.App_token, config.auth_token,options, config.base_url + config.weekly_team).Result;
        }
        public string weekly_my(Dictionary<string, string> options)
        {
            weekly_space.weeklyClass _weekly = new weekly_space.weeklyClass();
            return _weekly.weekly_my(config.App_token, config.auth_token,options, config.base_url + config.weekly_my).Result;
        }

        public string custom_date_team(string start_date, string end_date, Dictionary<string, string> options)
        {
            custom_space.customClass _custom = new custom_space.customClass();
            return _custom.custom(config.App_token, config.auth_token,start_date,end_date,options,config.base_url+config.custom_date_team).Result;
        }

        public string custom_date_my(string start_date, string end_date, Dictionary<string, string> options)
        {
            custom_space.customClass _custom = new custom_space.customClass();
            return _custom.custom(config.App_token, config.auth_token,start_date,end_date,options,config.base_url+config.custom_date_my).Result;
        }
        public string custom_member_team(string start_date, string end_date, Dictionary<string, string> options)
        {
            custom_space.customClass _custom = new custom_space.customClass();
            return _custom.custom(config.App_token, config.auth_token,start_date,end_date,options,config.base_url+config.custom_member_team).Result;
        }

        public string custom_member_my(string start_date, string end_date, Dictionary<string, string> options)
        {
            custom_space.customClass _custom = new custom_space.customClass();
            return _custom.custom(config.App_token, config.auth_token,start_date,end_date,options,config.base_url+config.custom_member_my).Result;
        }
        public string custom_project_team(string start_date, string end_date, Dictionary<string, string> options)
        {
            custom_space.customClass _custom = new custom_space.customClass();
            return _custom.custom(config.App_token, config.auth_token,start_date,end_date,options,config.base_url+config.custom_project_team).Result;
        }
        public string custom_project_my(string start_date, string end_date, Dictionary<string, string> options)
        {
            custom_space.customClass _custom = new custom_space.customClass();
            return _custom.custom(config.App_token, config.auth_token,start_date,end_date,options,config.base_url+config.custom_project_my).Result;
        }



    }
}