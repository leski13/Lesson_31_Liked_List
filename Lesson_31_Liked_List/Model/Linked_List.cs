using System;
using System.Collections;

namespace Lesson_31_Liked_List.Model
{
    /// <summary>
    /// Односвязный список
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Linked_List<T> : IEnumerable
    {
        public Item<T> Head { get; private set; }//первый элемент списка
        public Item<T> Tail { get; private set; }//последний элемент списка
        public int Count { get; private set; }//колличество элементов в списке

        public Linked_List()//создать пустой список
        {
            Clear();
        }      
        public Linked_List(T data)//создать список с начальными данными
        {            
            SetHeadAndTail(data);          
        }
        public void Add(T data)//добавить данные в конец списка
        {           
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
                SetHeadAndTail(data);
        }
        public void Remove(T data)//удаление данных из списка
        {
            if(Head!=null)
            {
                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;
                while(current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        public void Clear()//очистить список
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public IEnumerator GetEnumerator()//получить перечисление всех элементов списка
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public void AppendHead(T data)// добавить данные в начало списка
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };
            Head = item;
            Count++;
        }
       
        public override string ToString()
        {
            return "Linked_List" + Count + "elements";
        }
    }
}
