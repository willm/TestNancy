using System;

namespace NancyTest
{
	public class TestModule : Nancy.NancyModule
	{
		public TestModule ()
		{
			Get["/"] = _ => "Hello World";
			
			Post["/"] = _ => "Thank you for your letter";
		}
	}
}

