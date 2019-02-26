﻿using System;
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
using EasyHousingSolutionEntity;
using EHSException;
using EasyHousingSolutionBLL;

namespace EasyHousingSolutionPL
{
    /// <summary>
    /// Interaction logic for ViewPropertyByOwner.xaml
    /// </summary>
    public partial class ViewPropertyByOwner : Window
    {
        PropertyBL propertyBL = new PropertyBL();

        public ViewPropertyByOwner()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string SellerName = txtOwnerName.Text;
                List<Property> viewProperty = propertyBL.GetAllPropertyByOwnerBL(SellerName);
                if (viewProperty != null && viewProperty.Count > 0)
                {
                    dgViewProperties.DataContext = viewProperty;
                }
                else
                {
                    MessageBox.Show("No record found");
                }

            }
            catch (EasyHousingSolutionException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow fromsearch = new MainWindow();
            this.Hide();
            fromsearch.Show();
        }
    }
}
