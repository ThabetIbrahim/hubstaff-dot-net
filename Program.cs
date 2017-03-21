using System;
using System.Collections.Generic;
public class ProgramExample
{
        public void Main(string[] args)
        {     
	      var example = new example_space.Example();
              Dictionary<string, string> options = new Dictionary<string, string>();
              options["organizations"] = "";
              options["users"] = "";
              options["projects"] = "";
              string auth = example.auth("rkcudjoe@hookengine.com","hookdev001");
              example.screenshots("2016-09-01", "2016-09-07", 0, options, auth);
	}
}
