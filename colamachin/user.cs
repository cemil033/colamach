using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colamachin
{
    public class user
    {
        public List<alinan> alinanlar { get; set; }
        public double yekun_mebleg { get; set; }
        public double odenmis { get; set; }
        public double qaliq { get; set; }
        public user()
        {
            alinanlar = new List<alinan>();
        }
    }
}
