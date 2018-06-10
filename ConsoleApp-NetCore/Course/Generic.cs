using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_NetCore.Course
{

    #region 范型介绍
    //创建自定义泛型类型和泛型方法，以提供自己的通用解决方案，设计类型安全的高效模式。
    public class GenericClass
    {
        //type parameter T in angle brackets
        public class GenericList<T>
        {
            // The nested class is also generic on T.
            private class Node
            {
                // T used in non-generic constructor.
                public Node(T t)
                {
                    next = null;
                    data = t;
                }

                private Node next;
                public Node Next
                {
                    get { return next; }
                    set { next = value; }
                }

                // T as private member data type.
                private T data;

                // T as return type of property.
                public T Data
                {
                    get { return data; }
                    set { data = value; }
                }
            }

            private Node head;

            // constructor
            public GenericList()
            {
                head = null;
            }

            // T as method parameter type:
            public void AddHead(T t)
            {
                Node n = new Node(t);
                n.Next = head;
                head = n;
            }

            public IEnumerator<T> GetEnumerator()
            {
                Node current = head;

                while (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
        }

  

        public class TestGenericList
        {
            public void WriteMethod()
            {
                // int is the type argument
                GenericList<int> list = new GenericList<int>();

                for (int x = 0; x < 10; x++)
                {
                    list.AddHead(x);
                }

                foreach (int i in list)
                {
                    System.Console.Write(i + " ");
                }
                System.Console.WriteLine("\n Done");
            }
        }

    }

    #endregion







}
