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
using views.employe.customer;
using views.employe.reservation;
using views.employe.vehicle;

namespace views.employe.dashboard
{
    /// <summary>
    /// Logique d'interaction pour dashboardemploye.xaml
    /// </summary>
    public partial class dashboardemploye : Window
    {
        public dashboardemploye()
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

        private void Button_car(object sender, RoutedEventArgs e)
        {
            // Créer et afficher la fenêtre d'inscription
            car signUpWindow = new car();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

        private void Button_costumer(object sender, RoutedEventArgs e)
        {
            choose signUpWindow = new choose();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

        private void Button_carrent(object sender, RoutedEventArgs e)
        {
            Listchoix signUpWindow = new Listchoix(); 
            signUpWindow.Show();
            this.Close();
        }
    }
}
