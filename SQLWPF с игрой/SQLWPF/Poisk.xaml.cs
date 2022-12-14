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
    /// Логика взаимодействия для Poisk.xaml
    /// </summary>
    public partial class Poisk : Window
    {
        private SqlConnection sqlConnection = null;
        public Poisk()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           if(fam.Text.Equals(""))
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"Select * From Teachers where  [Должность]=N'" + dol.Text + "'", sqlConnection);
                DataTable dt = new DataTable("Teachers");
                adapter.Fill(dt);
                datagrid1.ItemsSource = dt.DefaultView;
            }
               
            if(dol.Text.Equals(""))
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"Select * From Teachers where [Фамилия]=N'" + fam.Text + "'", sqlConnection);
                DataTable dt = new DataTable("Teachers");
                adapter.Fill(dt);
                datagrid1.ItemsSource = dt.DefaultView;
            }
            if (!fam.Text.Equals("") && !dol.Text.Equals(""))
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"Select * From Teachers where [Фамилия]=N'" + fam.Text + "' and [Должность]=N'" + dol.Text + "'", sqlConnection);
                DataTable dt = new DataTable("Teachers");
                adapter.Fill(dt);
                datagrid1.ItemsSource = dt.DefaultView;
            }
        }

    }
}
