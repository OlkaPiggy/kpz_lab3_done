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
using System.Windows.Shapes;

namespace DB_First
{
    /// <summary>
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        HotelSystemDBEntities _db = new HotelSystemDBEntities();
        int Id;
        public Update(int hotelId)
        {
            InitializeComponent();
            Id = hotelId;
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
                        hotel updateHotel = (from h in _db.hotels
                                where h.id == Id
                                select h).Single();
            _db.SaveChanges();
            MainWindow.dataGrid.ItemsSource = _db.hotels.ToList();
            this.Hide();
        }
    }
}
