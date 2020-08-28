using System;
using System.Collections.Generic;

namespace WelTecEventSystem.Models
{
    public partial class Register
    {
        public int Id { get; set; }
        public string UserMainEmail { get; set; }
        public string EventName { get; set; }

        public virtual Event EventNameNavigation { get; set; }
        public virtual User UserMainEmailNavigation { get; set; }
    }
}
