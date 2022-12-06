using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ofek1
{
    abstract class ASystem
    {
        string sname;
        DateTime established;

        public string SName
        {
            get { return sname; }
            set
            {
                if (value == null) throw new ArgumentNullException("Null name");
                sname = value;
            }
        }

        public DateTime Established
        {
            get { return established; }
            set
            {
                if (value == null) throw new ArgumentNullException("Null DateTime Value is not allowed");
                established = value;
            }
        }

        public ASystem(string name, DateTime established)
        { SName = name; Established = established; }

        public ASystem(string name)
        { SName = name; established = DateTime.Now; }


        // string with information about system usage
        public abstract string systemPurpose();

        public override string ToString()
        { return sname + " exist since " + established.ToShortDateString(); }
    }


}
