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

namespace ClientApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(DescriptionText.Text != "")
            {
                string  desc = DescriptionText.Text;

               
                MessageBox.Show($"The description is {desc}");
            }
            else
            {
                MessageBox.Show("description cannot be empty");
                
            }
           
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckBox.IsChecked = this.AssemblyCheckBox.IsChecked = this.LaserCheckBox.IsChecked = this.PlasmaCheckBox.IsChecked =
                this.PurchaseCheckBox.IsChecked = this.LatheCheckBox.IsChecked = this.DrillCheckBox.IsChecked = this.FoldCheckBox.IsChecked =
                this.RollCheckBox.IsChecked = this.SawCheckBox.IsChecked = false;
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += (string)((CheckBox)sender).Content;
        }

       

        private void SupplierText_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassText.Text = this.SupplierText.Text;
        }
    }
}
