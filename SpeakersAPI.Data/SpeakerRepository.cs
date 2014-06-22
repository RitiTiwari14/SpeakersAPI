using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven;
using Raven.Client.Embedded;
using SpeakersAPI.Data.Documents;
using Raven.Client;
namespace SpeakersAPI.Data
{
    public class SpeakerRepository
    {
        private readonly IDocumentStore _documentStore;

        public SpeakerRepository(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
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
    }
}
