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
    public partial class ShowRoutes : Form
    {
        public ShowRoutes()
        {
            InitializeComponent();
            show();
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
            this.Close();
        }

        DataBase db = new DataBase();
        DistanceList distances = new DistanceList();

        public void addAllDistances()
        {
            string filePathDistances = db.fullPath() + db.GetFileDistances();
            using (StreamReader sr = new StreamReader(filePathDistances))
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
                        distances.Add(new Distance(name1, name2, Convert.ToDouble(dist)));
                    }
                }
            }
        }

        public void show()
        {
            addAllDistances();
            if (distances.Count() > 0)
            {
                int j = 0;
                dataGridView1.RowCount = distances.Count() + 1;
                for (int i = 0; i < distances.Count(); i++)
                {
                    dataGridView1[0, j].Value = distances[i].GetName1();
                    dataGridView1[1, j].Value = distances[i].GetName2();
                    dataGridView1[2, j].Value = distances[i].GetDistance();
                    j++;
                }
            }
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);

        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    string filePathDistances = db.fullPath() + db.GetFileDistances();
                    int ind = dataGridView1.CurrentRow.Index;
                    string name1 = dataGridView1.Rows[ind].Cells[0].Value.ToString();
                    string name2 = dataGridView1.Rows[ind].Cells[1].Value.ToString();
                    string name = "Действительно удалить маршрут: " + name1 + " - " + name2 + "?";
                    string delDist = name1 + " " + name2 + " " + dataGridView1.Rows[ind].Cells[2].Value.ToString();
                    if (MessageBox.Show(name, "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (ind == dataGridView1.Rows.Count - 1)
                        {
                            dataGridView1.Rows.Insert(dataGridView1.CurrentRow.Index + 1);
                        }
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        var re = File.ReadAllLines(filePathDistances, Encoding.Default).Where(s => !s.Contains(delDist));
                        File.WriteAllLines(filePathDistances, re, Encoding.Default);
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
