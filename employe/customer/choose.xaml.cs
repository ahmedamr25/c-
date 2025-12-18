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

namespace views.employe.customer
{
    /// <summary>
    /// Logique d'interaction pour choose.xaml
    /// </summary>
    public partial class choose : Window
    {
        public choose()
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
        private void btn_return(object sender, RoutedEventArgs e)
        {
            // Créer et afficher la fenêtre d'inscription
            dashboardemploye signUpWindow = new dashboardemploye();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

        private void btn_customer(object sender, RoutedEventArgs e)
        {
            // Créer et afficher la fenêtre d'inscription
            addcostumer signUpWindow = new addcostumer();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

        private void btn_listcustemer(object sender, RoutedEventArgs e)
        {
            // Créer et afficher la fenêtre d'inscription
            Listcustomer signUpWindow = new Listcustomer();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }
    }
}
