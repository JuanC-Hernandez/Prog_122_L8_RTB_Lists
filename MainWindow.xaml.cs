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

namespace Prog_122_L8_RTB_Lists
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ArrayDemonstration();
        }//MainWindow
        public void ArrayDemonstration()
        {
            string[] students = new string[4];
            students[0] = "Hafsa";
            students[1] = "Kira";
            students[2] = "Juan";
            students[3] = "Matt";

            //rtbDisplay.Text = students[0];
            for (int i = 0; i<students.Length; i++)
            {
                rtbDisplay.Text += $"{students[i]}\n";
            }
        }
        private void btnDisplayText_Click(object sender, RoutedEventArgs e)
        {
            AccidentInfo();

        }// btnDisplayText_Click    

        public void AccidentInfo()
        {
            string driver = txtDriverName.Text;
            string address = txtAddress.Text;
            string make = txtMake.Text; 
            string model = txtModel.Text;
            string year = txtYear.Text;
            string info = rtbAccidentInfo.Text;

            //string formatedInformation = $"{make}{model}{year}{info}{driver}{address}";

            rtbDisplay.Text = $"Driver Name: {driver}\n";
            rtbDisplay.Text += $"Address: {address}\n";
            rtbDisplay.Text += $"Make: {make}\n";
            rtbDisplay.Text += $"Model: {model}\n";
            rtbDisplay.Text += $"Year: {year}\n";
            rtbDisplay.Text += $"Info: {info}\n";
        }//Accident Info


    }//class
}//namespace
