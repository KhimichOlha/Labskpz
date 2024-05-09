
namespace Composer
{
    public class EventListener : IObserver
    {
        private string _eventType;
        private Action<object> callback;
        public EventListener(string eventType, Action<object> callback)
        {
            _eventType = eventType;
            this.callback = callback;
        }

        public void Update(string eventType, object eventData)
        {
            if(_eventType == eventType)
            {
                callback.Invoke(eventData);
            }
        }
    }
}
