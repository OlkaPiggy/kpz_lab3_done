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

namespace DB_First
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HotelSystemDBEntities _db = new HotelSystemDBEntities();
        public static DataGrid dataGrid;
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            myDataGrid.ItemsSource = _db.hotels.ToList();
            dataGrid = myDataGrid;
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            Insert iPage = new Insert();
            iPage.ShowDialog();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id=(myDataGrid.SelectedItem as hotel).id;
            Update uPage = new Update(Id);
            uPage.ShowDialog();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as hotel).id;
            var deleteHotel = _db.hotels.Where(h => h.id == Id).Single();
            _db.hotels.Remove(deleteHotel);

            _db.SaveChanges();
            dataGrid.ItemsSource = _db.hotels.ToList();
            //this.Hide();
        }
    }
}
