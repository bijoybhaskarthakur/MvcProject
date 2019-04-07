using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class blog
    {
        public int ResumeId { get; set; }
        public string name { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }


        public State StudentState { get; set; }

        public virtual List<post> posts { get; set; }

    }

    public enum State
    {
        a,
        b,
        c,
        d,
        e,
        f
    }

}