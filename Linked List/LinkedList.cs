using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    public class LinkedList
    {

        private Node head;
        private int count;

        public LinkedList() //constructor
        {
            this.head = null;
            this.count = 0;
        }

        public bool Empty
        {
            get { return this.count == 0; } // if true return size as 0
        }

        public int Count
        {
            get { return this.count; } //returns current size of list
        }

        public object Add(int index, object o)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index " + index);

            if (index > count)
                index = count;

            Node current = this.head;

            if( this.Empty || index == 0)
            {
                this.head = new Node(o, this.head); //if node is empty you enter the head first
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                current.Next = new Node(o, current.Next);
            }

            count++;
            return o;
        }

        public object Add(object o)
        {
            return this.Add(count, o);
        }

        public object Remove(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index " + index);

            if (index >= this.count)
                index = count - 1;

            Node current = this.head;
            object result = null;

            if (index == 0)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                result = current.Next.Data; //this is data being "deleted"

                current.Next = current.Next.Next; //this is skipping referencing current.Next - so you don't actually delete the node just the reference to the node in the list
               
            }

            count--;
            return result;
        }

        public void Clear() //getting rid of the reference to the head basically deletes the list 
        {
            this.head = null;
            this.count = 0; //shows the list is empty
        }

        public int IndexOf(object o)
        {
            Node current = this.head;

            for (int i =0; i <this.count; i++)
            {
                if(current.Data.Equals(o))
                {
                    return i;
                }
                current = current.Next;
            }
            return -1;
        }

        public bool Contains(object o)
        {
            return this.IndexOf(o) != -1;
        }

        public object Get(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index);

            if (this.Empty)
                return null;

            if (index >= this.count)
                index = this.count - 1;

            Node current = this.head;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Data;
        }
    }
 
}
