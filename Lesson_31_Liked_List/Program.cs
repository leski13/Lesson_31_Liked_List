using System;

namespace Lesson_31_Liked_List
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
            Console.ReadLine();
    
        }
    }
}
