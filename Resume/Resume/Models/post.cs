using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Models
{
    public class post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string ApplyDate { get; set; }
        public int ResumeId { get; set; }
        public virtual blog Blog { get; set; }
    }
}