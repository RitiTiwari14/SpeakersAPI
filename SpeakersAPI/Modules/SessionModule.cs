using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace SpeakersAPI.Modules
{
    public class SessionModule : NancyModule 
    {
        public SessionModule()
        {
            Get["/sessions"] = parameter =>
            {
                return "some agenda data";
            };

            Get["/sessions/{id}"] = parameter =>
            {
                return "show session of id : " + parameter.id;
            };           
        }
    }
}