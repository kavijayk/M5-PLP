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

namespace EasyHousingSolutionPL
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

       
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            SupportPage sup = new SupportPage();
            
            sup.Show();
        }

        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            HomeLoans hom = new HomeLoans();
            
            hom.Show();
        }

        private void Hyperlink_Click_2(object sender, RoutedEventArgs e)
        {
            Login up = new Login();
          
            up.Show();
            
                
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //HomePage hp = new HomePage();
            //hp.Close();
            Login bs = new Login();
            
            bs.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registration obj = new Registration();
            
            obj.Show();
        }
    }
}
