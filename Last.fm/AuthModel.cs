using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last.fm
{

    public class Session
    {
        public string name { get; set; }
        public string key { get; set; }
        public string subscriber { get; set; }
    }

    public class AuthModel
    {
        public Session session { get; set; }
    }
}
