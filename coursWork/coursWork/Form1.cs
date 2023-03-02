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

namespace coursWork
{
    public partial class Form1 : Form
    {
        List<Airport> airports = new List<Airport>();
        List<Distance> distances = new List<Distance>();
        
        FormAdd formAdd;
        DataBase dataBase = new DataBase();

        string filePathAirport = "C:\\Users\\Сабина\\source\\repos\\coursWork\\coursWork\\airport.txt";
        string filePathDistance = "C:\\Users\\Сабина\\source\\repos\\coursWork\\coursWork\\distance.txt";
        public Form1()
        {
            InitializeComponent();
            textBoxName1.Text = "Country of departure";
            textBoxName2.Text = "Country of arrival";
            textBoxName1.ForeColor = Color.Gray;
            textBoxName2.ForeColor = Color.Gray;
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

        private void toolStripTextBox1_Enter(object sender, EventArgs e)
        {
            if (textBoxName1.Text == "Country of departure")
            {
                textBoxName1.Text = "";
                textBoxName1.ForeColor = Color.Black;
            }
        }

        private void toolStripTextBox1_Leave(object sender, EventArgs e)
        {
            if (textBoxName1.Text == "")
            {
                textBoxName1.Text = "Country of departure";
                textBoxName1.ForeColor = Color.Gray;
            }
        }

        private void toolStripTextBox2_Enter(object sender, EventArgs e)
        {
            if (textBoxName2.Text == "Country of arrival")
            {
                textBoxName2.Text = "";
                textBoxName2.ForeColor = Color.Black;
            }
        }

        private void toolStripTextBox2_Leave(object sender, EventArgs e)
        {
            if (textBoxName2.Text == "")
            {
                textBoxName2.Text = "Country of arrival";
                textBoxName2.ForeColor = Color.Gray;
            }
        }

        private void metod(string searchString1, string searchString2)
        {
            string name1 = "", fullName = "", countr = "";

            string[] fileLines = File.ReadAllLines(filePathAirport);

            // Read the file and find all lines that contain the search string
            var filteredLines = File.ReadLines(filePathAirport).Where(line => 
            line.Contains(searchString1) || line.Contains(searchString2));

            // Output the matching lines
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


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName1.Text != "" || textBoxName1.Text != "Country of departure" 
                    || textBoxName2.Text != "" || textBoxName2.Text != "Country of arrival")
                {                    
                    if (dataBase.search(textBoxName1.Text) && dataBase.search(textBoxName2.Text))
                    {
                        airports.Clear();
                        distances.Clear();
                        dataGridView1.Rows.Clear();
                        labelFindInfo.Text = "information found";

                        metod(textBoxName1.Text, textBoxName2.Text);
                        // labelFindInfo.Text = airports.Count().ToString();
                        string[] fileLines = File.ReadAllLines(filePathDistance);
                        string fullName1 = "", fullName2 = "";
                        double dist = 0;
                        for (int i = 0; i < airports.Count(); i++)
                        {
                            var filteredLines = File.ReadLines(filePathDistance).Where(line => 
                            line.Contains(airports[i].GetFullName()));
                            foreach (var line in filteredLines)
                            {
                                if (line != null)
                                {
                                    fullName1 = line.Split(' ')[0];
                                    fullName2 = line.Split(' ')[1];
                                    dist = Convert.ToDouble(line.Split(' ')[2]);
                                }
                                if (dataBase.AirportIn(fullName1, textBoxName1.Text) && 
                                    dataBase.AirportIn(fullName2, textBoxName2.Text))
                                    distances.Add(new Distance(fullName1, fullName2, dist));
                            }
                        }
                        dataGridView1.RowCount = airports.Count();
                        for (int i = 0; i < airports.Count(); i++)
                        {
                            dataGridView1[0, i].Value = distances[i].GetName1();
                            dataGridView1[1, i].Value = distances[i].GetName2();
                            dataGridView1[2, i].Value = distances[i].GetDistance();
                        }
                        // labelFindInfo.Text = distances.Count().ToString();
                        // dataGridView1[0, 0].Value;

                    } 
                    else
                    {
                        throw new Exception("airport not found");
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
            if ((textBoxName1.Text != "" && textBoxName1.Text != "Country of departure") &&
                     (textBoxName2.Text != "" && textBoxName2.Text != "Country of arrival"))
            {
                string tmp = textBoxName1.Text;
                textBoxName1.Text = textBoxName2.Text;
                textBoxName2.Text = tmp;
            }
        }
    }
}
