using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Parent //: GrandParent
    {
        public Parent()     //Consturctor
        {
            this.Id = 10;
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
        public Child()     //Consturctor
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
        public void Function4()
        {
            Console.WriteLine("Child Class Function 4");
        }
    }  
}
