using Nancy;
using Raven.Client;
using SpeakersAPI.Data;
using SpeakersAPI.Data.Fake;
using SpeakersAPI.Data.Interfaces;

namespace SpeakersAPI
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper

        protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);
        }
        protected override void ConfigureApplicationContainer(Nancy.TinyIoc.TinyIoCContainer container)
        {
            container.Register<ISessionRepository, SessionFakeRepository>().AsMultiInstance();


            container.Register<RavenDBConfigurationWrapper>().AsSingleton();
        }
        
    }
}