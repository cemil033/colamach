using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colamachin
{
    public class database
    {
        public List<user> users { get; set; }
        public database()
        {
            users = new List<user>();
        }
    }
}
