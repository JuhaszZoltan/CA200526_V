using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CA200526_V
{
    class Merkozes
    {
        public string HCsapat { get; set; }
        public string ICsapat { get; set; }
        public int HPont { get; set; }
        public int IPont { get; set; }
        public string Helyszin { get; set; }
        public DateTime Idopont { get; set; }

        public Merkozes(string sor)
        {
            var t = sor.Split(';');
            HCsapat = t[0];
            ICsapat = t[1];
            HPont = int.Parse(t[2]);
            IPont = int.Parse(t[3]);
            Helyszin = t[4];
            Idopont = DateTime.Parse(t[5]);
        }
    }
}
