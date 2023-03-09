using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursWork
{
    public partial class FormShow : Form
    {
        Form1 form1;
        public FormShow(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
            show();
        }

        Point lastPoint;
        private void panelBack_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelBack_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string fullPath()
        {
            // нахожу относительный путь
            string fullPath = Directory.GetCurrentDirectory();

            if (fullPath.Length > 10)
                fullPath = fullPath.Remove(fullPath.Length - 10);
            return fullPath;
        }

        List<Airport> airports = new List<Airport>();
        string filePathAirport = fullPath() + "\\airport.txt";

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

        public void show()
        {

            DataBase dataBase = new DataBase();
            dataBase.addAllAirports();
            addAllAirports();
            if (airports.Count > 0)
            {
                int j = 0;
                dataGridView1.RowCount = airports.Count();
                for (int i = 0; i < airports.Count(); i++)
                {
                    dataGridView1[0, j].Value = airports[i].GetCountry();
                    dataGridView1[1, j].Value = airports[i].GetName();
                    dataGridView1[2, j].Value = airports[i].GetFullName();
                    j++;
                }
            }
        }
    }
}
