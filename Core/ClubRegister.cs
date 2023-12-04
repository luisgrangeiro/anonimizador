using System;
using System.Collections.Generic;

namespace Core
{
    public class ClubRegister
    {
        public User User { get; set; }
        public List<Sport> Sports { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }

    }
}
