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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace BMI_Calculator
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double height;
                double weight;

                if (double.TryParse(Height.Text.Trim(), out height) && double.TryParse(Weight.Text.Trim(), out weight))
                {
                    double bmi = weight / (height * height);
                    double bmifixed = Math.Round(bmi, 2);
                    MessageBox.Show($"Your BMI: {bmifixed.ToString()}", "Calculate BMI", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show($"Enter correct information !", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while calculating BMI: " + ex.Message);
            }
        }

    }
}
