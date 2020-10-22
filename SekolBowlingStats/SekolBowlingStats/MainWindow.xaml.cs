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

namespace SekolBowlingStats
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double tempHoldingVariable = 0;
        public double tempHoldingVariable2 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void usersubmitbutton_Click(object sender, RoutedEventArgs e)
        {
            findSeries();
            findAverage();
            displayHandicap();
            findHighGame();
        }

        private void cleardatabutton_Click(object sender, RoutedEventArgs e)
        {
            Game1UserInput.Text = "";
            Game2UserInput.Text = "";
            Game3UserInput.Text = "";

            seriestextbox.Text = "0";
            averagetextbox.Text = "0";
            handicaptextbox.Text = "0";
            highgametextbox.Text = "";

            maleradiobutton.IsChecked = false;
            femaleradiobutton.IsChecked = false;

            tempHoldingVariable = 0;
            tempHoldingVariable2 = 0;
        }

        private void exitprogrambutton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        
        public void findSeries()
        {
            tempHoldingVariable = Convert.ToInt32(Game1UserInput.Text) + Convert.ToInt32(Game2UserInput.Text) + Convert.ToInt32(Game3UserInput.Text);
            seriestextbox.Text = Convert.ToString(tempHoldingVariable);
            tempHoldingVariable = 0;
        }

        public void findAverage()
        {
            tempHoldingVariable = Convert.ToInt32(Game1UserInput.Text) + Convert.ToInt32(Game2UserInput.Text) + Convert.ToInt32(Game3UserInput.Text);
            tempHoldingVariable2 = tempHoldingVariable / 3;
            averagetextbox.Text = Convert.ToString(tempHoldingVariable2);
            tempHoldingVariable = 0;
            tempHoldingVariable2 = 0;
        }

        public void displayHandicap()
        {
            tempHoldingVariable = Convert.ToInt32(Game1UserInput.Text) + Convert.ToInt32(Game2UserInput.Text) + Convert.ToInt32(Game3UserInput.Text);
            tempHoldingVariable2 = tempHoldingVariable/3;
            tempHoldingVariable = (200 - tempHoldingVariable2) * .8;
            handicaptextbox.Text = Convert.ToString(tempHoldingVariable);
            tempHoldingVariable = 0;
            tempHoldingVariable2 = 0;
        }

        public void findHighGame()
        {
            if (Convert.ToInt32(Game1UserInput.Text) > Convert.ToInt32(Game2UserInput.Text) && Convert.ToInt32(Game1UserInput.Text) > Convert.ToInt32(Game3UserInput.Text))
            {
                highgametextbox.Text = "Game 1";
            }
            else if (Convert.ToInt32(Game2UserInput.Text) > Convert.ToInt32(Game1UserInput.Text) && Convert.ToInt32(Game2UserInput.Text) > Convert.ToInt32(Game3UserInput.Text))
            {
                highgametextbox.Text = "Game 2";
            }
            else if (Convert.ToInt32(Game3UserInput.Text) > Convert.ToInt32(Game1UserInput.Text) && Convert.ToInt32(Game3UserInput.Text) > Convert.ToInt32(Game2UserInput.Text))
            {
                highgametextbox.Text = "Game 3";
            }
            else if (Convert.ToInt32(Game1UserInput.Text) == Convert.ToInt32(Game2UserInput.Text) && Convert.ToInt32(Game1UserInput.Text) == Convert.ToInt32(Game3UserInput.Text))
            {
                highgametextbox.Text = "TIE!";
            }
        }
    }
}
