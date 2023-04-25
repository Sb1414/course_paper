using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursWork
{
    internal class DistanceNode
    {
        public Distance data;
        public DistanceNode next;
        public DistanceNode(Distance data)
        {
            this.data = data;
            this.next = null;
        }
    }
    internal class DistanceList
    {
        private DistanceNode head;
        private int count;

        public DistanceList()
        {
            head = null;
            count = 0;
        }

        public Distance this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                return GetNode(index).data;
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                GetNode(index).data = value;
            }
        }


        public void Add(Distance data)
        {
            DistanceNode newNode = new DistanceNode(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                DistanceNode current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
            count++;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public DistanceNode GetNode(int index)
        {
            DistanceNode current = head;

            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }

            return current;
        }
    }
}
