using Raven.Client;
using Raven.Client.Embedded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeakersAPI.Data
{
    public class RavenDBConfigurationWrapper
    {
        public IDocumentStore DocumentStore { get; private set; }

        public RavenDBConfigurationWrapper()
        {
            DocumentStore = new EmbeddableDocumentStore()
            {
                DataDirectory= "Data",
                UseEmbeddedHttpServer = false,
            };

            DocumentStore.Initialize();
        }
    }
}
