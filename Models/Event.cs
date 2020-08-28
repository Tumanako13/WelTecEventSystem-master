using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WelTecEventSystem.Models
{
    public partial class Event
    {
        public Event()
        {
            Register = new HashSet<Register>();
        }

        public string EventName { get; set; }
        public string EventType { get; set; }
        public string EventDescription { get; set; }

        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan EventTime { get; set; }
        public byte[] EventImage1 { get; set; }
        public byte[] EventImage2 { get; set; }
        public byte[] EventImage3 { get; set; }
        public string EventLocation { get; set; }
        public string EventClassroom { get; set; }
        public string EventHost { get; set; }
        public string EventRequirements { get; set; }
        public int? MaxNumberOfParticipants { get; set; }

        public virtual ICollection<Register> Register { get; set; }
    }
}