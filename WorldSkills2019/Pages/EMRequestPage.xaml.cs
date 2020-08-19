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
    /// Interaction logic for EMRequestPage.xaml
    /// </summary>
    public partial class EMRequestPage : Page
    {
        private EmergencyMaintenances EmergencyMaintenances = new EmergencyMaintenances();
        public EMRequestPage(Assets assets)
        {
            InitializeComponent();

            EmergencyMaintenances.Assets = assets;
            EmergencyMaintenances.AssetID = assets.ID;
            DataContext = EmergencyMaintenances;

            PriorityCombo.ItemsSource = DBHelper.GetContext().Priorities.ToList();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SendRequestButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(EmergencyMaintenances.DescriptionEmergency))
                errors.AppendLine("Enter the EM Description.");
            if (EmergencyMaintenances.Priorities == null)
                errors.AppendLine("Select th EM priority.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (EmergencyMaintenances.OtherConsiderations == "" || EmergencyMaintenances.OtherConsiderations == null)
                EmergencyMaintenances.OtherConsiderations = "none";

            EmergencyMaintenances.EMStartDate = DateTime.Now;
            EmergencyMaintenances.EMReportDate = DateTime.Now;
            EmergencyMaintenances.PriorityID = EmergencyMaintenances.Priorities.ID;

            DBHelper.GetContext().EmergencyMaintenances.Add(EmergencyMaintenances);
            DBHelper.GetContext().SaveChanges();

            NavigationService.GoBack();
        }
    }
}
