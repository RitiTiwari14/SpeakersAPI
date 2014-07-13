using SpeakersAPI.Data.Documents;
using SpeakersAPI.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeakersAPI.Data.Fake
{
    public class SpeakerFakeRepository : ISpeakerRepository
    {
        private List<SpeakerDocument> _dataSource = new List<SpeakerDocument>()
        {
            new SpeakerDocument(){Id = "SpeakerDocuments/1", Name = "Kung-fu Panda", CompanyName="Cartoon", Description = "Super panda", ExternalLink="http://kungfupanda.com"},
            new SpeakerDocument(){Id = "SpeakerDocuments/2", Name = "Kung-fu Turtle", CompanyName="Cartoon", Description = "Super turtle", ExternalLink="http://kungfupanda.com"},
            new SpeakerDocument(){Id = "SpeakerDocuments/3", Name = "Kung-fu Mouse", CompanyName="Cartoon", Description = "Super mouse", ExternalLink="http://kungfupanda.com"},
            new SpeakerDocument(){Id = "SpeakerDocuments/4", Name = "Kung-fu Bird", CompanyName="Cartoon", Description = "Super bird", ExternalLink="http://kungfupanda.com"},
        };

        public IEnumerable<Documents.SpeakerDocument> GetAllSpeakers()
        {
            return _dataSource;
        }

        public Documents.SpeakerDocument GetSpeakerById(string id)
        {
            return new SpeakerDocument()
            {
                Id = "SpeakerDocuments/1",
                Name = "Kung-fu Panda",
                CompanyName = "Cartoon",
                Description = "Super panda",
                ExternalLink = "http://kungfupanda.com"
            };
        }
    }
}
