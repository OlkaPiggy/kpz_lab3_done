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
    /// Interaction logic for Insert.xaml
    /// </summary>
    public partial class Insert : Window
    {
        public Insert()
        {
            InitializeComponent();
        }
        HotelSystemDBEntities _db = new HotelSystemDBEntities();

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            hotel newHotel = new hotel()
            {
                name = nameBox.Text,
                address = addressBox.Text,
                price = priceBox.Text,
                type = typeBox.Text
            };
            _db.hotels.Add(newHotel);
            _db.SaveChanges();
            MainWindow.dataGrid.ItemsSource = _db.hotels.ToList();
            this.Hide();
        }
    }
}
