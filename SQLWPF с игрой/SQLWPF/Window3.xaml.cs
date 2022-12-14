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
using System.Windows.Shapes;

namespace SQLWPF
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 taskWindow = new Window1();
            taskWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Show taskWindow = new Show();
            taskWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Poisk taskWindow = new Poisk();
            taskWindow.Show();
        }
    }
}
