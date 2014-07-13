using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using SpeakersAPI.Data;
using SpeakersAPI.Data.Interfaces;

namespace SpeakersAPI.Modules
{
    public class SessionModule : NancyModule 
    {
        private readonly ISessionRepository _sessionRepository;

        public SessionModule(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;            

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