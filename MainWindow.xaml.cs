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

namespace Pokemon_IV_Breeding_Probability_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] strgender = { "Ignore", "12,5%", "25%", "50%", "75%", "87,5%" } ;
        private string[] strability = {"Ignore", "20%", "40%", "60%", "80%" };
        private string[] strshiny = { "Ignore", "1/4096 Base Chance", "3/4096 Shiny Charm", "6/4096 Matsuda Method", "8/4096 Shiny Charm + Matsuda Method" };
        private double[] gender = { 1, 0.125, 0.25, 0.50, 0.75, 0.875 };
        private double[] ability = { 1, 0.20, 0.40, 0.60, 0.80};
        private double[] shiny = { 1, 0.000244140625, 0.000732421875, 0.00146484375, 0.001953125};
        double modGender;
        double modAbility;
        double modShiny;
        double totalmodifier;
        double totalnumberofeggs = 1;


        public MainWindow()
        {
            InitializeComponent();
            gpbResults.Visibility = Visibility.Hidden;
            this.WindowState = WindowState.Maximized;
            for (int i = 0; i < strgender.Length; i++)
            // listBox in lus vullen met ListBoxItems
            // beter dan rechtstreeks met strings te vullen
            {
                ListBoxItem newItem = new ListBoxItem();
                newItem.Content = strgender[i];
                cboGender.Items.Add(newItem);
            }
            cboGender.SelectedIndex = 0;
            for (int i = 0; i < strability.Length; i++)
            // listBox in lus vullen met ListBoxItems
            // beter dan rechtstreeks met strings te vullen
            {
                ListBoxItem newItem = new ListBoxItem();
                newItem.Content = strability[i];
                cboAbility.Items.Add(newItem);
            }
            cboAbility.SelectedIndex = 0;
            for (int i = 0; i < strshiny.Length; i++)
            // listBox in lus vullen met ListBoxItems
            // beter dan rechtstreeks met strings te vullen
            {
                ListBoxItem newItem = new ListBoxItem();
                newItem.Content = strshiny[i];
                cboShiny.Items.Add(newItem);
            }
            cboShiny.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            gpbResults.Visibility = Visibility.Visible;
            modGender =  gender[cboGender.SelectedIndex];
            modAbility = ability[cboAbility.SelectedIndex];
            modShiny = shiny[cboShiny.SelectedIndex];
            totalmodifier = modGender * modAbility * modShiny;
            txtPreresults.Text = "Breeding parents " + "x/x/x/x/x/x " + "and " + "x/x/x/x/x/x ";
            if (totalmodifier < 1)
            {
                txtmodifier.Text = Convert.ToString(totalmodifier * 100) + "%";
                txtPreresults.Text += ", with a " + Convert.ToString(totalmodifier * 100) + " % modfifier," + Environment.NewLine;
            }
            else
            {
                txtmodifier.Text = "No modifier";
                txtPreresults.Text += Environment.NewLine;
            }
            txtPreresults.Text += "will produce " + "x/x/x/x " + "Pokemon " + "Placeholder" + "%" + " of the time or " + "1 out of every " + totalnumberofeggs.ToString() + " Eggs!";
            txtExpectedIVs.Text = "Expected number of perfect IVs: " + "Placeholder value" + "%";
    }

        private void btnreset_Click(object sender, RoutedEventArgs e)
        {
            gpbResults.Visibility = Visibility.Hidden;
            txtPreresults.Clear();
            cboGender.SelectedIndex = 0;
            cboAbility.SelectedIndex = 0;
            cboShiny.SelectedIndex = 0;
        }
    }
}
