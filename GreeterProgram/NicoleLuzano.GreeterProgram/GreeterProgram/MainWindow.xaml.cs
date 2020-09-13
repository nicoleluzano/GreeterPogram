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

namespace GreeterProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> colors = new List<string>()
            {
                "Black",
                "White",
                "Blue",
                "Red",
                "Green",
                "Vilote",
                "Orange",
                "Yellow",
                "Pink",
            };

            cboColor.ItemsSource = colors;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            string fullName = txtFisrtName.Text + " " + txtLastName.Text;

            MessageBox.Show("Hello " + fullName + " Good afternoon! Your favorite color is " + cboColor.SelectedItem);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
