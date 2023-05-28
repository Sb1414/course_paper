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

        DataBase db = new DataBase();
        AirportList airports = new AirportList();

        public void addAllAirports()
        {
            string filePathAirport = db.fullPath() + db.GetFileAirports();

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
                        airports.AddAirport(new Airport(fullName, name1, countr));
                    }
                }
            }

        }

        public void show()
        {

            DataBase dataBase = new DataBase();
            dataBase.addAllAirports();
            addAllAirports();
            if (airports.Count() > 0)
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

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    string filePathAirport = db.fullPath() + db.GetFileAirports();
                    int ind = dataGridView1.CurrentRow.Index;
                    string name = dataGridView1.Rows[ind].Cells[0].Value.ToString();
                    string nameis = "Действительно удалить аэропорт: " + name + "?";
                    string delDist = name + " " + dataGridView1.Rows[ind].Cells[1].Value.ToString() + " " + dataGridView1.Rows[ind].Cells[2].Value.ToString();
                    if (MessageBox.Show(name, "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (ind == dataGridView1.Rows.Count - 1)
                        {
                            dataGridView1.Rows.Insert(dataGridView1.CurrentRow.Index + 1);
                        }
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        var re = File.ReadAllLines(filePathAirport, Encoding.Default).Where(s => !s.Contains(delDist));
                        File.WriteAllLines(filePathAirport, re, Encoding.Default);
                    }
                }
                else
                {
                    throw new Exception("Не указано какую строку нужно удалить!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
