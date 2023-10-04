using System;
using Hotel.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Teatr.Model;

namespace Teatr.Views
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        int password;
        public SignIn()
        {
            InitializeComponent();

        }
        public void Convertator()
        {
           password = Convert.ToInt32(passBox.Text);
        }
        private void SignUpBT(object sender, RoutedEventArgs e)
        {

            Convertator();
            var currentUser = AppData.db.Users.FirstOrDefault(u => u.Login == loginBox.Text && u.Password == password);
            if (currentUser != null && currentUser.idRole == 1)
            {
                NavigationService.Navigate(new adminPage());
            }
            else if (currentUser != null && currentUser.idRole == 2)
            {
                NavigationService.Navigate(new managerPage());
            }
            else if (currentUser != null && currentUser.idRole == 3)
            {
                NavigationService.Navigate(new guestPage());
            }
            else
            {
                MessageBox.Show("Неверно");
            }
            
        }

        private void regBT(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new registerPage());
        }

        private void loginBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
