using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ofek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //organization instance
            Organizations organizations = new Organizations();
            List<Castro> castros_copy;
            List<Store> stores_copy;
            List<School> schools_copy;
            Stack<string> tshirt_copy;
            //some t shirts array
            string[] t_shirsts = new string[] { "white t shirt", "red t shirt" };
            for (int i = 0; i < 3; i++)
            {
                //castro store instance
                Castro castro = new Castro("castro " + (i + 1), RandomDate(), RandomName(), RandomBool());
                castro.AddTShirstFromArray(t_shirsts);
                castro.Add("t shirt "+(i+1));
                castro.RemoveNItems(1);
                Console.WriteLine(castro.OwnedByCountry);
                tshirt_copy = castro.ClosetTshirts;
                Console.WriteLine(castro.ToString());
                castro.Print();
                if(organizations.Castros.Count>0)
                    Console.WriteLine(organizations.Castros[0].CompareTo(castro));

                // store instance
                Store store = new Store("store " + (i + 1), RandomDate(), RandomName());
                if (organizations.Stores.Count > 0)
                    Console.WriteLine(organizations.Stores[0].CompareTo(store));
                Console.WriteLine(store.ToString());
                Console.WriteLine(store.Worth);
                store.AddWorth();
                store.AddWorth();
                store.SubstructWorth();
                Console.WriteLine(store.StoreName);
                Console.WriteLine(store.systemPurpose());

                //school instance
                School school = new School("school " + (i + 1), RandomDate(), RandomName());
                school.Print();
                if (organizations.Schools.Count > 0)
                    Console.WriteLine(organizations.Schools[0].CompareTo(school));
                Console.WriteLine(school.ToString());
                Console.WriteLine(school.Students);
                school.AddStudent(new Student());
                school.AddStudent(new Student());
                school.RemoveLastAdded();
                Console.WriteLine(school.ManagerName);
                Console.WriteLine(school.NumOfStudents);
                Console.WriteLine(school.systemPurpose());
                organizations.AddCastro(castro);
                organizations.AddStroe(store);
                organizations.AddSchool(school);

                School s = organizations.SearchSchool("some manager");
                if(s!=null)
                {
                    Console.WriteLine("found school with manger name");
                }
                else
                {
                    Console.WriteLine(" school with manger name didn't found");
                }
            }
            //print organization info
            organizations.Print();
            castros_copy = organizations.Castros;
            stores_copy = organizations.Stores;
            schools_copy = organizations.Schools;
            for (int i = 0; i < 3; i++)
            {
                organizations.RemoveLastSchool();
                organizations.RemoveLastCastro();
                organizations.RemoveLastStore();
            }
            organizations.Print();
            Console.ReadKey();
        }
        static Random rand = new Random();
        //generate random name
        public static string RandomName()
        {
            string[] names = new string[] { "avi", "yossi", "david", "moshe", "abraham", "adam", "tomer", "keshet", "ben", "tom" };
            return names[rand.Next(0, names.Length)];
        }
        //generate random number
        public static int RandomNumber()
        {
            return rand.Next(0, 1000);
        }
        //generate random bool
        public static bool RandomBool()
        {
            return rand.Next(0, 2) == 0 ? false : true;
        }
        //generate random date
        public static DateTime RandomDate()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rand.Next(range));
        }
    }
}
