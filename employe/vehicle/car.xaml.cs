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
using views.employe.reservation;
using views.employe.vehiculeType;

namespace views.employe.vehicle
{
    /// <summary>
    /// Logique d'interaction pour car.xaml
    /// </summary>
    public partial class car : Window
    {
        public car()
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

        private void btn_addcar(object sender, RoutedEventArgs e)
        {
            // Créer et afficher la fenêtre d'inscription
            addcar signUpWindow = new addcar();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();

        }

        private void btn_listcar(object sender, RoutedEventArgs e)
        {
            // Créer et afficher la fenêtre d'inscription
            Listvehicle signUpWindow = new Listvehicle();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

        private void btn_typecar(object sender, RoutedEventArgs e)
        {
            listchoix signUpWindow = new listchoix();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

        private void btn_return(object sender, RoutedEventArgs e)
        {
            dashboardemploye signUpWindow = new dashboardemploye();
            this.Close();
        }
    }
}
