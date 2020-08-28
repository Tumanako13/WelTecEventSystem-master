using System;
using System.Collections.Generic;

namespace WelTecEventSystem.Models
{
    public partial class User
    {
        public User()
        {
            Register = new HashSet<Register>();
        }

        public string UserName { get; set; }
        public string UserMainEmail { get; set; }
        public string UserSecondEmail { get; set; }

        public virtual ICollection<Register> Register { get; set; }
    }
}
