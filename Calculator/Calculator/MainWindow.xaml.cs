using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
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
        # region declaration
        float number;
        float answer;

        #endregion

        # region buttons
        private void button0_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = (Output.Text != "0") ? Output.Text + button0.Content : button0.Content.ToString();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
          Output.Text = (Output.Text != "0") ? Output.Text + button1.Content : button1.Content.ToString();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = (Output.Text != "0") ? Output.Text + button2.Content : button2.Content.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = (Output.Text != "0") ? Output.Text + button3.Content : button3.Content.ToString();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = (Output.Text != "0") ? Output.Text + button4.Content : button4.Content.ToString();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = (Output.Text != "0") ? Output.Text + button5.Content : button5.Content.ToString();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = (Output.Text != "0") ? Output.Text + button6.Content : button6.Content.ToString();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = (Output.Text != "0") ? Output.Text + button7.Content : button7.Content.ToString();  
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = (Output.Text != "0") ? Output.Text + button8.Content : button8.Content.ToString();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = (Output.Text != "0") ? Output.Text + button9.Content : button9.Content.ToString();
        }
        
        private void buttonDOT_Click(object sender, RoutedEventArgs e)
        {
 
        }
        private void buttonEXP_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonDEl_Click(object sender, RoutedEventArgs e)
        {

        }
        private void buttonTIMES_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button15_ADD(object sender, RoutedEventArgs e)
        {

        }
        private void button16_ANS(object sender, RoutedEventArgs e)
        {

        }

        private void button17_AC(object sender, RoutedEventArgs e)
        {

        }
        private void buttonDIV_Click(object sender, RoutedEventArgs e)
        {

        }
        private void buttonMINUS_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button20_EQU(object sender, RoutedEventArgs e)
        {

        }
        #endregion
        private void Diplay_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Output_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {

        }
                    
    }
}
