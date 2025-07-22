using Models;
using System.Collections.Generic;

namespace Services
{
    public class EventService
    {
        public List<Event> Events { get; set; } = new();

        public void AddEvent(Event ev)
        {
            Events.Add(ev);
        }

        public Event GetEvent(int index)
        {
            return Events.Count > index ? Events[index] : null;
        }
    }
}
