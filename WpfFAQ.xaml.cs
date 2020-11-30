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

namespace Pokemon_IV_Breeding_Probability_Calculator
{
    /// <summary>
    /// Interaction logic for WpfFAQ.xaml
    /// </summary>
    public partial class WpfFAQ : Window
    {
        public WpfFAQ()
        {
            InitializeComponent();

        }




        private void Mnucalculator_Click(object sender, RoutedEventArgs e)
        {
        }

        private void MnuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
