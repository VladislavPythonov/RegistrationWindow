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
using System.Text.RegularExpressions;

namespace RecordBogomolov
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
            string pass2 = passBox2.Password.Trim();
            string email = textBoxEmail.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(pass2) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (pass.Length <= 5 || pass2.Length <= 5)
            {
                MessageBox.Show("Пароль должен содержать как минимум 6 символов");
                return;
            }

            if (pass != pass2)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Введите корректный адрес электронной почты");
                return;
            }

            MessageBox.Show("Регистрация прошла успешно!");
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                textBox.ToolTip = "Это поле обязательно для заполнения";
                textBox.Background = Brushes.DarkRed;
            }
            else
            {
                textBox.ToolTip = "";
                textBox.Background = Brushes.Transparent;
            }
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            if (string.IsNullOrEmpty(passwordBox.Password.Trim()))
            {
                passwordBox.ToolTip = "Это поле обязательно для заполнения";
                passwordBox.Background = Brushes.DarkRed;
            }
            else
            {
                passwordBox.ToolTip = "";
                passwordBox.Background = Brushes.Transparent;
            }
        }

        private void PasswordBox2_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            if (string.IsNullOrEmpty(passwordBox.Password.Trim()))
            {
                passwordBox.ToolTip = "Это поле обязательно для заполнения";
                passwordBox.Background = Brushes.DarkRed;
            }
            else
            {
                passwordBox.ToolTip = "";
                passwordBox.Background = Brushes.Transparent;
            }
        }
    }
}
