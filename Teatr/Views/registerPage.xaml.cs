using System;
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
    /// Логика взаимодействия для registerPage.xaml
    /// </summary>
    public partial class registerPage : Page
    {
        public registerPage()
        {
            InitializeComponent();
        }

        private void regBT(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(loginBox.Text) && !string.IsNullOrEmpty(passwordBox.Text) && !string.IsNullOrEmpty(idBox.Text))
                {
                    Users regperson = new Users();
                    regperson.Login = loginBox.Text;
                    regperson.Password = Convert.ToInt32(passwordBox.Text);
                    regperson.IdUsers = Convert.ToInt32(idBox.Text);
                
                        regperson.idRole = 3;
                        regperson.Name = "Guest";
                  
               
                 
                    AppData.db.Users.Add(regperson);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Успешно");
                }
                else
                {
                    MessageBox.Show("Заполните все!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
