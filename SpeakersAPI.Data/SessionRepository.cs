using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven.Client;
using SpeakersAPI.Data.Interfaces;
using SpeakersAPI.Data.Documents;

namespace SpeakersAPI.Data
{
    public class SessionRepository : ISessionRepository
    {
        private readonly IDocumentStore _documentStore;
        
        public SessionRepository(RavenDBConfigurationWrapper ravenDbConfiguration)
        {
            _documentStore = ravenDbConfiguration.DocumentStore;
        }

        public SessionDocument GetSessionByName(string nameOfDocument)
        {
            return GetAllSessions().First(session => session.Name == nameOfDocument);
        }

        public SessionDocument GetSessionById(string id)
        {
            SessionDocument result;
            var idOfDocument = string.Format("Speakerdocuments/{0}", id);
            try
            {
                using (var document = _documentStore.OpenSession())
                {
                    result = document.Load<SessionDocument>(idOfDocument);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public IEnumerable<SessionDocument> GetAllSessions()
        {
            IEnumerable<SessionDocument> result;

            try
            {
                using (var document = _documentStore.OpenSession())
                {
                    result = document.Query<SessionDocument>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

    }    
}
