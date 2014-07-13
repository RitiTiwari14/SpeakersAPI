using SpeakersAPI.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeakersAPI.Data.Documents;

namespace SpeakersAPI.Data.Fake
{
    public class SessionFakeRepository : ISessionRepository
    {
        private List<SessionDocument> _dataSource = new List<SessionDocument>
        {            
            new SessionDocument(){Name = "First session", Description = "first session about something", Id="SessionDocuments/1", DateOfStart=DateTime.Now, DateOfEnd=DateTime.Now},
            new SessionDocument(){Name = "Second session", Description = "second session about something", Id="SessionDocuments/2", DateOfStart=DateTime.Now, DateOfEnd=DateTime.Now},
            new SessionDocument(){Name = "Third session", Description = "third session about something", Id="SessionDocuments/3", DateOfStart=DateTime.Now, DateOfEnd=DateTime.Now},
            new SessionDocument(){Name = "Fourth session", Description = "fourth session about something", Id="SessionDocuments/4", DateOfStart=DateTime.Now, DateOfEnd=DateTime.Now},
        };

        public SessionDocument GetSessionByName(string nameOfDocument)
        {
            return new SessionDocument()
            {
                Name = "First session",
                Description = "first session about something",
                Id = "SessionDocuments/1",
                DateOfStart = DateTime.Now,
                DateOfEnd = DateTime.Now
            };
        }

        public SessionDocument GetSessionById(string id)
        {
            return new SessionDocument()
            {
                Name = "First session",
                Description = "first session about something",
                Id = "SessionDocuments/1",
                DateOfStart = DateTime.Now,
                DateOfEnd = DateTime.Now
            };
        }

        public IEnumerable<SessionDocument> GetAllSessions()
        {
            return _dataSource;
        }
    }
}
