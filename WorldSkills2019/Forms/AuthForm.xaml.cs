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
using WorldSkills2019.Database;
using WorldSkills2019.Helper;

namespace WorldSkills2019.Forms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AuthForm : Window
    {
        public AuthForm()
        {
            InitializeComponent();


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employees employees = DBHelper.GetContext().Employees.Where(n=>n.Username == LoginBox.Text && n.Password == PasswordBox.Text).Single();

                MainWindow mainWindow = new MainWindow(employees);
                mainWindow.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Login or Password!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
