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
using views.employe.vehicle;

namespace views.admin.registeremploye
{
    /// <summary>
    /// Logique d'interaction pour Listemploye.xaml
    /// </summary>
    public partial class Listemploye : Window
    {
        public Listemploye()
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

        private void btn_update(object sender, RoutedEventArgs e)
        {
            // Créer et afficher la fenêtre d'inscription
            update signUpWindow = new update();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();





        }

        private void btn_return(object sender, RoutedEventArgs e)
        {

            // Créer et afficher la fenêtre d'inscription
            choose signUpWindow = new choose();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }
    }
}
