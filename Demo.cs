using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Demo
    {
        internal class GrandParent
        {
            public void Function1()
            { 
            
            }
            public void Function2()
            {

            }

        }
        internal class Parent : GrandParent
        {
            public void Function3()
            {

            }
            public void Function4()
            {

            }
        }
        internal class Child1 : Parent
        {
            public void Function5()
            {

            }
            public void Function6()
            {

            }
        }
        internal class Child2 : Parent
        {
            public void Function7()
            {
            }
            public void Function8()
            {
            }

        }

    }
}
