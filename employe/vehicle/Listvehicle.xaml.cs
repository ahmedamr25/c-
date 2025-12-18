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

namespace views.employe.vehicle
{
    /// <summary>
    /// Logique d'interaction pour Listvehicle.xaml
    /// </summary>
    public partial class Listvehicle : Window
    {
        public Listvehicle()
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

        private void Button_return(object sender, RoutedEventArgs e)
        {
            car signUpWindow = new car();
            signUpWindow.Show();
            this.Close();
           
        }

        private void btn_update(object sender, RoutedEventArgs e)
        {
            update signUpWindow = new update();
            signUpWindow.Show();
            this.Close();
        }
    }
}
