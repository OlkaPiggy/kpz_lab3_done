using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
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
using Lab3.Models;

namespace Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Model1 studentAccount;
        public MainWindow()
        {
            InitializeComponent();
            studentAccount = new Model1();       
            HTab.ItemsSource = studentAccount.Hotels.ToList();
        }

        private void Student_Open(object sender, RoutedEventArgs e)
        {
            HotelPage.Visibility = Visibility.Visible;
        }

        #region Student Page
        private void DeleteStudent_Button(object sender, RoutedEventArgs e)
        {
            if (HTab.SelectedItem is Hotel)
            {
                studentAccount.Hotels.Remove((Hotel)HTab.SelectedItem);
                studentAccount.SaveChanges();
                HTab.ItemsSource = studentAccount.Hotels.ToList();
            }
        }

        private void AddStudent_Button(object sender, RoutedEventArgs e)
        {
            //int id = int.Parse(Id_Acc.Text);

            studentAccount.Hotels.Add(new Hotel()
                {
                Id= int.Parse(Id_Acc.Text),
                Name = Name.Text,
                    Address = Address.Text,
                    Price = int.Parse(Price.Text),
                    Type = Type.Text,
                });
                studentAccount.SaveChanges();
                HTab.ItemsSource = studentAccount.Hotels.ToList();
            
        }

        private void ChangeStudent_Button(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(Id_Acc.Text);
            var item =HTab.SelectedItem as Hotel;
            item.Name = Name.Text;
            item.Address = Address.Text;
            item.Price = int.Parse(Price.Text);
            item.Type = Type.Text;
            item.Id = id;
           
            studentAccount.SaveChanges();
            HTab.ItemsSource = studentAccount.Hotels.ToList();
        }

        private void HTab_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (HTab.SelectedItem is Hotel)
            {
                var item = HTab.SelectedItem as Hotel;
                Name.Text = item.Name;
                Address.Text = item.Address;
                Price.Text = item.Price.ToString();
                Id_Acc.Text = item.Id.ToString();
                Type.Text = item.Type.ToString();
            }
        }

        #endregion

    }
}