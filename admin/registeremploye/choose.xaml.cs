using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using views.admin.dashboard;
using views.employe.vehicle;

namespace views.admin.registeremploye
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

        private void btn_addemploye(object sender, RoutedEventArgs e)
        {
            // Créer et afficher la fenêtre d'inscription
            addemploye signUpWindow = new addemploye();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();





        }

        private void btn_listemploye(object sender, RoutedEventArgs e)
        {

            // Créer et afficher la fenêtre d'inscription
            Listemploye signUpWindow = new Listemploye();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

        private void btn_return(object sender, RoutedEventArgs e)
        {

            Dashboard signUpWindow = new Dashboard();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }
    }
}
