using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using views.employe.dashboard;

namespace views.employe.customer
{
    /// <summary>
    /// Logique d'interaction pour Listcustomer.xaml
    /// </summary>
    public partial class Listcustomer : Window
    {
        public Listcustomer()
        {
            InitializeComponent();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Btn_return(object sender, RoutedEventArgs e)
        {
            choose signUpWindow = new choose();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

        private void btn_update(object sender, RoutedEventArgs e)
        {
            updatecustomer signUpWindow = new updatecustomer();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }
    }
}
