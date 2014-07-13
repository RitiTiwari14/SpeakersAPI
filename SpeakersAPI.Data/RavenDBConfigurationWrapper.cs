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
        public readonly IDocumentStore DocumentStore;

        public RavenDBConfigurationWrapper()
        {
            DocumentStore = new EmbeddableDocumentStore()
            {
                DataDirectory = "Data",
                UseEmbeddedHttpServer = false,
            };

            try
            {
                DocumentStore.Initialize();
            }
            catch (Exception ex)
            {
                throw new RavenDBInitializeException();
            }
        }
    }

    public class RavenDBInitializeException : Exception
    {
    }
}
