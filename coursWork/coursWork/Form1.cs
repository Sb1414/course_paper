using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using Application = System.Windows.Forms.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace coursWork
{
    public partial class Form1 : Form
    {
        List<Airport> airports = new List<Airport>();
        List<Distance> distances = new List<Distance>();
        
        FormAdd formAdd;
        FormShow formShow;
        DataBase dataBase = new DataBase();
        public static string fullPath()
        {
            // нахожу относительный путь
            string fullPath = Directory.GetCurrentDirectory();
            Console.WriteLine(fullPath);

            if (fullPath.Length > 10)
                fullPath = fullPath.Remove(fullPath.Length - 10);
            Console.WriteLine(fullPath);
            return fullPath;
        }

        string filePathAirport = fullPath() + "\\airport.txt";
        string filePathDistance = fullPath() + "\\distance.txt";
        public Form1()
        {
            InitializeComponent();
            AddItemsToComboBox();
        }

        Point lastPoint;
        private void panelUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metodAddAir(string searchString1, string searchString2)
        {
            string name1 = "", fullName = "", countr = "";

            string[] fileLines = File.ReadAllLines(filePathAirport);

            var filteredLines = File.ReadLines(filePathAirport).Where(line => 
            line.Contains(searchString1) || line.Contains(searchString2));

            foreach (var line in filteredLines)
            {
                if (line != null)
                {
                    fullName = line.Split(' ')[0];
                    name1 = line.Split(' ')[1];
                    countr = line.Split(' ')[2];
                }
                airports.Add(new Airport(fullName, name1, countr));
            }
        }

        public void addAllAirports()
        {
            string filePathAirport = fullPath() + "\\airport.txt";

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
                        airports.Add(new Airport(fullName, name1, countr));
                    }
                }
            }

        }

        private void AddItemsToComboBox()
        {
            addAllAirports();
            for (int i = 0; i < airports.Count; i++)
            {
                comboBox1.Items.Add(airports[i].GetCountry());
                comboBox2.Items.Add(airports[i].GetCountry());
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "" || comboBox2.Text != "")
                {
                    string re = @"^[A-ZА-ЯЁ][a-zа-яё]+";
                    if ((Regex.IsMatch(comboBox1.Text, re)) && Regex.IsMatch(comboBox2.Text, re))
                    {
                        dataGridView1.Rows.Clear();
                        if (dataBase.search(comboBox1.Text) && dataBase.search(comboBox2.Text))
                        {
                            airports.Clear();
                            distances.Clear();
                            labelFindInfo.Text = "information found";

                            string fullName1 = "", fullName2 = "", dist = "";

                            metodAddAir(comboBox1.Text, comboBox2.Text);
                            // labelFindInfo.Text = airports.Count().ToString();
                            for (int i = 0; i < airports.Count(); i++)
                            {
                                string fullName = airports[i].GetFullName();
                                bool found = false;

                                if (File.Exists(filePathDistance))
                                {
                                    using (StreamReader reader = new StreamReader(filePathDistance))
                                    {
                                        string line;
                                        while ((line = reader.ReadLine()) != null)
                                        {
                                            if (line.Contains(fullName))
                                            {
                                                string[] words = line.Split(' ');
                                                if (words.Length >= 3)
                                                {
                                                    fullName1 = words[0];
                                                    fullName2 = words[1];
                                                    dist = words[2];
                                                    if ((dataBase.AirportIn(fullName1, comboBox1.Text) && dataBase.AirportIn(fullName2, comboBox2.Text))
                                                    || (dataBase.AirportIn(fullName2, comboBox1.Text) && dataBase.AirportIn(fullName1, comboBox2.Text)))
                                                    {
                                                        Console.WriteLine("В дистанции: " + fullName1 + fullName2 + dist);
                                                        distances.Add(new Distance(fullName1, fullName2, Convert.ToDouble(dist)));
                                                        distances.Add(new Distance(fullName2, fullName1, Convert.ToDouble(dist)));
                                                    }
                                                }
                                                found = true;
                                            }
                                        }
                                    }
                                }

                                if (!found)
                                {
                                    Console.WriteLine($"Аэропорт {fullName} не найден в файле");
                                }
                            }

                            // labelFindInfo.Text = distances.Count().ToString();
                            // dataGridView1[0, 0].Value;
                            if (distances.Count > 0)
                            {
                                int j = 0;
                                dataGridView1.RowCount = distances.Count() / 4;
                                for (int i = 0; i < distances.Count() / 2; i++)
                                {
                                    if (dataBase.AirportIn(distances[i].GetName1(), comboBox1.Text))
                                    {
                                        dataGridView1[0, j].Value = distances[i].GetName1() + " (" + dataBase.GetShortNameFromName(distances[i].GetName1()) + ")";
                                        dataGridView1[1, j].Value = distances[i].GetName2() + " (" + dataBase.GetShortNameFromName(distances[i].GetName2()) + ")";
                                        dataGridView1[2, j].Value = distances[i].GetDistance();
                                        j++;
                                    }
                                }
                            }
                            else
                            {
                                throw new Exception("route not found");
                            }
                        }
                        else
                        {
                            throw new Exception("airport not found");
                        }
                    }
                    else
                    {
                        throw new Exception("The city must contain Cyrillic or Latin characters and begin with a capital letter");
                    }
                } 
                else
                {
                    throw new Exception("not all fields are filled in");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new FormAdd(this).Show();
        }

        private void buttonInverse_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
            {
                string tmp = comboBox1.Text;
                comboBox1.Text = comboBox2.Text;
                comboBox2.Text = tmp;
            }
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var column1 = row.Cells[0].Value;
                    var column2 = row.Cells[1].Value;

                    var temp = column1;

                    row.Cells[0].Value = column2;
                    row.Cells[1].Value = temp;
                }
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            new FormShow(this).Show();
        }
    }
}
