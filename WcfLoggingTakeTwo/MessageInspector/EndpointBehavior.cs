using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace WcfLoggingTakeTwo.MessageInspector
{
    public class EndpointBehavior : IServiceBehavior
    {
        public void AddBindingParameters(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            return;
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
            foreach (ChannelDispatcher c in serviceHostBase.ChannelDispatchers)
            {
                foreach (EndpointDispatcher e in c.Endpoints)
                {
                    e.DispatchRuntime.MessageInspectors.Add(new Inspector());
                }
            }
        }

        public void Validate(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
            return;
        }
    }
}
