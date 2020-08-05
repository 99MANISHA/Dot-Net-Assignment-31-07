using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    class Person
    {
        int age;
        string fname;
        string lname;
        string city;
        public Person()
        {

        }
        public Person(int _age, string _fname, string _lname, string _city)
        {
            age = _age;
            fname = _fname;
            lname = _lname;
            city = _city;
        }
        public void Display()
        {
            Console.WriteLine("age:{0}", age);
            Console.WriteLine("firstname:{0}", fname);
            Console.WriteLine("last name:{0}", lname);
            Console.WriteLine("city:{0}", city);

        }
        public static void Main()
        {
            List<Person> Persons = new List<Person>();
            Person per1 = new Person(21, "Lakshmi", "Manisha", "Pavuluri");
            Person per2 = new Person(22, "Manu", "Pavuluri","venkata");
            Person per3 = new Person(23, "Tarak", "Sai", "Kantamneni");
            Person per4 = new Person(24, "Bhanu", "Mouthinka", "Devarapu");
            Person per5 = new Person(25, "Nuthan","sai", "Pavuluri");



            Persons.Add(per1);
            Persons.Add(per2);
            Persons.Add(per3);
            Persons.Add(per4);
            Persons.Add(per5);



            foreach (Person p in Persons)
            {
                p.Display();
            }
        }
    }
}