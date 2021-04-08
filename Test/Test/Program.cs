using System;
/* 
    Tipuri referentiale si tipuri valorice
    Tipuri valorice: tipuri de baza, struct si enum.
    Tipuri referentiale: class, interface si delegate.

    ** Tipurile referentiale sunt instantiate doar cu new => sunt stocate in heap
       Tipurile valorice se genereaza pe stiva.
*/
namespace Test
{
    class Class1
    {
        public int Val = 0;
    }
    struct Struct1
    {
        public int Val;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Struct1 tv1; tv1.Val = 0;
            Struct1 tv2 = tv1;
            tv2.Val = 123;
            Class1 tr1 = new Class1();
            Class1 tr2 = tr1;
            tr2.Val = 123;
            Console.WriteLine("Valoric: {0}, {1}", tv1.Val, tv2.Val);
            Console.WriteLine("Referential : {0}, {1}", tr1.Val, tr2.Val);
         
        }
    }
}
