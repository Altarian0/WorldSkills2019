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

namespace WorldSkills2019.Pages
{
    /// <summary>
    /// Interaction logic for EmManagingPage.xaml
    /// </summary>
    public partial class EmManagingPage : Page
    {
        public EmManagingPage(Employees employees)
        {
            InitializeComponent();

            AssetsList.ItemsSource = DBHelper.GetContext().Assets.Where(n=>n.EmployeeID == employees.ID).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendEMButton_Click(object sender, RoutedEventArgs e)
        {
            if(AssetsList.SelectedItem == null)
            {
                MessageBox.Show("Select asset!", "Warning");
                return;
            }

            NavigationService.Navigate(new EMRequestPage((Assets)AssetsList.SelectedItem));
        }
    }
}
