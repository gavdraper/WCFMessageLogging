using System;
using System.ServiceModel.Configuration;

namespace WcfLoggingTakeTwo.MessageInspector
{
    public class BehaviorExtension : BehaviorExtensionElement
    {
        protected override object CreateBehavior()
        {
            return new EndpointBehavior();
        }
        public override Type BehaviorType
        {
            get
            {
                return typeof(EndpointBehavior);
            }
        }
    }
}
