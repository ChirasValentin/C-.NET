using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i; // boxing - valoare in referinta
            int j = (int)o; //unboxing - referinta in valoare
        }
    }
}
