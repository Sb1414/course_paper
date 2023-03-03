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

            using (StreamReader sr = new StreamReader(filePathAirport))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');

                    if (words.Length == 3)
                    {
                        string fullName = words[0];
                        string name1 = words[1];
                        string countr = words[2];
                        // обрабатываем полученные слова
                        // Console.WriteLine("Первое слово: " + fullName);
                        // Console.WriteLine("Второе слово: " + name1);
                        // Console.WriteLine("Третье слово: " + countr);
                        airports.Add(new Airport(fullName, name1, countr));
                    }
                }
            }

        }

        public void addAllDistances()
        {
            string filePathAirport = "C:\\Users\\Сабина\\source\\repos\\coursWork\\coursWork\\distance.txt";
            using (StreamReader sr = new StreamReader(filePathAirport))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');

                    if (words.Length == 3)
                    {
                        string name1 = words[0];
                        string name2 = words[1];
                        string dist = words[2];
                        // обрабатываем полученные слова
                        // Console.WriteLine("Первое слово: " + name1);
                        // Console.WriteLine("Второе слово: " + name2);
                        // Console.WriteLine("Третье слово: " + dist);
                        distances.Add(new Distance(name1, name2, Convert.ToDouble(dist)));
                    }
                }
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
        /*
        public string retFullName(string name)
        {
            addAllAirports();
            addAllDistances();
            for (int i = 0; i < airports.Count; i++)
            {
                if (airports[i].GetName() == name)
                {
                    return airports[i].GetFullName();
                }
            }
            return false;
        }
        */
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
