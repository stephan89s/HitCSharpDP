using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    public class ApplicationEvent : IPublishable
    {
        public string Name { get; }
        public string Description { get; }
        public DateTime? StartTime { get; }
        public DateTime? EndTime { get; }
        private readonly string r_EventID;

        public ApplicationEvent(Event i_Event)
        {
            Name = i_Event.Name != null? i_Event.Name : string.Empty;
            Description = i_Event.Description != null ? i_Event.Description : string.Empty;
            StartTime = i_Event.StartTime;
            EndTime = i_Event.EndTime;
            r_EventID = i_Event.Id;
        }

        public string GetPublishedItemID()
        {
            return r_EventID;
        }
    }
}
