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
using WorldSkills2019.Database;
using WorldSkills2019.Pages;

namespace WorldSkills2019.Forms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(Employees employees)
        {
            InitializeComponent();

            if (employees.isAdmin == true)
                MainFrame.Navigate(new AdminRequestManagingPage(employees));
            else
                MainFrame.Navigate(new EmManagingPage(employees));
        }
    }
}
