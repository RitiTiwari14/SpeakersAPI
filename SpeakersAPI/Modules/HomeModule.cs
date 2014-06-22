using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace SpeakersAPI.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["Index"];
            };
        }
    }
}