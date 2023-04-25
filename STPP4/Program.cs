using STPP4.stp4;
using System;

namespace STPP4

{
    class Program
    {
        static void Main()
        {
            var duplexList = new DuplexLinkedList<int>();
            duplexList.Add(1);
            duplexList.Add(2);
            duplexList.Add(3);
            duplexList.Add(4);
            duplexList.Add(5);

            foreach (var item in duplexList)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            duplexList.Delete(3);

            foreach (var item in duplexList)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            var reverse = duplexList.Reverse();
            foreach (var item in reverse)
            {
                Console.Write(item);
            }
        }
    }
}
