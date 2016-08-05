using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace hubstaff
{
    public class client
    {
        public client()
        {
            if(!Directory.Exists(config.root_folder+"store"))
            {
                Directory.CreateDirectory(config.root_folder+"store");
            }
        }
        
        public IServiceProvider serviceProvider;
        public string get_auth_token()
        {
            if(File.Exists(@"store/auth.txt"))
                return  System.IO.File.ReadAllText(@"store/auth.txt");
            else return "";
        }
        public void set_auth_token(string auth_token)
        {
            using (var stream = File.Open("store/auth.txt", FileMode.Create)) {
                byte[] info = new UTF8Encoding(true).GetBytes(auth_token);
                stream.Write(info,0,info.Length);
            }
        }
        public string get_app_token()
        {
            if(File.Exists(@"store/app.txt"))
                return System.IO.File.ReadAllText(@"store/app.txt");
            else return "";
        }
        public void set_app_token(string app_token)
        {
            
            using (var stream = File.Open("store/app.txt", FileMode.Create)) {
                byte[] info = new UTF8Encoding(true).GetBytes(app_token);
                stream.Write(info,0,info.Length);
            }
            
        }
        private config.config_class config = new config.config_class();

        public Dictionary<string, string> auth(string App_token, string email,string password)
        {
            auth_space.authClass _auth = new auth_space.authClass();
            Dictionary<string, string> returned_data = new Dictionary<string, string>();
            string auth = get_auth_token();
            set_app_token(App_token);
            if (auth.Length == 0)
            {
                var data = _auth.gen_auth(App_token, email, password, config.base_url + config.auth_url, 1).Result;
                JObject auth_token_json;
                if(data == "fail"){
                    returned_data["error"] =  "Error occured";
                    returned_data["auth_token"] =  null;
                    return returned_data;
                }else
                {
                    auth_token_json = JObject.Parse(data);
                }
                if(auth_token_json["error"] != null){
                    returned_data["error"] = auth_token_json["error"].ToString();
                }else
                    returned_data["auth_token"] = auth_token_json["user"]["auth_token"].ToString();
                set_auth_token(returned_data["auth_token"]);
            }
            else
            {
                 returned_data["auth_token"] = auth;
                 
            }           
            returned_data["error"] =  "";
            return returned_data;
        }

        public JObject users(int organization_memberships = 1, int project_memberships = 1,int offset = 0)
        {
            user_space.userClass _users = new user_space.userClass();
            Console.WriteLine(_users.get_users(get_app_token(), get_auth_token(), organization_memberships, project_memberships,offset, config.base_url + config.users).Result);
            return JObject.Parse(_users.get_users(get_app_token(), get_auth_token(), organization_memberships, project_memberships,offset, config.base_url + config.users).Result);
        }
        public JObject find_user(int id)
        {
            
            user_space.userClass _users = new user_space.userClass();
            return JObject.Parse(_users.find_user(get_app_token(), get_auth_token(), config.base_url + string.Format(config.find_user, id)).Result);
        }
        public JObject find_user_orgs(int id,int offset = 0)
        {
            user_space.userClass _users = new user_space.userClass();
            return JObject.Parse(_users.find_user_orgs(get_app_token(), get_auth_token(),offset,config.base_url + string.Format(config.find_user_org, id)).Result);
        }
        public JObject find_user_projects(int id, int offset = 0)
        {
            user_space.userClass _users = new user_space.userClass();
            return JObject.Parse(_users.find_user_projects(get_app_token(), get_auth_token(),offset,config.base_url + string.Format(config.find_user_projects, id)).Result);
        }

        public JObject organizations(int offset = 0)
        {
            orgs_space.orgsClass _org = new orgs_space.orgsClass();
            return JObject.Parse(_org.get_organizations(get_app_token(), get_auth_token(), offset, config.base_url + config.orgs).Result);
        }

        public JObject find_organization(int id)
        {
            orgs_space.orgsClass _org = new orgs_space.orgsClass();
            return JObject.Parse(_org.find_organization(get_app_token(), get_auth_token(), config.base_url + string.Format(config.find_org, id)).Result);
        }
        public JObject find_org_projects(int id,int offset = 0)
        {
            orgs_space.orgsClass _org = new orgs_space.orgsClass();
            return JObject.Parse(_org.find_org_projects(get_app_token(), get_auth_token(),offset,config.base_url + string.Format(config.find_org_proj, id)).Result);
        }
        public JObject find_org_members(int id, int offset = 0)
        {
            orgs_space.orgsClass _org = new orgs_space.orgsClass();
            return JObject.Parse(_org.find_org_members(get_app_token(), get_auth_token(),offset,config.base_url + string.Format(config.find_org_members, id)).Result);
        }

        public JObject projects(string status = "", int offset = 0)
        {
            projects_space.projectsClass _proj = new projects_space.projectsClass();
            return JObject.Parse(_proj.get_projects(get_app_token(), get_auth_token(), status, offset, config.base_url + config.proj).Result);
        }

        public JObject find_project(int id)
        {
            projects_space.projectsClass _proj = new projects_space.projectsClass();
            return JObject.Parse(_proj.find_project(get_app_token(), get_auth_token(), config.base_url + string.Format(config.find_proj, id)).Result);
        }
        public JObject find_project_members(int id, int offset = 0)
        {
            projects_space.projectsClass _proj = new projects_space.projectsClass();
            return JObject.Parse(_proj.find_project_members(get_app_token(), get_auth_token(),offset,config.base_url + string.Format(config.find_proj_members, id)).Result);
        }
        public JObject activities(string starttime, string stoptime, Dictionary<string, string> options,int offset = 0)
        {
            activities_space.activitiesClass _act= new activities_space.activitiesClass();
            return JObject.Parse(_act.get_activities(get_app_token(), get_auth_token(),starttime,stoptime,options,offset,config.base_url+config.activities).Result);
        }

        public JObject screehshots(string starttime, string stoptime, Dictionary<string, string> options, int offset = 0)
        {
            screenshots_space.screenshotsClass _screenshots= new screenshots_space.screenshotsClass();
            return JObject.Parse(_screenshots.get_screenshots(get_app_token(), get_auth_token(),starttime,stoptime,options,offset,config.base_url+config.screenshots).Result);
        }


        public JObject notes(string starttime, string stoptime, Dictionary<string, string> options,int offset = 0)
        {
            notes_space.notesClass _note = new notes_space.notesClass();
            return JObject.Parse(_note.get_notes(get_app_token(), get_auth_token(),starttime,stoptime,options,offset,config.base_url+config.screenshots).Result);
        }

        public JObject find_note(int id)
        {
            notes_space.notesClass _note = new notes_space.notesClass();
            return JObject.Parse(_note.find_note(get_app_token(), get_auth_token(), config.base_url + string.Format(config.find_note, id)).Result);
        }

        public JObject weekly_team(Dictionary<string, string> options)
        {
            weekly_space.weeklyClass _weekly = new weekly_space.weeklyClass();
            return JObject.Parse(_weekly.weekly_team(get_app_token(), get_auth_token(),options, config.base_url + config.weekly_team).Result);
        }
        public JObject weekly_my(Dictionary<string, string> options)
        {
            weekly_space.weeklyClass _weekly = new weekly_space.weeklyClass();
            return JObject.Parse(_weekly.weekly_my(get_app_token(), get_auth_token(),options, config.base_url + config.weekly_my).Result);
        }

        public JObject custom_date_team(string start_date, string end_date, Dictionary<string, string> options)
        {
            custom_space.customClass _custom = new custom_space.customClass();
            return JObject.Parse(_custom.custom(get_app_token(), get_auth_token(),start_date,end_date,options,config.base_url+config.custom_date_team).Result);
        }

        public JObject custom_date_my(string start_date, string end_date, Dictionary<string, string> options)
        {
            custom_space.customClass _custom = new custom_space.customClass();
            return JObject.Parse(_custom.custom(get_app_token(), get_auth_token(),start_date,end_date,options,config.base_url+config.custom_date_my).Result);
        }
        public JObject custom_member_team(string start_date, string end_date, Dictionary<string, string> options)
        {
            custom_space.customClass _custom = new custom_space.customClass();
            return JObject.Parse(_custom.custom(get_app_token(), get_auth_token(),start_date,end_date,options,config.base_url+config.custom_member_team).Result);
        }

        public JObject custom_member_my(string start_date, string end_date, Dictionary<string, string> options)
        {
            custom_space.customClass _custom = new custom_space.customClass();
            return JObject.Parse(_custom.custom(get_app_token(), get_auth_token(),start_date,end_date,options,config.base_url+config.custom_member_my).Result);
        }
        public JObject custom_project_team(string start_date, string end_date, Dictionary<string, string> options)
        {
            custom_space.customClass _custom = new custom_space.customClass();
            return JObject.Parse(_custom.custom(get_app_token(), get_auth_token(),start_date,end_date,options,config.base_url+config.custom_project_team).Result);
        }
        public JObject custom_project_my(string start_date, string end_date, Dictionary<string, string> options)
        {
            custom_space.customClass _custom = new custom_space.customClass();
            return JObject.Parse(_custom.custom(get_app_token(), get_auth_token(),start_date,end_date,options,config.base_url+config.custom_project_my).Result);
        }



    }
}
