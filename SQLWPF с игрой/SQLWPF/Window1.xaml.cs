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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SQLWPF
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private SqlConnection sqlConnection = null;

        public Window1()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Zа-яА-Я ]+$");
            if (!regex.IsMatch(TextBox1.Text) || !regex.IsMatch(TextBox2.Text) || !regex.IsMatch(TextBox3.Text) || regex.IsMatch(TextBox7.Text))
            {

                MessageBox.Show("Введите корректные данные");
            }
            else
            {
                if (((string.IsNullOrEmpty(TextBox1.Text))) || ((string.IsNullOrEmpty(TextBox2.Text))) || ((string.IsNullOrEmpty(TextBox3.Text))) || ((string.IsNullOrEmpty(TextBox4.Text))) || ((string.IsNullOrEmpty(TextBox5.Text))) || ((string.IsNullOrEmpty(TextBox6.Text))) || ((string.IsNullOrEmpty(TextBox7.Text)))) MessageBox.Show("Данные не введены");
                else
                {
                    sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO [Teachers] (Фамилия, Имя, Отчество, Дата_рождения, Должность, Ученая_степень, Зарплата) VALUES (N'{TextBox1.Text}', N'{TextBox2.Text}', N'{TextBox3.Text}', '{TextBox4.Text}', N'{TextBox5.Text}', N'{TextBox6.Text}', N'{TextBox7.Text}')", sqlConnection);
                    int a = command.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Данные записаны");
                    }
                    TextBox1.Text = String.Empty;
                    TextBox2.Text = String.Empty;
                    TextBox3.Text = String.Empty;
                    TextBox4.Text = String.Empty;
                    TextBox5.Text = String.Empty;
                    TextBox6.Text = String.Empty;
                    TextBox7.Text = String.Empty;
                }
            }
        }

        private void TextBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[а-яА-Я]+");
            if (!re.IsMatch(e.Text))
            {
                TextBox1.Background = Brushes.Red;
            }
            else
            {
                TextBox1.Background = Brushes.White;
            }

        }

      

        private void TextBox2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[а-яА-Я]+");
            if (!re.IsMatch(e.Text))
            {
                TextBox2.Background = Brushes.Red;
            }
            else
            {
                TextBox2.Background = Brushes.White;
            }
        }

       
        private void TextBox3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[а-яА-Я]+");
            if (!re.IsMatch(e.Text))
            {
                TextBox3.Background = Brushes.Red;
            }
            else
            {
                TextBox3.Background = Brushes.White;
            }
        }
        private void TextBox7_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[а-яА-Яa-zA-Z]+");
            if (re.IsMatch(e.Text))
            {
                TextBox7.Background = Brushes.Red;
            }
            else
            {
                TextBox7.Background = Brushes.White;
            }
        }

       
    }
}
