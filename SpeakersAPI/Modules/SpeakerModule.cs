using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace SpeakersAPI.Modules
{
    public class SpeakerModule : NancyModule
    {
        public SpeakerModule()
        {
            Get["/speakers"] = parameter =>
            {
                return "some data of speakers";
            };

            Get["/speakers/{id}"] = parameter =>
            {
                return "some data of speker id : " + parameter.id;
            };
        }
    }
}