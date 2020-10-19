using System.Windows;
using Prism.Events;

namespace BE
{
    public class EventAggreegator : IEventAggregator
    {
        public TEventType GetEvent<TEventType>() where TEventType : EventBase, new()
        {
            throw new System.NotImplementedException();
        }
    }
}
