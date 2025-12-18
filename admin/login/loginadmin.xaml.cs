using Microsoft.Win32;
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
using views.admin.dashboard;
using views.admin.register;
using views.employe.vehicle;
using views.employe.vehiculeType;
namespace views.admin.login
{

    /// <summary>
    /// Logique d'interaction pour loginadmin.xaml
    /// </summary>
    public partial class loginadmin : Window
    {
        public loginadmin()
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

        private void SignUpText_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Créer et afficher la fenêtre d'inscription
            Register signUpWindow = new Register();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Créer et afficher la fenêtre d'inscription
            Dashboard signUpWindow = new Dashboard();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }
    }
}
