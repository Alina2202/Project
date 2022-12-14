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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SQLWPF
{
    /// <summary>
    /// Логика взаимодействия для Show.xaml
    /// </summary>
    public partial class Show : Window
    {
        private SqlConnection sqlConnection = null;
        public Show()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter($"Select * From Teachers", sqlConnection);
            DataTable dt = new DataTable("Teachers");
            adapter.Fill(dt);
            datagrid.ItemsSource = dt.DefaultView;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter($"Select * From Teachers", sqlConnection);
            DataTable dt = new DataTable("Teachers");
            adapter.Fill(dt);
            datagrid.ItemsSource = dt.DefaultView;

        }
    }
}
