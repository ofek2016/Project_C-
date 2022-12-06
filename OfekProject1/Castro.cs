using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ofek1
{
    internal class Castro : Store
    {
        //t shirts list
        private Stack<string> closetTshirts = new Stack<string>();
        //is companny owned by the country
        private bool ownedByCountry;

        //constructor
        public Castro(string name, DateTime established, string managerName,  bool ownedByCountry) : base(name, established, managerName)
        {
            OwnedByCountry = ownedByCountry;
        }
        //constructor
        public Castro(string name, DateTime established, string managerName, Stack<string> closetTshirts) : base(name, established, managerName)
        {
            ClosetTshirts = closetTshirts;
        }
        //add adding t shirts to the stack
        public void AddTShirstFromArray(string[] tshirts)
        {
            for (int i = 0; i < tshirts.Length; i++)
                ClosetTshirts.Push(tshirts[i]);
        }
        //add adding t shirt to the stack
        public void Add(string t)
        {
            ClosetTshirts.Push(t);
        }
        //remove n items from stack
        public void RemoveNItems(int n)
        {
            for (int i = 0; i < n && ClosetTshirts.Count > 0; i++)
                ClosetTshirts.Pop();
        }
        //is store owned by country
        public bool OwnedByCountry
        {
            get
            {
                return ownedByCountry;
            }
            set
            {
                ownedByCountry = value;
            }
        }
        //get and set to t shirts stack
        public Stack<string> ClosetTshirts
        {
            get
            {
                return closetTshirts;
            }
            set
            {
                if (value.Peek() == "")
                    throw new Exception("stack peek cannot be empty string");
                closetTshirts = value;
            }
        }
        //return to string  
        public override string ToString()
        {
            return base.ToString() + " castro num of t shirts: " + ClosetTshirts.Count + ",Owned by couontry:  " + OwnedByCountry;
        }
        //prints the tostring 
        public override void Print()
        {
            Console.WriteLine(ToString());
        }
        //comoare by number os shirts
        public override int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Castro s = obj as Castro;
            if (s != null)
                return ClosetTshirts.Count.CompareTo(s.ClosetTshirts.Count);
            else
                throw new ArgumentException("Object is not a castro store");
        }

    }
}
