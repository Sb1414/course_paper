using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursWork
{
    internal class AirportList
    {
        private class Node
        {
            public Airport airport;
            public Node next;
            public Node previous;

            public Node(Airport airport)
            {
                this.airport = airport;
                this.next = null;
                this.previous = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public void AddAirport(Airport airport)
        {
            Node newNode = new Node(airport);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.previous = tail;
                tail.next = newNode;
                tail = newNode;
            }
            count++;
        }

        public void RemoveAirport(Airport airport)
        {
            Node current = head;
            while (current != null)
            {
                if (current.airport == airport)
                {
                    if (current.previous == null)
                    {
                        head = current.next;
                        if (head != null)
                        {
                            head.previous = null;
                        }
                    }
                    else
                    {
                        current.previous.next = current.next;
                        if (current.next != null)
                        {
                            current.next.previous = current.previous;
                        }
                        else
                        {
                            tail = current.previous;
                        }
                    }
                    count--;
                    break;
                }
                current = current.next;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public Airport GetAirportByIndex(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            return current.airport;
        }

        public int Count()
        {
            return count;
        }

        public List<Airport> GetAllAirports()
        {
            List<Airport> airports = new List<Airport>();
            Node current = head;
            while (current != null)
            {
                airports.Add(current.airport);
                current = current.next;
            }
            return airports;
        }

        public Airport this[int index]
        {
            get
            {
                return GetAirportByIndex(index);
            }
        }
    }

}
