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

namespace views.employe.payment
{
    /// <summary>
    /// Logique d'interaction pour choix.xaml
    /// </summary>
    public partial class choix : Window
    {
        public choix()
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

        private void btn_payment(object sender, RoutedEventArgs e)
        {
            addpayment signUpWindow = new addpayment();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

        private void btn_listpayment(object sender, RoutedEventArgs e)
        {

            Listpayment signUpWindow = new Listpayment();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }

        private void btn_return(object sender, RoutedEventArgs e)
        {
            dashboardemploye signUpWindow = new dashboardemploye();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();

        }
    }
}
