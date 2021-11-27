using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> HalimaList = new LinkedList<string>();

            LinkedListNode<string> HalimaNode = HalimaList.AddFirst("H1");
            HalimaList.AddFirst("H2");
            HalimaList.AddFirst("H3");
            HalimaList.AddBefore(HalimaNode, "H4");
            HalimaList.AddLast("Far away");

            Console.WriteLine("before being reversed:  ");

            foreach (var item in HalimaList)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();
            Console.WriteLine("after being reversed: ");

            foreach (var item in HalimaList.Reverse())
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
