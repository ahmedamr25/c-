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
using views.admin.login;
using views.employe.login;

namespace views.intro
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
        private void btn_Employe(object sender, RoutedEventArgs e)
        {
            login signUpWindow = new login();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }


        private void btn_Admin(object sender, RoutedEventArgs e)
        {

            loginadmin signUpWindow = new loginadmin();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }
    }
}
