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
using System.Reflection.Emit;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace coursWork
{
    public partial class FormAdd : Form
    {
        Form1 form1;
        public FormAdd(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
            textBoxName1.Text = "airport name";
            textBoxName2.Text = "airport name";
            textBoxName1.ForeColor = Color.Gray;
            textBoxName2.ForeColor = Color.Gray;

            textBoxShort1.Text = "short name";
            textBoxShort2.Text = "short name";
            textBoxShort1.ForeColor = Color.Gray;
            textBoxShort2.ForeColor = Color.Gray;

            textBoxDistance.Text = "distance";
            textBoxDistance.ForeColor = Color.Gray;

            textBoxCountry1.Text = "city";
            textBoxCountry1.ForeColor = Color.Gray;

            textBoxCountry2.Text = "city";
            textBoxCountry2.ForeColor = Color.Gray;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void textBoxName1_Enter(object sender, EventArgs e)
        {
            if (textBoxName1.Text == "airport name")
            {
                textBoxName1.Text = "";
                textBoxName1.ForeColor = Color.Black;
            }
        }

        private void textBoxName1_Leave(object sender, EventArgs e)
        {
            if (textBoxName1.Text == "")
            {
                textBoxName1.Text = "airport name";
                textBoxName1.ForeColor = Color.Gray;
            }
        }

        private void textBoxName2_Enter(object sender, EventArgs e)
        {
            if (textBoxName2.Text == "airport name")
            {
                textBoxName2.Text = "";
                textBoxName2.ForeColor = Color.Black;
            }
        }

        private void textBoxName2_Leave(object sender, EventArgs e)
        {
            if (textBoxName2.Text == "")
            {
                textBoxName2.Text = "airport name";
                textBoxName2.ForeColor = Color.Gray;
            }
        }

        private void textBoxShort1_Enter(object sender, EventArgs e)
        {
            if (textBoxShort1.Text == "short name")
            {
                textBoxShort1.Text = "";
                textBoxShort1.ForeColor = Color.Black;
            }
        }

        private void textBoxShort1_Leave(object sender, EventArgs e)
        {
            if (textBoxShort1.Text == "")
            {
                textBoxShort1.Text = "short name";
                textBoxShort1.ForeColor = Color.Gray;
            }
        }

        private void textBoxShort2_Enter(object sender, EventArgs e)
        {
            if (textBoxShort2.Text == "short name")
            {
                textBoxShort2.Text = "";
                textBoxShort2.ForeColor = Color.Black;
            }
        }

        private void textBoxShort2_Leave(object sender, EventArgs e)
        {
            if (textBoxShort2.Text == "")
            {
                textBoxShort2.Text = "short name";
                textBoxShort2.ForeColor = Color.Gray;
            }
        }

        private void textBoxDistance_Enter(object sender, EventArgs e)
        {
            if (textBoxDistance.Text == "distance")
            {
                textBoxDistance.Text = "";
                textBoxDistance.ForeColor = Color.Black;
            }
        }

        private void textBoxDistance_Leave(object sender, EventArgs e)
        {
            if (textBoxDistance.Text == "")
            {
                textBoxDistance.Text = "distance";
                textBoxDistance.ForeColor = Color.Gray;
            }
        }

        private bool check()
        {
            bool f = false;
            try
            {
                string reAir = @"^[A-ZА-Я][a-zа-яё0-1]+";
                string reShort = @"^[A-ZА-Я]{3}";
                string reCountry = @"^[A-ZА-Я][a-zа-яё]+";
                if ((Regex.IsMatch(textBoxName1.Text, reAir)) && Regex.IsMatch(textBoxName2.Text, reAir))
                {
                    if ((Regex.IsMatch(textBoxShort1.Text, reShort)) && Regex.IsMatch(textBoxShort2.Text, reShort))
                    {
                        if ((Regex.IsMatch(textBoxCountry1.Text, reCountry)) && Regex.IsMatch(textBoxCountry2.Text, reCountry))
                        {
                            if (Regex.IsMatch(textBoxDistance.Text, @"^\d+(\,\d+)?$"))
                            {
                                f = true;
                            }
                            else
                            {
                                throw new Exception("The distance must be a number format, allowed with floating point, use \".\"\n" +
                                                    "Дистанция должна быть формата число, допускается с плавающей точкой, использовать \".\"");
                            }
                        }
                        else
                        {
                            throw new Exception("The name of the city must begin with a capital letter and contain Latin or Cyrillic characters\n" +
                                                "Название города должно начинаться с заглавной буквы и содержать символы латиницы или кириллицы");
                        }
                    }
                    else
                    {
                        throw new Exception("The airport code must contain 3 capital letters\n" +
                                            "Код аэропорта должен содержать 3 заглавные буквы");
                    }
                }
                else
                {
                    throw new Exception("The name of the airport must begin with a capital letter\n" +
                                        "Название аэропорта должно начинаться с заглавной буквы");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return f;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName1.Text != "" || textBoxName1.Text != "airport name" || textBoxName2.Text != "" || textBoxName2.Text != "airport name")
                {
                    if (textBoxShort1.Text != "" || textBoxShort1.Text != "short name" || textBoxShort2.Text != "" || textBoxShort2.Text != "short name")
                    {
                        if (textBoxCountry1.Text != "" || textBoxCountry1.Text != "city" || textBoxCountry2.Text != "" || textBoxCountry2.Text != "city")
                        {
                            if (textBoxDistance.Text != "" || textBoxDistance.Text != "distance")
                            {
                                if (check())
                                {
                                    DataBase dataBase = new DataBase();

                                    dataBase.AddAirport(textBoxName1.Text, textBoxShort1.Text, textBoxCountry1.Text);
                                    dataBase.AddAirport(textBoxName2.Text, textBoxShort2.Text, textBoxCountry2.Text);
                                    dataBase.AddDistance(textBoxName1.Text, textBoxName2.Text, Convert.ToDouble(textBoxDistance.Text));
                                    labelInfo.Text = "Данные успешно внесены";
                                }
                            }
                            else
                            {
                                throw new Exception("not all fields are filled in (no distance)");
                            }
                        }
                        else
                        {
                            throw new Exception("not all fields are filled in (no city)");
                        }

                    }
                    else
                    {
                        throw new Exception("not all fields are filled in (short name)");
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

        private void textBoxCountry1_Enter(object sender, EventArgs e)
        {
            if (textBoxCountry1.Text == "city")
            {
                textBoxCountry1.Text = "";
                textBoxCountry1.ForeColor = Color.Black;
            }
        }

        private void textBoxCountry1_Leave(object sender, EventArgs e)
        {
            if (textBoxCountry1.Text == "")
            {
                textBoxCountry1.Text = "city";
                textBoxCountry1.ForeColor = Color.Gray;
            }
        }

        private void textBoxCountry2_Enter(object sender, EventArgs e)
        {
            if (textBoxCountry2.Text == "city")
            {
                textBoxCountry2.Text = "";
                textBoxCountry2.ForeColor = Color.Black;
            }
        }

        private void textBoxCountry2_Leave(object sender, EventArgs e)
        {
            if (textBoxCountry2.Text == "")
            {
                textBoxCountry2.Text = "city";
                textBoxCountry2.ForeColor = Color.Gray;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Действительно хотите удалить все данные?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string fullPath = Directory.GetCurrentDirectory();
                if (fullPath.Length > 10)
                    fullPath = fullPath.Remove(fullPath.Length - 10);

                string filePathAirport = fullPath + "\\airport.txt";
                File.WriteAllText(filePathAirport, string.Empty);
                string filePathDistance = fullPath + "\\distance.txt";
                File.WriteAllText(filePathDistance, string.Empty);
            }
        }

        private void showAlRoutes_Click(object sender, EventArgs e)
        {
            ShowRoutes showRoutes = new ShowRoutes();
            showRoutes.Show();
        }

        private void showAlRoutes_MouseHover(object sender, EventArgs e)
        {
            showAlRoutes.ForeColor = Color.FromArgb(73, 158, 157);
        }

        private void showAlRoutes_MouseLeave(object sender, EventArgs e)
        {
            showAlRoutes.ForeColor = Color.FromArgb(17, 115, 114);
        }
    }
}
