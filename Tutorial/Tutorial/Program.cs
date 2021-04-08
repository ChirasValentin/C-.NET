using System;
/*
    Tipuri valorice: sunt manipulate direct
    Tipuri referentiale: sunt alocate dinamic si manipulate prin referinte

    Tipuri valorice: tipuri de baza + struct + enum.
    Tipuri referentiale: class,interface,delegate.
*/
namespace Tutorial
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
            Struct1 tv1;
            tv1.Val = 0;
            Struct1 tv2 = tv1;
            tv2.Val = 123;

            Class1 tr1 = new Class1();
            Class1 tr2 = tr1;
            tr2.Val = 123;

            Console.WriteLine("Valoric: {0},{1}", tv1.Val, tv2.Val);
            Console.WriteLine("Referential: {0},{1}", tr1.Val, tr2.Val);
            Console.Read();
        }
    }
}
