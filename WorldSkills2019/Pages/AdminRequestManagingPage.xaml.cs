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
using WorldSkills2019.Helper;
using WorldSkills2019.Database;

namespace WorldSkills2019.Pages
{
    /// <summary>
    /// Interaction logic for AdminRequestManagingPage.xaml
    /// </summary>
    public partial class AdminRequestManagingPage : Page
    {
        public AdminRequestManagingPage(Employees employees)
        {
            InitializeComponent();
            EmRequestList.ItemsSource = DBHelper.GetContext().EmergencyMaintenances.ToList();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageRequestButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmRequestList.SelectedItem == null)
            {
                MessageBox.Show("Select EmergencyMaintenances!!!");
                return;
            }

            NavigationService.Navigate(new AdminRequestPage((EmergencyMaintenances)EmRequestList.SelectedItem));
        }
    }
}
