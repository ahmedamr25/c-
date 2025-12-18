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

namespace views.employe.vehiculeType
{
    /// <summary>
    /// Logique d'interaction pour addtype.xaml
    /// </summary>
    public partial class addtype : Window
    {
        public addtype()
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
            listchoix signUpWindow = new listchoix();
            signUpWindow.Show();

            // Fermer la fenêtre de connexion actuelle
            this.Close();
        }
    }
}
