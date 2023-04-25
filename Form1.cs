using System;
using System.Collections.Generic;
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
        private int Number;
        private int Number2;
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
            Number = notation;
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckedFalse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var otvet = ConvertNotation(Number,Number2);

            if(textBox2.Text==otvet)
            {
                MessageBox.Show("Правильно");
                True++;
                textBox1.Clear();
                textBox2.Clear();
                CheckedFalse();
            }
            else
            {             
                False++;
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
                        Number2 = 10;
                        break;
                    case "2":
                        Number2 = 2;
                        break;
                    case "8":
                        Number2 = 8;
                        break;
                    case "16":
                        Number2 = 16;
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


        private void CheckedFalse()
        {
            radioButton110.Checked = false;
            radioButton18.Checked = false;
            radioButton12.Checked = false;
            radioButton116.Checked = false;
        }

        private void UpdateLabel()
        {
            labelFalse.Text=False.ToString();
            labelTrue.Text=True.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var otvet = ConvertNotation(Number, Number2);
            CheckedFalse();
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
