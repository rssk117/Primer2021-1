using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buton1_Click(object sender, RoutedEventArgs e)
        {
         /*   int x1; bool f1;
            //Берем целое значение из TextBox и конвертируем число x1
            //При успешной конвертации f1=true иначе f1=false
            f1 = Int32.TryParse(textBox1.Text, out x1);
            if (f1 == true) x1 = x1 * 2;//Расчет
            else
            {
                MessageBox.Show("Исходные данные неверны");
                textBox1.Focus();//Фокус в поле ввода
            }*/
        }

        // Ввод тлько цифровых данных
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {            
         /*   if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Back);
            else
            {
                MessageBox.Show("Введите цифровые данные");
                e.Handled = true;
            }*/
        }

        private void textBox1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
        //    if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Back) ;
        //    else e.Handled = true;
        }

        private void textBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Char val = Convert.ToChar(e.Text);
            if (Char.IsDigit(val));
            else
            {
                MessageBox.Show("Введите цифровые данные");
                e.Handled = true; // отклоняем ввод
            }
        }
        string value;
        private void textBox2_GotFocus(object sender, RoutedEventArgs e)
        {
            value = ((TextBox)(sender)).Text;//Запоминаем исходное знсчение
        }
        private void textBox2_LostFocus(object sender, RoutedEventArgs e)
        {
            int x1; bool f1;
            //Проверяем значение
            f1 = Int32.TryParse(((TextBox)(sender)).Text, out x1);
            //Если значение неверное возвращаем старое значение
            if (f1 == false) 
            { 
                MessageBox.Show("Исходные данные неверны");
                ((TextBox)(sender)).Text = value; 
            }
        }

        private void textBox2_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x;
            x = Convert.ToInt32(textBox3.Text);
            x = x * 2;
        }
    }
}
