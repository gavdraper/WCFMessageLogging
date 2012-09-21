using System.ServiceModel;
using System.ServiceModel.Dispatcher;

namespace WcfLoggingTakeTwo.MessageInspector
{
    public class Inspector : IDispatchMessageInspector
    {

        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            /* Add request Logging code here
             *  Message contents in request.ToString()
             */
            return null;
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            /* Add response logging code here
             * Response is in reply.ToString()
             */
        }
    }
}
