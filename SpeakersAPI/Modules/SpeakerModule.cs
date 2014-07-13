using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using SpeakersAPI.Data;
using SpeakersAPI.Data.Interfaces;

namespace SpeakersAPI.Modules
{
    public class SpeakerModule : NancyModule
    {
        private readonly ISpeakerRepository _speakerRepository;

        public SpeakerModule(ISpeakerRepository speakerRepository)
        {
            _speakerRepository = speakerRepository;

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