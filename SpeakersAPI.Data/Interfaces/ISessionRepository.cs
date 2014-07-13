using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeakersAPI.Data.Interfaces
{
    public interface ISessionRepository
    {
        SessionDocument GetSessionByName(string nameOfDocument);
        SessionDocument GetSessionById(string id);
        IEnumerable<SessionDocument> GetAllSessions();
    }
}
