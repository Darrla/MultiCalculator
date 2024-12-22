using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiCalculator
{
    /// <summary>
    /// Основной класс калькулятора
    /// </summary>
    public partial class Form1 : Form
    {
        // Переменные для хранения первого значения и текущей операции
        private double _firstValue;
        private string _operation;

        // Конструктор формы, инициализирует компоненты
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик нажатия кнопки цифры
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // Получаем нажатую кнопку
            if (resultTextBox.Text == "0") // Если текущее значение 0, очищаем текстовое поле
                resultTextBox.Clear();
            resultTextBox.Text += button.Text; // Добавляем текст кнопки в текстовое поле
        }

        /// <summary>
        /// Обработчики для каждой кнопки цифры (0-9)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn1_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn2_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn3_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn4_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn5_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn6_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn7_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn8_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn9_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn0_Click(object sender, EventArgs e) => btn_Click(sender, e);

        // Обработчики для операций: сложение, вычитание, умножение и деление
        private void btnAdd_Click(object sender, EventArgs e) => SetOperation("+");
        private void btnSubtract_Click(object sender, EventArgs e) => SetOperation("-");
        private void btnMultiply_Click(object sender, EventArgs e) => SetOperation("*");
        private void btnDivide_Click(object sender, EventArgs e) => SetOperation("/");

        /// <summary>
        /// Сложный Обработчик нажатия кнопки равно
        /// </summary>
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondValue = Convert.ToDouble(resultTextBox.Text); // Получаем второе значение из текстового поля
            double result; // Переменная для хранения результата

            try
            {
                // Выполняем операцию в зависимости от выбранного действия
                switch (_operation)
                {
                    case "+":
                        result = _firstValue + secondValue;
                        break;
                    case "-":
                        result = _firstValue - secondValue;
                        break;
                    case "*":
                        result = _firstValue * secondValue;
                        break;
                    case "/":
                        if (secondValue == 0)
                            throw new DivideByZeroException(); // Исключение при делении на ноль
                        result = _firstValue / secondValue;
                        break;
                    default:
                        return; // Если операция не задана
                }
                resultTextBox.Text = result.ToString(); // Выводим результат в текстовое поле
                AddToHistory($"{_firstValue} {_operation} {secondValue} = {result}"); // Сохраняем результат в историю
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Ошибка: Деление на ноль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultTextBox.Text = "0"; // Сбрасываем текстовое поле на 0 при ошибке
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultTextBox.Text = "0"; // Сбрасываем текстовое поле на 0 при ошибке
            }
        }

        // Обработчик изменения знака числа
        private void btnNegate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(resultTextBox.Text, out double value))
            {
                value = -value; // Меняем знак числа
                resultTextBox.Text = value.ToString(); // Выводим новое значение в текстовое поле
            }
            else
            {
                MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Обработчик нажатия кнопки очистки
        private void btnClear_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0"; // Сбрасываем текстовое поле на 0
            _firstValue = 0; // Сбрасываем первое значение
            _operation = string.Empty; // Сбрасываем текущее действие
        }

        // Метод для установки текущей операции
        private void SetOperation(string operation)
        {
            if (string.IsNullOrWhiteSpace(resultTextBox.Text)) // Проверка на пустое значение
            {
                MessageBox.Show("Введите число перед выполнением операции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(resultTextBox.Text, out _firstValue)) // Проверка корректности ввода числа
            {
                MessageBox.Show("Некорректный ввод. Пожалуйста, введите числовое значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resultTextBox.Text = "0"; // Сбрасываем текстовое поле на 0 при ошибке ввода
                return;
            }

            _operation = operation; // Устанавливаем текущую операцию
            resultTextBox.Text = "0"; // Сбрасываем текстовое поле для ввода следующего числа
        }

        // Обработчик извлечения квадратного корня
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(resultTextBox.Text, out double value))
            {
                if (value < 0)
                {
                    MessageBox.Show("Ошибка: Невозможно извлечь квадратный корень из отрицательного числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double result = Math.Sqrt(value);
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Обработчик возведения в степень
        private void btnPower_Click(object sender, EventArgs e)
        {
            if (double.TryParse(resultTextBox.Text, out double exponent))
            {
                double result = Math.Pow(_firstValue, exponent);
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Обработчик тригонометрических функций подходящий для синуса, арксинуса, косинуса, аркконсинуса, тангенса, арктангенса
        private void PerformTrigonometricFunction(Func<double, double> function)
        {
            if (double.TryParse(resultTextBox.Text, out double value))
            {
                double result = function(value);
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Обработчик тригонометрических функций синуса, арксинуса, косинуса, аркконсинуса, тангенса, арктангенса
        /// </summary>

        private void btnSin_Click(object sender, EventArgs e) => PerformTrigonometricFunction(Math.Sin);
        private void btnASin_Click(object sender, EventArgs e) => PerformTrigonometricFunction(Math.Sin);
        private void btnCos_Click(object sender, EventArgs e) => PerformTrigonometricFunction(Math.Sin);
        private void btnACos_Click(object sender, EventArgs e) => PerformTrigonometricFunction(Math.Sin);
        private void btnTan_Click(object sender, EventArgs e) => PerformTrigonometricFunction(Math.Sin);
        private void btnATan_Click(object sender, EventArgs e) => PerformTrigonometricFunction(Math.Sin);

        private void btnCot_Click(object sender, EventArgs e)
        {
            if (double.TryParse(resultTextBox.Text, out double value))
            {
                double result = 1 / Math.Tan(value); // Котангенс равен 1/тангенсу
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnACot_Click(object sender, EventArgs e)
        {
            if (double.TryParse(resultTextBox.Text, out double value))
            {
                double result = Math.Atan(1 / value); // Арккотангенс равен арктангенсу 1/x
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Метод для добавления записи в историю вычислений
        private void AddToHistory(string entry)
        {
            historyListBox.Items.Add(entry); // Добавляем запись в ListBox истории
        }

        // Обработчик нажатия кнопки очистки истории
        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            historyListBox.Items.Clear(); // Очищаем ListBox истории
        }
    }
}