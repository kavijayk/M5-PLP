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
    /// Interaction logic for SupportPage.xaml
    /// </summary>
    public partial class SupportPage : Window
    {
        public SupportPage()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            HomeLoans loans = new HomeLoans();
            loans.Show();
        }

        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            Login man = new Login();
            man.Show();
        }

        private void Hyperlink_Click_2(object sender, RoutedEventArgs e)
        {
            HomePage fromSup = new HomePage();
            fromSup.Show();
        }
    }
}
