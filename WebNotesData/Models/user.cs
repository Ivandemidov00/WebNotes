
using System;
using System.Collections.Generic;
using System.Text;

namespace WebNotesData.Models
{
    public class user
    {
        public Int16 id { get; set; }
        public String name { get; set; }
        public List<posts> posts { get; set; }
    }
}
