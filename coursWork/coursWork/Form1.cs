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
        // List<Airport> airport = new List<Airport>();
        // List<Distance> distance = new List<Distance>();
        AirportList airportList = new AirportList();
        DistanceList distanceList = new DistanceList();

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
                airportList.AddAirport(new Airport(fullName, name1, countr));
            }
        }

        public void addAllairportList()
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
                        airportList.AddAirport(new Airport(fullName, name1, countr));
                    }
                }
            }

        }

        private void AddItemsToComboBox()
        {
            addAllairportList();
            HashSet<string> uniqueCountries = new HashSet<string>();
            for (int i = 0; i < airportList.Count(); i++)
            {
                string country = airportList[i].GetCountry();
                if (!uniqueCountries.Contains(country))
                {
                    comboBox1.Items.Add(country);
                    comboBox2.Items.Add(country);
                    uniqueCountries.Add(country);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateFields(); // проверка на пустоту значений в полях
                Search(); // поиск аэропортов и расстояний
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // вывод ошибок
            }
        }

        private void ValidateFields()
        {
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                throw new Exception("Not all fields are filled in\n\nЗаполнены не все поля");
            }
            string re = @"^[A-ZА-ЯЁ][a-zа-яё]+";
            if (!Regex.IsMatch(comboBox1.Text, re) || !Regex.IsMatch(comboBox2.Text, re))
            {
                throw new Exception("The city must contain Cyrillic or Latin characters and begin with a capital letter\n\n" +
                    "Название города должно содержать кириллические или латинские символы и начинаться с заглавной буквы");
            }
        }

        private void Search()
        {
            dataGridView1.Rows.Clear();
            airportList.Clear();
            distanceList.Clear();

            if (!dataBase.search(comboBox1.Text) || !dataBase.search(comboBox2.Text))
            {
                throw new Exception("Airport not found\n\nАэропорт не найден");
            }

            metodAddAir(comboBox1.Text, comboBox2.Text);
            LoadDistances();
            UpdateUI();
        }

        private void LoadDistances()
        {
            string fullName1 = "", fullName2 = "", dist = "";
            for (int i = 0; i < airportList.Count(); i++)
            {
                string fullName = airportList[i].GetFullName();
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
                                        distanceList.Add(new Distance(fullName1, fullName2, Convert.ToDouble(dist)));
                                        distanceList.Add(new Distance(fullName2, fullName1, Convert.ToDouble(dist)));
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
        }

        private void UpdateUI()
        {
            labelFindInfo.Text = "information found";
            if (distanceList.Count() > 0)
            {
                int j = 0;
                dataGridView1.RowCount = distanceList.Count() / 4;
                for (int i = 0; i < distanceList.Count() / 2; i++)
                {
                    if (dataBase.AirportIn(distanceList[i].GetName1(), comboBox1.Text))
                    {
                        dataGridView1[0, j].Value = distanceList[i].GetName1() + " (" + dataBase.GetShortNameFromName(distanceList[i].GetName1()) + ")";
                        dataGridView1[1, j].Value = distanceList[i].GetName2() + " (" + dataBase.GetShortNameFromName(distanceList[i].GetName2()) + ")";
                        dataGridView1[2, j].Value = distanceList[i].GetDistance();
                        j++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Route not found\n\nПуть не найден", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonShowAllRouts_Click(object sender, EventArgs e)
        {
            ShowRoutes showRoutes = new ShowRoutes();
            showRoutes.Show();
        }

        private void buttonEditBDFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogAir = new OpenFileDialog();
            openFileDialogAir.Filter = "Текстовые файлы (*.txt)|*.txt";
            MessageBox.Show("Выберите файл с аэропортами");
            if (openFileDialogAir.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogAir.FileName;
                dataBase.SetFileAirports(filePath);
            }

            OpenFileDialog openFileDialogDist = new OpenFileDialog();
            openFileDialogDist.Filter = "Текстовые файлы (*.txt)|*.txt";
            MessageBox.Show("Выберите файл с дистанциями");
            if (openFileDialogDist.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogDist.FileName;
                dataBase.SetFileDistances(filePath);
            }
        }
    }
}
