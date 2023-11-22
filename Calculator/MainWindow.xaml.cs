using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        private void inCone_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        private void txtoutCome_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        private void txtwant_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int inCome = int.Parse(txtinCome.Text);
            int outCome = int.Parse(txtoutCome.Text);
            int want = int.Parse(txtwant.Text);
            double ans = (want/(inCome-outCome));
            txthowDay.Text = ans.ToString();
        }

     
    }
}
