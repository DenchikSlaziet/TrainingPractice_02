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
            textBox1.Text = "1011101";
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
            return Convert.ToString(Convert.ToInt32(textBox1.Text, number), number2);
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
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked) &&
                (radioButton4.Checked || radioButton5.Checked || radioButton6.Checked) && 
                !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox1.Text);

            button2.Enabled = button1.Enabled;
        }


        private void CheckedFalse()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
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
    }
}
