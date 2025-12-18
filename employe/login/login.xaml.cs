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

namespace views.employe.login
{
    /// <summary>
    /// Logique d'interaction pour login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
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

        private void btndashboard(object sender, RoutedEventArgs e)
        {
            // Créer et afficher la fenêtre d'inscription
            dashboardemploye signUpWindow = new dashboardemploye();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

    }
}
