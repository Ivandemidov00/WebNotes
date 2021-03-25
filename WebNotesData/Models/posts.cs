using System;
using System.Collections.Generic;
using System.Text;

namespace WebNotesData.Models
{
    public class posts
    {
        public Int16 id { get; set; }
        public String post { get; set; }
        public Int16 id_category { get; set; }
        public categories categories { get; set; }
        public Int16 id_user { get; set; }
        public user user { get; set; }
    }
}
