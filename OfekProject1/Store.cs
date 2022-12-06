using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ofek1
{
    internal class Store : ASystem, IStock
    {
        private string managerName;
        private int worth;

        //contructor
        public Store(string name, DateTime established, string managerName) : base(name, established)
        {
            this.managerName = managerName;
            worth = 0;
        }
        //contructor
        public Store(string name, DateTime established, string managerName, int worth) : base(name, established)
        {
            this.managerName = managerName;
            this.worth = worth;
        }
        //contructor
        public Store(string name, DateTime established, int worth) : base(name, established)
        {
            this.managerName = "default store";
            this.worth = worth;
        }
        //comapre to by worth value
        public virtual int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Store s = obj as Store;
            if (s != null)
                return Worth.CompareTo(s.Worth);
            else
                throw new ArgumentException("Object is not a store");
        }
        //return tostring
        public override string ToString()
        {
            return base.ToString() + " Store name: " + StoreName + ", Store worth: " + Worth;
        }
        // get / set worth value
        public int Worth
        {
            get
            {
                return worth;
            }
            set
            {
                if (value > 1000000)
                    throw new Exception("Worth cannot be larger the 1M");
                worth = value;
            }
        }
        // add 10 to worth value
        public void AddWorth()
        {
            Worth += 10;
        }
        //print infomation
        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }
        //substructe from store value
        public void SubstructWorth()
        {
            if (Worth <0)
                throw new ArgumentException("Worth cannot be negative");
            Worth -= 10;
        }
        // get set store name
        public string StoreName
        {
            get
            {
                return managerName;
            }
            set
            {
                if (value.Length == 0)
                    throw new Exception("Store name cannot be empty");
                managerName = value;
            }
        }


        // get syste, purpose
        public override string systemPurpose()
        {
            return "Store in stock market";
        }
    }
}
