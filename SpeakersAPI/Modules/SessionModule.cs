using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using SpeakersAPI.Data;

namespace SpeakersAPI.Modules
{
    public class SessionModule : NancyModule 
    {
        private readonly SessionRepository _sessionRepository;

        public SessionModule(RavenDBConfigurationWrapper ravenDbConfiguration)
        {
            _sessionRepository = new SessionRepository(ravenDbConfiguration.DocumentStore);

            Get["/sessions"] = parameter =>
            {
                return _sessionRepository.GetAllSessions();
            };

            Get["/sessions/{id}"] = parameter =>
            {
                return _sessionRepository.GetSessionById(parameter.id);
            };           
        }
    }
}