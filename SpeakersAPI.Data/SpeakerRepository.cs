using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven;
using Raven.Client.Embedded;
using SpeakersAPI.Data.Documents;
using Raven.Client;
using SpeakersAPI.Data.Interfaces;
namespace SpeakersAPI.Data
{
    public class SpeakerRepository : ISpeakerRepository
    {
        private readonly IDocumentStore _documentStore;

        public SpeakerRepository(RavenDBConfigurationWrapper ravenDbConfiguration)
        {
            _documentStore = ravenDbConfiguration.DocumentStore;
        }

        public IEnumerable<SpeakerDocument> GetAllSpeakers()
        {
            IEnumerable<SpeakerDocument> result;
            try
            {
                using (var document = _documentStore.OpenSession())
                {
                    result = document.Query<SpeakerDocument>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public SpeakerDocument GetSpeakerById(string id)
        {
            SpeakerDocument result;
            var idOfDocument = string.Format("Speakerdocuments/{0}", id);
            try
            {
                using (var document = _documentStore.OpenSession())
                {
                    result = document.Load<SpeakerDocument>(idOfDocument);
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
