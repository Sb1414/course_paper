using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace coursWork
{
    internal class DataBase
    {
        List<Airport> airports = new List<Airport>();
        List<Distance> distances = new List<Distance>();

        public void AddAirport(string fullName, string name, string country)
        {
            Airport airport = new Airport(fullName, name, country);
            airports.Add(airport);

            string fileName = "C:\\Users\\Сабина\\source\\repos\\coursWork\\coursWork\\airport.txt";

            // записываем данные в файл
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(fullName + " " + name + " " + country);
            }
        }

        public void AddDistance(string name1, string name2, double interval)
        {
            Distance distance = new Distance(name1, name2, interval);
            distances.Add(distance);

            string fileName = "C:\\Users\\Сабина\\source\\repos\\coursWork\\coursWork\\distance.txt";

            // записываем данные в файл
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(name1 + " " + name2 + " " + interval + '\n');
            }
        }

        public void addAllAirports()
        {
            string filePathAirport = "C:\\Users\\Сабина\\source\\repos\\coursWork\\coursWork\\airport.txt";
            string name1 = "", fullName = "", countr = "";

            foreach (string line in File.ReadLines(filePathAirport))
            {
                if (line != null){
                    fullName = line.Split(' ')[0];
                    name1 = line.Split(' ')[1];
                    countr = line.Split(' ')[2];
                }
                airports.Add(new Airport(fullName, name1, countr));
            }
        }

        public void addAllDistances()
        {
            string filePathAirport = "C:\\Users\\Сабина\\source\\repos\\coursWork\\coursWork\\distance.txt";
            string name1 = "", name2 = "";
            double dist = 0;

            foreach (string line in File.ReadLines(filePathAirport))
            {
                if (line != null)
                {
                    name1 = line.Split(' ')[0];
                    name2 = line.Split(' ')[1];
                    dist = Convert.ToDouble(line.Split(' ')[2]);
                }
                distances.Add(new Distance(name1, name2, dist));
            }
        }

        public bool AirportIn(string name, string country)
        {
            addAllAirports();
            addAllDistances();
            for (int i = 0; i < airports.Count; i++)
            {
                if (airports[i].GetFullName() == name && airports[i].GetCountry() == country)
                {
                    return true;
                }
            }
            return false;
        }

        public bool search(string name)
        {
            bool f = false;
            string filePath = "C:\\Users\\Сабина\\source\\repos\\coursWork\\coursWork\\airport.txt";

            string[] fileLines = File.ReadAllLines(filePath);

            var filteredLines = fileLines.Where(line => line.Contains(name));

            foreach (var line in filteredLines)
            {
                f = true;
                // Console.WriteLine(line);
            }
            return f;
        }
        /*
        public string GetNameAirport(string country)
        {

        }
        */
        /* МЕТОД В ОСНОВНОЙ МЕЙН ФАЙЛ
        public void setDistance(string n1, string n2, double distance)
        {
            airport airport1 = new airport();
            airport airport2 = new airport();
            try
            {
                if (airport1.GetName() == n1)
                {
                    if (airport2.GetName() == n2)
                    {

                    }
                    else
                    {
                        throw new Exception("Такого аэропорта нет");
                    }
                }
                else
                {
                    throw new Exception("Такого аэропорта нет");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        */
    }
}
