using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using SpeakersAPI.Data;

namespace SpeakersAPI.Modules
{
    public class SpeakerModule : NancyModule
    {
        public SpeakerModule(RavenDBConfigurationWrapper ravenDbConfiguration)
        {
            var speakerRepository = new SpeakerRepository(ravenDbConfiguration.DocumentStore);

            Get["/speakers"] = parameter =>
            {
                return speakerRepository.GetAllSpeakers();
            };

            Get["/speakers/{id}"] = parameter =>
            {
                return "some data of speker id : " + parameter.id;
            };
        }
    }
}