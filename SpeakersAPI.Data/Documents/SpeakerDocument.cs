using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeakersAPI.Data.Documents
{
    public class SpeakerDocument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public string ExternalLink { get; set; }
    }
}
