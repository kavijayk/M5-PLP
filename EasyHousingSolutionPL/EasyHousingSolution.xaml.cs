using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using EasyHousingSolutionBLL;
using EasyHousingSolutionEntity;
using EHSException;
 

namespace EasyHousingSolutionPL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AddProperty cw = new AddProperty();           
            cw.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string newUser = Application.Current.Properties["username"].ToString();
            //string uname=Application.Current.Properties["usertype"].ToString();
            //string uname = "Buyer";

            if (newUser.Equals("Seller"))
            {              
                addMenu.Visibility = Visibility.Visible;
                addSubmenu.Visibility = Visibility.Visible;
                editMenu.Visibility = Visibility.Visible;
                viewMenu.Visibility = Visibility.Visible;
                viewVerifiedSubmenu.Visibility = Visibility.Visible;
                viewDeactSubmenu.Visibility = Visibility.Visible;
                uploadImgSubmenu.Visibility = Visibility.Visible;

            }
            else if (newUser == "Admin")
            {                
                viewMenu.Visibility = Visibility.Visible;
                verifyMenu.Visibility = Visibility.Visible;
                deleteMenu.Visibility = Visibility.Visible;
                viewOwnerSubmenu.Visibility = Visibility.Visible;
                viewRegionSubmenu.Visibility = Visibility.Visible;
            }
            else if (newUser == "Buyer")
            {
                searchMenu.Visibility = Visibility.Visible;
                cartMenu.Visibility = Visibility.Visible;
                viewMenu.Visibility = Visibility.Visible;
                viewDetailsSubmenu.Visibility = Visibility.Visible;
            }
        }

        private void addSubmenu_Click(object sender, RoutedEventArgs e)
        {
            AddProperty obj = new AddProperty();
            this.Hide();
            obj.Show();
        }

        private void uploadImgSubmenu_Click(object sender, RoutedEventArgs e)
        {
            UploadImage obj = new UploadImage();
            this.Hide();
            obj.Show();
        }

        private void editMenu_Click(object sender, RoutedEventArgs e)
        {
            EditProperty obj = new EditProperty();
            this.Hide();
            obj.Show();
        }

        private void viewVerifiedSubmenu_Click(object sender, RoutedEventArgs e)
        {
            ViewVerifiedProperty obj = new ViewVerifiedProperty();
            this.Hide();
            obj.Show();
        }

        private void viewDeactSubmenu_Click(object sender, RoutedEventArgs e)
        {
            ViewDeactivatedProperty obj = new ViewDeactivatedProperty();
            this.Hide();
            obj.Show();
        }

        private void viewRegionSubmenu_Click(object sender, RoutedEventArgs e)
        {
            ViewPropertyByRegion obj = new ViewPropertyByRegion();
            this.Hide();
            obj.Show();
        }

        private void viewOwnerSubmenu_Click(object sender, RoutedEventArgs e)
        {
            ViewPropertyByOwner obj = new ViewPropertyByOwner();
            this.Hide();
            obj.Show();
        }

        private void viewDetailsSubmenu_Click(object sender, RoutedEventArgs e)
        {
            ViewProperty obj = new ViewProperty();
            this.Hide();
            obj.Show();
        }

        private void searchMenu_Click(object sender, RoutedEventArgs e)
        {
            Search obj = new Search();
            this.Hide();
            obj.Show();
        }

        private void deleteMenu_Click(object sender, RoutedEventArgs e)
        {
            ViewProperty obj = new ViewProperty();
            this.Hide();
            obj.Show();
        }

        private void verifyMenu_Click(object sender, RoutedEventArgs e)
        {
            VerifyDeactivate obj = new VerifyDeactivate();
            this.Hide();
            obj.Show();
        }

        private void cartMenu_Click(object sender, RoutedEventArgs e)
        {
            Cart obj = new Cart();
            this.Hide();
            obj.Show();
        }
      
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }
    }
}
