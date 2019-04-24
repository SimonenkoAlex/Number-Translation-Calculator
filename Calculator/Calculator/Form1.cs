using System;
using System.Windows.Forms;
using Calculator.OperationOneArguments;

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

        private void enabledButton(string nameButton)
        {
            switch (nameButton)
            {
                case "btnBinary":
                    button2.Enabled = true; button3.Enabled = true; // Включение кнопок
                    button4.Enabled = true; button5.Enabled = true;
                    button6.Enabled = true; button7.Enabled = true;
                    button8.Enabled = true; button9.Enabled = true;
                    break;
                case "btnDecimal":
                    button2.Enabled = false; button3.Enabled = false; // Отключение кнопок
                    button4.Enabled = false; button5.Enabled = false;
                    button6.Enabled = false; button7.Enabled = false;
                    button8.Enabled = false; button9.Enabled = false;
                    break;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                string firstArgument = textBox1.Text;
                string nameButton = ((Button)sender).Name;
                IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator(nameButton);
                enabledButton(nameButton);
                textBox1.Text = calculator.Calculate(firstArgument);
            }
            catch (Exception exception) {
                textBox1.Text = exception.Message;
            }
        }
    }
}
