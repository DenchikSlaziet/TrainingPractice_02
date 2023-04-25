using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingPractice_02
{
    public partial class Form1 : Form
    {
        private int NumberFrom;
        private int NumberWhere;
        private int True = 0;
        private int False = 0;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = GetRandomValue();
        }


        private void radioButton1_Click(object sender, EventArgs e)
        {
            var button = (RadioButton)sender;

            if (button != null)
            {
                switch(button.Text)
                {
                    case "10":
                        if(!IsTrue(10))
                        {
                            button.Checked = false;
                        }
                        break;
                    case "2":
                        if (!IsTrue(2))
                        {
                            button.Checked = false;
                        }
                        break;
                    case "8":
                        if (!IsTrue(8))
                        {
                            button.Checked = false;
                        }
                        break;
                    case "16":
                        if (!IsTrue(16))
                        {
                            button.Checked = false;
                        }
                        break;
                }
            }
        }

        private bool IsTrue(int notation)
        {
            try
            {
                Convert.ToInt32(textBox1.Text,notation);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число в правильной системе счистления!");
                return false;
            }
            NumberFrom = notation;
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ClearButton(panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var otvet = ConvertNotation(NumberFrom, NumberWhere);

            if(textBox2.Text==otvet)
            {
                MessageBox.Show("Правильно");
                True++;
                textBox1.Clear();
                textBox2.Clear();
                ClearButton(panel1);
                ClearButton(panel2);
            }
            else
            {             
                False++;
                textBox2.Clear();
                textBox2.Focus();
                MessageBox.Show($"Неправильно");
            }
            UpdateLabel();
        }

        private string ConvertNotation(int number,int number2)
        {
            try
            {
                return Convert.ToString(Convert.ToInt32(textBox1.Text, number), number2);
            }
            catch
            {
                MessageBox.Show("Слишком большое число!!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return "Ошибка";
            }
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            var button = (RadioButton)sender;

            if (button != null)
            {
                switch (button.Text)
                {
                    case "10":
                        NumberWhere = 10;
                        break;
                    case "2":
                        NumberWhere = 2;
                        break;
                    case "8":
                        NumberWhere = 8;
                        break;
                    case "16":
                        NumberWhere = 16;
                        break;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = (radioButton110.Checked || radioButton18.Checked || radioButton12.Checked || radioButton116.Checked) &&
                (radioButton22.Checked || radioButton82.Checked || radioButton210.Checked || radioButton216.Checked) && 
                !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox1.Text);

            button2.Enabled = button1.Enabled;
        }


        private void ClearButton(Panel panel)
        {
            foreach(var item in panel.Controls)
            {
                if(item is RadioButton radio)
                {
                    radio.Checked = false;
                }
            }
        }

        private void UpdateLabel()
        {
            labelFalse.Text=False.ToString();
            labelTrue.Text=True.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var otvet = ConvertNotation(NumberFrom, NumberWhere);
            ClearButton(panel1);
            ClearButton(panel2);
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show($"Правильный ответ: {otvet}");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 65 && number != 66 && number != 67 && number != 68 && number != 69 && number != 70) 
            {
                e.Handled = true;
            }
        }

        private string GetRandomValue()
        {
            var random = new Random();
            var str = "1";

            for(int i=0;i< random.Next(2,12);i++)
            {
                str += random.Next(0, 2).ToString();
            }

            return str;
        }
    }
}
