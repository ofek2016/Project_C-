using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ofek1
{
    class Organizations
    {
        private List<Castro> castros;//all castro stores
        private List<Store> stores;//all general stores
        private List<School> schools;//all schools

        //constructor
        public Organizations()
        {
            Castros = new List<Castro>();
            Stores = new List<Store>();
            Schools = new List<School>();
        }
        //constructor
        public Organizations(List<Castro> castros, List<Store> stores, List<School> schools)
        {
            this.Castros = castros;
            this.Stores = stores;
            this.Schools = schools;
        }
        //constructor
        public Organizations(List<Castro> castros)
        {
            this.Castros = castros;
            Stores = new List<Store>();
            Schools = new List<School>();
        }
        //search school by manager name
        public School SearchSchool(string managerName)
        {
            foreach (School s in Schools)
                if (s.ManagerName == managerName)
                    return s;
            return null;
        }
        //get/set to schools list
        public List<School> Schools
        {
            get
            {
                return schools;
            }
            set
            {
                if (value.Count > 1000)
                    throw new Exception("Schools cannot be larger the 1K");
                schools = value;
            }
        }
        //get/set to stores list
        public List<Store> Stores
        {
            get
            {
                return stores;
            }
            set
            {
                if (value.Count > 1000)
                    throw new Exception("Stores cannot be larger the 1K");
                stores = value;
            }
        }
        //get/set to castros list
        public List<Castro> Castros
        {
            get
            {
                return castros;
            }
            set
            {
                if (value.Count>1000)
                    throw new Exception("Castros cannot be larger the 1K");
                castros = value;
            }
        }
        //add castro store
        public void AddCastro(Castro c)
        {
            Castros.Add(c);
        }
        //remove last added castro store
        public void RemoveLastCastro()
        {
            Castros.RemoveAt(castros.Count-1);
        }
        //add general store
        public void AddStroe(Store s)
        {
           Stores.Add(s);
        }
        //remove last added general store
        public void RemoveLastStore()
        {
            Stores.RemoveAt(stores.Count - 1);
        }
        //add school
        public void AddSchool(School s)
        {
            Schools.Add(s);
        }
        //remove last added school
        public void RemoveLastSchool()
        {
           Schools.RemoveAt(schools.Count - 1);
        }
        //print organization information
        public void Print()
        {
            foreach (School s in Schools)
                s.Print();
            foreach (Castro c in Castros)
                c.Print();
            foreach (Store s in Stores)
                s.Print();
        }
    }
}
