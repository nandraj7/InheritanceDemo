
using InheritanceDemo;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        Teacher teacher = new Teacher();
    
        teacher.GateData();
        teacher.Putdata();








        Child C = new Child();

        string Operation = "Add";

        C.Function4(10, 20, Operation); //Actual paramters

        Parent P = new Parent(10);

        Child c1;
        Parent p1;


        //c1 = P;       //Invalid
        p1 = C;         //Valid
        //p1 Is The Variable of Parent Class But It's The Refernce Of Child Class

       //p1.Function3;  //



            //Child C;      //This is Variable
            
            //C = new Child();      //Instance Of The Class


            //Child C2 = new Child();     //Instance Of The Class

           // Child C3;       //Variable Of The Class
           //C3 = C2;       //Referance Of The Class
    }
}
