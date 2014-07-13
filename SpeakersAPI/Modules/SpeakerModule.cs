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
        private readonly SpeakerRepository _speakerRepository;

        public SpeakerModule(RavenDBConfigurationWrapper ravenDbConfiguration)
        {
            _speakerRepository = new SpeakerRepository(ravenDbConfiguration.DocumentStore);

            Get["/speakers"] = parameter =>
            {
                return _speakerRepository.GetAllSpeakers();
            };

            Get["/speakers/{id}"] = parameter =>
            {
                return _speakerRepository.GetSpeakerById(parameter.id);                    
            };
        }
    }
}