
using InheritanceDemo;

class Program
{
    public static void Main()
    {

        Child C = new Child();
        Parent P = new Parent();

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
           // C3 = C2;       //Referance Of The Class
    }
}
