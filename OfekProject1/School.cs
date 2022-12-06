using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ofek1
{
    internal class School : ASystem, ItemsRemoveable
    {
        private string managerName;
        private int numOfStudents;
        private Student[] students = new Student[250];
        //contructor
        public School(string name, DateTime established, string managerName) : base(name, established)
        {
            this.managerName = managerName;
            numOfStudents = 0;
        }
        //contructor
        public School(string name, DateTime established, string managerName, int numOfStudents) : base(name, established)
        {
            this.managerName = managerName;
            this.numOfStudents = numOfStudents;
        }
        //contructor
        public School(string name, DateTime established, int numOfStudents) : base(name, established)
        {
            this.managerName = "default";
            this.numOfStudents = numOfStudents;
        }
        //print school info
        public void Print()
        {
            Console.WriteLine(ToString());
        }
        //compare to by date established
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            School s = obj as School;
            if (s != null)
                return Established.CompareTo(s.Established);
            else
                throw new ArgumentException("Object is not a School");
        }
        //return to string
        public override string ToString()
        {
            return base.ToString() + " Manager name: " + ManagerName + ", Number of s tudents: " + NumOfStudents;
        }
        //get set students array
        public Student[] Students
        {
            get
            {
                return students;
            }
            set
            {
                if (value.Length == 0)
                    throw new Exception("students array cannot be with length of zero");
                students = value;
            }
        }
        //remove last added student
        public void RemoveLastAdded()
        {
            Students[NumOfStudents] = null;
        }
        //add a student
        public void AddStudent(Student s)
        {
            if (NumOfStudents >= 250)
                throw new ArgumentException("school is full with students");
            Students[NumOfStudents++] = s;
        }
        //get / set manager name
        public string ManagerName
        {
            get
            {
                return managerName;
            }
            set
            {
                if (value.Length == 0)
                    throw new Exception("manager name cannot be empty");
                managerName = value;
            }
        }
        // get set number of students
        public int NumOfStudents
        {
            get
            {
                return numOfStudents;
            }
            set
            {
                if (value < 0)
                    throw new Exception("num of students cannot br negative");
                numOfStudents = value;
            }
        }

        // get system purpose
        public override string systemPurpose()
        {
            return "High school";
        }
    }
}
