# Hubstaff ASP.NET Client

An ASP.NET toolkit for Hubstaff API.

## Installation

Include the ```hubstaff.cs``` file in your project.

## Usage

Calls for Hubstuff API v1 are relative to the base url https://api.hubstaff.com/v1/

API actions are available as methods on the client object. Currently, the Hubstaff client has the following methods:

| Action               	                   | Method             					                             |
|:-----------------------------------------|:----------------------------------------------------------|
| **Users**                                |                   					                               |
| List users          	                   | `#users(org_member, project_member, offset)`              |
| Find a user          	                   | `#find_user(user_id)`                                     |
| Find a users organizations    	         | `#find_user_orgs(user_id, offset)`                        |
| Find a users projects                    | `#find_user_projects(user_id, offset)`                    |
| **Organizations**                        |                   					                               |
| List organizations                       | `#organizations(offset)`                                  |
| Find a organization                      | `#find_organization(org_id)`                              |
| Find a organization projects 	           | `#find_org_projects(org_id, offset)`                      |
| Find a organization members              | `#find_org_members(org_id, offset)`                       |
| **Projects**                             |                   					                               |
| List projects                            | `#projects(active, offset)`                               |
| Find a project                           | `#find_project(project_id)`                               |
| Find a project members                   | `#find_project_members(project_id, offset)`               |
| **Activities**                           |                   					                               |
| List activities                          | `#activities(start_time, stop_time, offset, options={})`  |
| **Screenshots**                          |                    					                             | 
| List Screenshots                         | `#screenshots(start_time, stop_time, offset, options={})` |
| **Notes**                                |                   					                               |
| List notes                               | `#notes(start_time, stop_time, offset, options={})`       |
| Find a note                              | `#find_note(note_id)`                                     |
| **Weekly Reports**                       |                   					                               |
| List weekly team report                  | `#weekly_team(options={})`                                |
| List weekly individual report            | `#weekly_my(options={})`                                  |
| **Custom Reports**                       |                   					                               |
| List custom team report by date          | `#custom_date_team(start_date, end_date, options={})`     |
| List custom individual report by date    | `#custom_date_my(start_date, end_date, options={})`       |
| List custom team report by member        | `#custom_member_team(start_date, end_date, options={})`   |
| List custom individual report by member  | `#custom_member_my(start_date, end_date, options={})`     |
| List custom team report by project       | `#custom_project_team(start_date, end_date, options={})`  |
| List custom individual report by project | `#custom_project_my(start_date, end_date, options={})`    |

## Usage Examples

### Authentication

First, grab your personal ``APP_TOKEN`` found in [your account settings](https://developer.hubstaff.com/) and initialize a new client with your ``APP_TOKEN``.

After that, you'll authenticate the client and start exporting data from your account.

```
How can you initialize a new client?
How can you authenticate the clients?
How can you change the user for the current client without initializing a new client?
How can get the auth_token for the current client?
```

### You can list all users for a specific account, and get the details about the organization, and the projects they've worked on

```C#
hubstaff.client hubstaff_api = new hubstaff.client("< your hubstaff app token >");
hubstaff_api.users(1,1,0);
# => {"users": [{ "id":..., "organanizations": ["id":...], "projects": ["id":...]}]}

```

### You can find specific users by their``user_id``.

```C#
hubstaff.client hubstaff_api = new hubstaff.client("< your hubstaff app token >");
hubstaff_api.find_user(61188);

# => {"user": { "id":...}}
```

### You can list all active projects.

```C#


```

### Retrieve screenshots for a specific project, within a specific timeframe.

```C#


```
