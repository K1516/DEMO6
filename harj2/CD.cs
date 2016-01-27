using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj2
{
    class CD
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public override string ToString()
        {
            return Artist + "  " + Album;
        }
    }
}
