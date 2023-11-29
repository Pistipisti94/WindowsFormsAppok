using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLogin
{
    internal class Termekek
    {
        public string termeknev;
        public int ar;
        public int db;

        public Termekek(string termeknev, int ar, int db)
        {
            this.termeknev = termeknev;
            this.ar = ar;
            this.db = db;
        }
        public override string ToString()
        {
            return this.termeknev.ToUpper() + " " + this.ar.ToString("#00,.000") + " Forint " + this.db + " darab";
        }
    }
}
