using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven.Client;

namespace SpeakersAPI.Data
{
    public class SessionRepository
    {
        private readonly IDocumentStore _documentStore;

        public SessionRepository(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
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

    public class SessionDocument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set; }
    }
}
