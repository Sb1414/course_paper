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
            public Node(Airport airport)
            {
                this.airport = airport;
                this.next = null;
            }
        }

        private Node head;
        private int count;

        public void AddAirport(Airport airport)
        {
            Node newNode = new Node(airport);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
            count++;
        }

        public void RemoveAirport(Airport airport)
        {
            Node current = head;
            Node prev = null;
            while (current != null)
            {
                if (current.airport == airport)
                {
                    if (prev == null)
                    {
                        head = current.next;
                    }
                    else
                    {
                        prev.next = current.next;
                    }
                    count--;
                    break;
                }
                prev = current;
                current = current.next;
            }
        }

        public void Clear()
        {
            head = null;
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
