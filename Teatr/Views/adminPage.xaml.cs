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
    /// Логика взаимодействия для adminPage.xaml
    /// </summary>
    public partial class adminPage : Page
    {
        public adminPage()
        {
            InitializeComponent();
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            if (seatchBox.Text != null)
            {
                try
                {
                    UsersGrid.ItemsSource = AppData.db.Users.Where(item => item.Login == seatchBox.Text).ToList();
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UsersGrid.ItemsSource = AppData.db.Users.ToList();
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            UsersGrid.ItemsSource = AppData.db.Users.ToList();
            MessageBox.Show("Обновлено");
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(loginBox.Text) && !string.IsNullOrEmpty(passwordBox.Text) && !string.IsNullOrEmpty(idBox.Text) && !string.IsNullOrEmpty(roleBox.Text))
                {
                    Users person = new Users();
                    person.Login = loginBox.Text;
                    person.Password = Convert.ToInt32(passwordBox.Text);
                    person.IdUsers = Convert.ToInt32(idBox.Text);
                    if(roleBox.Text == "Администратор" || roleBox.Text == "Админ" || roleBox.Text == "1")
                    {
                        person.idRole = 1;
                        person.Name = "Admin";
                    }
                    else if(roleBox.Text == "Менеджер" || roleBox.Text == "2")
                    {
                        person.idRole = 2;
                        person.Name = "Manager";
                    }
                    else if(roleBox.Text == "Гость" || roleBox.Text == "3")
                    {
                        person.idRole = 3;
                        person.Name = "Guest";
                    }
                    else
                    {
                        MessageBox.Show("Такой роли нет");
                    }
                    AppData.db.Users.Add(person);
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

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                var curUser = UsersGrid.SelectedItem as Users;
                AppData.db.Users.Remove(curUser);
                AppData.db.SaveChanges();

                UsersGrid.ItemsSource = AppData.db.Users.ToList();
                MessageBox.Show("Успешно");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            var curUser = UsersGrid.SelectedItem as Users;
            try
            {
                if (!string.IsNullOrEmpty(newLog.Text) && !string.IsNullOrEmpty(newPass.Text))
                {
                    curUser.Password = Convert.ToInt32(newPass.Text);
                    curUser.Login = newLog.Text;
                    AppData.db.SaveChanges();
                    MessageBox.Show("Изменения внесены!");
                }
                else if (!string.IsNullOrEmpty(newPass.Text))
                {
                    curUser.Password = Convert.ToInt32(newPass.Text);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Изменения внесены!");
                }
                else if (!string.IsNullOrEmpty(newLog.Text))
                {
                    curUser.Login = newLog.Text;
                    AppData.db.SaveChanges();
                    MessageBox.Show("Изменения внесены!");
                }
                else
                {
                    MessageBox.Show("Пусто!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
            
        }
    }
}
