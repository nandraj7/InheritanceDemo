using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Teacher
    {
        public void GateData()
        {

        }

        public void Putdata()
        {

        }

    }
    public class ParamanatTeacher : Teacher
    {
        void function1()
        {

        }
    }



    internal class Parent
    {
        public Parent(int id)     //Consturctor
        {
            this.Id = id;
        }

        //Data Members
        public int Id { get; set; }

        //Member Functions
        public void Function1()
        {

           // ValueType;
            Console.WriteLine("Parent Class Function 1");
        }
        public void Function2()
        {
            Console.WriteLine("Parent Class Function 2");
        }
    }
    internal class Child : Parent
    {
        public Child() : base(20)     //Consturctor
        {
            this.Name = "Ajay";
        }
        //Data Members
        public string Name { get; set; }

        //Member Functions
        public void Function3()
        {
            Console.WriteLine("Child Class Function 3");
            Console.WriteLine("Name= " + Name);
            Console.WriteLine("Id= " + Id);

            Function1();
        }
        public void Function4(int num1, int num2, string operation)     //Formal paramters
        {
            if (operation == "Add")
            {
                int result = num1 + num2;
            }


            if (operation == "Sub")
            {
                int result = num1 - num2;
            }

            Console.WriteLine("Child Class Function 4");
        }
    }  
}
