using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;
using System;
namespace aspnetcoreapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
              var example = new example_space.Example();
              Dictionary<string, string> options = new Dictionary<string, string>();
              options["organizations"] = "";
              options["users"] = "";
              options["projects"] = "";
              string auth = example.auth("Your username","Your password");
              example.screenshots("2016-09-01", "2016-09-07", 0, options, auth);

        }
    }
}