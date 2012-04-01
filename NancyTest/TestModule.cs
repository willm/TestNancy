using System;

namespace NancyTest
{
	public class TestModule : Nancy.NancyModule
	{
		private Handler _myHandler;
				
		public TestModule ()
		{
			_myHandler=new Handler();
			Get["/"] = _ => _myHandler.Handle();
			
			Post["/"] = _ => "Thank you for your letter";
			
			Get["/view"] = _ => {return View["test"];};
		}
	}
	
	public class Handler{
		public string Handle(){
			return "Hello World";
		}
	}
}