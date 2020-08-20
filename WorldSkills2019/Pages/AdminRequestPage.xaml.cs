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
    /// Interaction logic for AdminRequestManagingPage.xaml
    /// </summary>
    public partial class AdminRequestPage : Page
    {
        private EmergencyMaintenances EmergencyMaintenances = new EmergencyMaintenances();
        public AdminRequestPage(EmergencyMaintenances emergencyMaintenances)
        {
            InitializeComponent();

            PartComboBox.ItemsSource = DBHelper.GetContext().Parts.ToList();
            this.EmergencyMaintenances = emergencyMaintenances;


            foreach (var part in EmergencyMaintenances.ChangedParts.ToList())
            {
                PartList.Items.Add(part);
            }

            EmergencyMaintenances.EMEndDate = DateTime.Now.Date;
            DataContext = emergencyMaintenances;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PartList.Items.Remove(PartList.SelectedItem);
            DBHelper.GetContext().ChangedParts.Remove((ChangedParts)PartList.SelectedItem);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPartButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ChangedParts parts = new ChangedParts()
                {
                    Amount = decimal.Parse(AmountBox.Text),
                    PartID = ((Parts)PartComboBox.SelectedItem).ID,
                    Parts = ((Parts)PartComboBox.SelectedItem),
                    EmergencyMaintenanceID = EmergencyMaintenances.ID
                };
            EmergencyMaintenances.ChangedParts.Add(parts);
            PartList.Items.Add(parts);
            }
            catch
            {
                MessageBox.Show("Write valid amount!");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            DBHelper.GetContext().SaveChanges();
        }
    }
}
