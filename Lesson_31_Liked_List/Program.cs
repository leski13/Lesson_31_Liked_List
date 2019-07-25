using Lesson_31_Linked_List.Model;
using System;

namespace Lesson_31_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.Linked_List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach(var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.Remove(4);
            list.Remove(1);
            list.Remove(9);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.AppendHead(14);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //Console.ReadLine();
            //Двусвязный список
            Console.WriteLine("Добавление данных в список");
            var duplexlist = new DuplexLinkedList<int>();
            duplexlist.Add(44);
            duplexlist.Add(45);
            duplexlist.Add(46);
            duplexlist.Add(47);
            duplexlist.Add(48);

            foreach(var item in duplexlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Element deleted");
            duplexlist.Delete(47);
            foreach(var item in duplexlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List reverse");
            var reverse = duplexlist.Reverse();
            foreach(var item in reverse)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Кольцевой список");
            var circulatedlinkedlist = new CircularLinkedList<int>();
            circulatedlinkedlist.Add(62);
            circulatedlinkedlist.Add(63);
            circulatedlinkedlist.Add(64);
            circulatedlinkedlist.Add(65);
            circulatedlinkedlist.Add(66);

            foreach(var item in circulatedlinkedlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Element deleted");
            circulatedlinkedlist.Delete(66);
            circulatedlinkedlist.Delete(62);

            foreach(var item in circulatedlinkedlist)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
    
        }
    }
}
