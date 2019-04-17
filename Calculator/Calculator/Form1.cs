﻿using System;
using System.Windows.Forms;
using Calculator.OperationOneArguments;
using Calculator.OperationTwoArguments;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numberSystem = 10;
        // Обработчик события нажатия на цифровую кнопку
        private void btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text; // и добавляется цифра, отображённая на кнопке
        }
        // Обработчик события для удаления последнего символа
        private void btnPointer_Click(object sender, EventArgs e)
        {
            string rez = ""; // переменная, в которую сохраняется новая строка             
            byte i = 0; // счётчик количества символов             
            while (i < textBox1.Text.Length - 1) // Пока i меньше длины textBox-1  
            {
                rez += textBox1.Text[i]; // в переменную res добавляем текущий символ и                 
                i++; // увеличиваем счётчик (т.е. переходим к следующему символу)             
            }
            textBox1.Text = rez; // Переменная rez = textBox без последнего символа 
        }
        // Обработчик события для удаления всей строки в текстовом поле
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            numberSystem = 10;
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                string firstArgument = textBox1.Text;
                string nameButton = ((Button)sender).Name;
                IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator(nameButton);
                if (nameButton == "btnBinary") numberSystem = 2;
                if (nameButton == "btnDecimal") numberSystem = 10;
                textBox1.Text = calculator.Calculate(firstArgument);
            }
            catch (Exception exception) {
                textBox1.Text = exception.Message;
            }
        }

        private void btnSignChange_Click(object sender, EventArgs e)
        {
            int firstArgument = Convert.ToInt32(textBox1.Text);
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(numberSystem);
            // Преобразует целое число в эквивалентное строковое представление в 2-ичной С.С.                 
            textBox1.Text = Convert.ToString(calculator.Calculate(firstArgument, numberSystem));
        }
    }
}
