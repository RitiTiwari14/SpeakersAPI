using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeakersAPI.Data.Documents
{
    public class SessionDocument
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set; }
    }
}
