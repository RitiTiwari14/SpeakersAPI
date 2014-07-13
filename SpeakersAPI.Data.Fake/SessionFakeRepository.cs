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

        public SessionDocument GetSessionByName(string nameOfDocument)
        {
            throw new NotImplementedException();
        }

        public SessionDocument GetSessionById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SessionDocument> GetAllSessions()
        {
            throw new NotImplementedException();
        }
    }
}
