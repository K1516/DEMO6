/* 
* 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajr1
{
    /// <summary>
    /// This class contains Person properties.
    /// </summary>
    class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Sotu { get; set; }

        public override string ToString()
        {
            return FName + "  " + LName + "  " + Sotu;
        }
    }

}
