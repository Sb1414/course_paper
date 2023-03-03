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

namespace coursWork
{
    public partial class FormAdd : Form
    {
        Form1 form1;
        public FormAdd(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
            textBoxName1.Text = "Country of departure";
            textBoxName2.Text = "Country of arrival";
            textBoxName1.ForeColor = Color.Gray;
            textBoxName2.ForeColor = Color.Gray;

            textBoxShort1.Text = "Short name";
            textBoxShort2.Text = "Short name";
            textBoxShort1.ForeColor = Color.Gray;
            textBoxShort2.ForeColor = Color.Gray;

            textBoxDistance.Text = "Distance";
            textBoxDistance.ForeColor = Color.Gray;

            textBoxCountry1.Text = "Country";
            textBoxCountry1.ForeColor = Color.Gray;

            textBoxCountry2.Text = "Country";
            textBoxCountry2.ForeColor = Color.Gray;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxName1_Enter(object sender, EventArgs e)
        {
            if (textBoxName1.Text == "Country of departure")
            {
                textBoxName1.Text = "";
                textBoxName1.ForeColor = Color.Black;
            }
        }

        private void textBoxName1_Leave(object sender, EventArgs e)
        {
            if (textBoxName1.Text == "")
            {
                textBoxName1.Text = "Country of departure";
                textBoxName1.ForeColor = Color.Gray;
            }
        }

        private void textBoxName2_Enter(object sender, EventArgs e)
        {
            if (textBoxName2.Text == "Country of arrival")
            {
                textBoxName2.Text = "";
                textBoxName2.ForeColor = Color.Black;
            }
        }

        private void textBoxName2_Leave(object sender, EventArgs e)
        {
            if (textBoxName2.Text == "")
            {
                textBoxName2.Text = "Country of arrival";
                textBoxName2.ForeColor = Color.Gray;
            }
        }

        private void textBoxShort1_Enter(object sender, EventArgs e)
        {
            if (textBoxShort1.Text == "Short name")
            {
                textBoxShort1.Text = "";
                textBoxShort1.ForeColor = Color.Black;
            }
        }

        private void textBoxShort1_Leave(object sender, EventArgs e)
        {
            if (textBoxShort1.Text == "")
            {
                textBoxShort1.Text = "Short name";
                textBoxShort1.ForeColor = Color.Gray;
            }
        }

        private void textBoxShort2_Enter(object sender, EventArgs e)
        {
            if (textBoxShort2.Text == "Short name")
            {
                textBoxShort2.Text = "";
                textBoxShort2.ForeColor = Color.Black;
            }
        }

        private void textBoxShort2_Leave(object sender, EventArgs e)
        {
            if (textBoxShort2.Text == "")
            {
                textBoxShort2.Text = "Short name";
                textBoxShort2.ForeColor = Color.Gray;
            }
        }

        private void textBoxDistance_Enter(object sender, EventArgs e)
        {
            if (textBoxDistance.Text == "Distance")
            {
                textBoxDistance.Text = "";
                textBoxDistance.ForeColor = Color.Black;
            }
        }

        private void textBoxDistance_Leave(object sender, EventArgs e)
        {
            if (textBoxDistance.Text == "")
            {
                textBoxDistance.Text = "Distance";
                textBoxDistance.ForeColor = Color.Gray;
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName1.Text != "" || textBoxName1.Text != "Country of departure" || textBoxName2.Text != "" || textBoxName2.Text != "Country of arrival")
                {
                    if (textBoxShort1.Text != "" || textBoxShort1.Text != "Short name" || textBoxShort2.Text != "" || textBoxShort2.Text != "Short name")
                    {
                        if (textBoxCountry1.Text != "" || textBoxCountry1.Text != "Country" || textBoxCountry2.Text != "" || textBoxCountry2.Text != "Country")
                        {
                            if (textBoxDistance.Text != "" || textBoxDistance.Text != "Distance")
                            {
                                DataBase dataBase = new DataBase();
                                
                                dataBase.AddAirport(textBoxName1.Text, textBoxShort1.Text, textBoxCountry1.Text);
                                dataBase.AddAirport(textBoxName2.Text, textBoxShort2.Text, textBoxCountry2.Text);
                                dataBase.AddDistance(textBoxName1.Text, textBoxName2.Text, Convert.ToDouble(textBoxDistance.Text));
                                labelInfo.Text = "Данные успешно внесены";

                            }
                            else
                            {
                                throw new Exception("not all fields are filled in (no distance)");
                            }
                        }
                        else
                        {
                            throw new Exception("not all fields are filled in (no country)");
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
            if (textBoxCountry1.Text == "Country")
            {
                textBoxCountry1.Text = "";
                textBoxCountry1.ForeColor = Color.Black;
            }
        }

        private void textBoxCountry1_Leave(object sender, EventArgs e)
        {
            if (textBoxCountry1.Text == "")
            {
                textBoxCountry1.Text = "Country";
                textBoxCountry1.ForeColor = Color.Gray;
            }
        }

        private void textBoxCountry2_Enter(object sender, EventArgs e)
        {
            if (textBoxCountry2.Text == "Country")
            {
                textBoxCountry2.Text = "";
                textBoxCountry2.ForeColor = Color.Black;
            }
        }

        private void textBoxCountry2_Leave(object sender, EventArgs e)
        {
            if (textBoxCountry2.Text == "")
            {
                textBoxCountry2.Text = "Country";
                textBoxCountry2.ForeColor = Color.Gray;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string filePathAirport = "C:\\Users\\Сабина\\source\\repos\\coursWork\\coursWork\\airport.txt";
            File.WriteAllText(filePathAirport, string.Empty);
            string filePathDistance = "C:\\Users\\Сабина\\source\\repos\\coursWork\\coursWork\\distance.txt";
            File.WriteAllText(filePathDistance, string.Empty);
        }
    }
}
