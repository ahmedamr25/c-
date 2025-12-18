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
using views.employe.vehicle;

namespace views.employe.reservation
{
    /// <summary>
    /// Logique d'interaction pour Listchoix.xaml
    /// </summary>
    public partial class Listchoix : Window
    {
        public Listchoix()
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

        private void btn_addreservation(object sender, RoutedEventArgs e)
        {
            // Créer et afficher la fenêtre d'inscription
            addreservation signUpWindow = new addreservation();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

        private void btn_listreservation(object sender, RoutedEventArgs e)
        {

            // Créer et afficher la fenêtre d'inscription
            Listereservation signUpWindow = new Listereservation();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

        private void btn_return(object sender, RoutedEventArgs e)
        {

            // Créer et afficher la fenêtre d'inscription
            dashboardemploye signUpWindow = new dashboardemploye();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }
    }
}
