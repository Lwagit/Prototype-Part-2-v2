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
using System.Windows;

namespace MyApplication
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Code to open the Submit Claim form
        }

        private void ViewClaimsButton_Click(object sender, RoutedEventArgs e)
        {
            // Code to open the View Claims form
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            // Code to open the Settings form
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            // Code to exit the application
            Application.Current.Shutdown();
        }
    }
}

