using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursWork
{
    internal class Distance
    {
        private double distance;
        private string name1;
        private string name2;

        public Distance(string name1, string name2, double distance)
        {
            this.name1 = name1;
            this.name2 = name2;
            this.distance = distance;
        }

        public void SetDistance (double distance)
        {
            this.distance = distance;
        }

        public void SetName1 (string name1)
        {
            this.name1 = name1;
        }

        public void SetName2(string name2)
        {
            this.name2 = name2;
        }

        public double GetDistance ()
        {
            return this.distance;
        }

        public string GetName1()
        {
            return this.name1;
        }

        public string GetName2()
        {
            return this.name2;
        }
    }
}
