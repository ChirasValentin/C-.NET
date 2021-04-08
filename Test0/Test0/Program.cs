using System;
/* 
 Crearea de noit tipuri valorice si referentiale
       + Boxing and Unboxing
 */
namespace Test0
{
    public enum Color { Rosu,Albastru,Verde}
    public struct Point { public int x, y; }
    public interface IBaza
    {
        void F();
    }
    public interface IDerivata : IBaza
    {
        void G();
    }
    public class A
    {
        protected virtual void H()
        {
            Console.WriteLine("A.H");
        }
    }
    public class B : A, IDerivata
    {
        public void F()
        {
            Console.WriteLine("B.F, implementare IDerivata.F");
        }

        public void G()
        {
            Console.WriteLine("B.G, implementare IDerivata.G");
        }
        protected override void H()
        {
            Console.WriteLine("B.H, override pe A.H");
        }
       /* class Program
        {
            static void Main(string[] args)
            {
                B b = new B();
                b.F();
                b.G();
                b.H(); // Pentru a apela metoda H() trebuie sa ne aflam in aceasi clasa cu metoda.
            }
        }*/
    }
    public delegate void DelegateVid();
    public class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.F();
            b.G();       
        }
    }

}
