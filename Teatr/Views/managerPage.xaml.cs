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
    /// Логика взаимодействия для managerPage.xaml
    /// </summary>
    public partial class managerPage : Page
    {
        public managerPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            HotelGrid.ItemsSource = AppData.db.HotelList.ToList();
        }

 

        private void refreshTeathre(object sender, RoutedEventArgs e)
        {
            HotelGrid.ItemsSource = AppData.db.HotelList.ToList();
            MessageBox.Show("Обновлено");
        }

        private void addTheatre(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(idBox.Text) && !string.IsNullOrEmpty(nameBox.Text) && !string.IsNullOrEmpty(dateBox.Text))
                {
                    HotelList theatre = new HotelList();
                    theatre.id = Convert.ToInt32(idBox.Text);
                    theatre.hotelname = nameBox.Text;
                    theatre.@class = dateBox.Text;
                    theatre.term = Termbx.Text;
                    theatre.status = Statusbx.Text;

                    AppData.db.HotelList.Add(theatre);
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

   

        private void Edit(object sender, RoutedEventArgs e)
        {
            var curHotel = HotelGrid.SelectedItem as HotelList;
            try
            {
                if (!string.IsNullOrEmpty(newName.Text) && !string.IsNullOrEmpty(classBX.Text) && !string.IsNullOrEmpty(termBX.Text) && !string.IsNullOrEmpty(statusbx.Text))
                {
                    curHotel.hotelname = newName.Text;
                    curHotel.@class= classBX.Text;
                    curHotel.term = Termbx.Text;
                    curHotel.status = statusbx.Text;
                    AppData.db.SaveChanges();
                    MessageBox.Show("Изменения внесены!");
                }
                else if (!string.IsNullOrEmpty(newName.Text))
                {
                    curHotel.hotelname = newName.Text;
                    AppData.db.SaveChanges();
                    MessageBox.Show("Изменения внесены!");
                }
                else if (!string.IsNullOrEmpty(newName.Text) && !string.IsNullOrEmpty(classBX.Text))
                {
                    curHotel.hotelname = newName.Text;
                    curHotel.@class = classBX.Text;
                    AppData.db.SaveChanges();
                    MessageBox.Show("Изменения внесены!");
                }
                else if (!string.IsNullOrEmpty(newName.Text) && !string.IsNullOrEmpty(termBX.Text))
                {
                    curHotel.hotelname = newName.Text;
                    curHotel.term = Termbx.Text;
                    AppData.db.SaveChanges();
                    MessageBox.Show("Изменения внесены!");
                }
                else if (!string.IsNullOrEmpty(newName.Text) && !string.IsNullOrEmpty(statusbx.Text))
                {
                    curHotel.hotelname = newName.Text;
                    curHotel.status = Statusbx.Text;
                    AppData.db.SaveChanges();
                    MessageBox.Show("Изменения внесены!");
                }
                else if (!string.IsNullOrEmpty(termBX.Text))
                {
                    curHotel.term = termBX.Text;
                    AppData.db.SaveChanges();
                    MessageBox.Show("Изменения внесены!");
                }
                else if (!string.IsNullOrEmpty(classBX.Text))
                {
                    curHotel.@class = classBX.Text;
                    AppData.db.SaveChanges();
                    MessageBox.Show("Изменения внесены!");
                }
                else if (!string.IsNullOrEmpty(classBX.Text) && !string.IsNullOrEmpty(termBX.Text))
                {
                    curHotel.@class = classBX.Text;
                    curHotel.term = Termbx.Text;
                    AppData.db.SaveChanges();
                    MessageBox.Show("Изменения внесены!");
                }
                else if (!string.IsNullOrEmpty(classBX.Text) && !string.IsNullOrEmpty(statusbx.Text))
                {
                    curHotel.@class = classBX.Text;
                    curHotel.term = Termbx.Text;
                    AppData.db.SaveChanges();
                    MessageBox.Show("Изменения внесены!");
                }
                else if (!string.IsNullOrEmpty(statusbx.Text))
                {
                    curHotel.status = statusbx.Text;
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

        private void searchTheatre(object sender, RoutedEventArgs e)
        {
            if (seatchBox.Text != null)
            {
                try
                {
                    HotelGrid.ItemsSource = AppData.db.HotelList.Where(item => item.hotelname == seatchBox.Text).ToList();
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void deleteTheatre(object sender, RoutedEventArgs e)
        {
            try
            {
                var curHotel = HotelGrid.SelectedItem as HotelList;
                AppData.db.HotelList.Remove(curHotel);
                AppData.db.SaveChanges();

                HotelGrid.ItemsSource = AppData.db.HotelList.ToList();
                MessageBox.Show("Успешно");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
