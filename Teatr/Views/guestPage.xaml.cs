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
    /// Логика взаимодействия для guestPage.xaml
    /// </summary>
    public partial class guestPage : Page
    {
        public guestPage()
        {
            InitializeComponent();
        }

        private void BroneFunc(object sender, RoutedEventArgs e)
        {
            var curHotel = HotelGrid.SelectedItem as HotelList;
            try
            {
                curHotel.status = "Забронировано";
                MessageBox.Show("Успешная Бронь!");
                
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            HotelGrid.ItemsSource = AppData.db.HotelList.ToList();
        }

        private void Refrsh(object sender, RoutedEventArgs e)
        {
              HotelGrid.ItemsSource = AppData.db.HotelList.ToList();
                MessageBox.Show("Обновлено");
          
        }


    }
}
