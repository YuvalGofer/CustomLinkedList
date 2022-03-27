using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
     class CustomLinkedList<T> 
    {
        public Node<T> First { get; set; }
        public Node<T> Current { get; set; }
        public Node<T> Last { get; set; }
       
        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (Current == null)
            {
                First = newNode;
                Current = newNode;
            }
            else
            {
                Current.Next = newNode;
                newNode.Previous = Current;
                Current = newNode;  
            }
            Last = newNode;
            
        }
        public IEnumerable GetEnumerableDESC()
        {
            Current = Last;
            while(Current != null)
            {
                yield return Current.Value;
                Current = Current.Previous;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = First;
            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //   Current = First;
        //    while(Current.Next != null)
        //    {
        //        Current = Current.Next;
        //    }
        //    yield return Current.Next = Last;
        //}                        
    }
}
