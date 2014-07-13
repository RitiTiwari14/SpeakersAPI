using SpeakersAPI.Data.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeakersAPI.Data.Interfaces
{
    public interface ISpeakerRepository
    {
        IEnumerable<SpeakerDocument> GetAllSpeakers();
        SpeakerDocument GetSpeakerById(string id);
    }
}
