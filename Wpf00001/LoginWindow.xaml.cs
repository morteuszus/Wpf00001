using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

using Wpf00001.Core;

namespace Wpf00001
{
    /// <summary>
    /// Logika interakcji dla klasy LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            //APIClient.Aaa();     
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon=new SqlConnection("Data Source=desktop-8co37jh\\sqlexpress01;Initial Catalog=LoginDB;Integrated Security=True");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                sqlCon.Open();  
                }
                //MessageBox.Show("Connected Succesfuly");
                String query = "Select * from tblUsers where Username=@Username AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query,sqlCon);
                cmd.CommandType=CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if(count != 0)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show(); 
                    this.Close();  
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            //rozwiązanie tymczasowe 
            MessageBox.Show("Baza danych działa lokalnie a api przestało działać więc tego...");
            MainWindow mainWindowx = new MainWindow();
            mainWindowx.Show();
            this.Close();
            //---------------
        }
    }
}
