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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HeightClearBtn_Click(object sender, RoutedEventArgs e)
        {
            
            HeightBox.Background = Brushes.Blue;
        }

        private void weightbtn_Click(object sender, RoutedEventArgs e)
        {
            weightbox.Background = Brushes.Brown ;
        }

        private void count_Click(object sender, RoutedEventArgs e)
        {
            double w = double.Parse(HeightBox.Text)/100;
            double h = double.Parse(weightbox.Text) ;
            double bmi = h / (w * w);

            result.Text = bmi.ToString();
        }

        private void weightbtn_Click_1(object sender, RoutedEventArgs e)
        {
            HeightBox.Background = Brushes.Cyan;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double w = double.Parse(HeightBox.Text) / 100;
            double h = double.Parse(weightbox.Text);
            double bmi = h / (w * w);
            HeightBox.Text = zz.Value.ToString();
            weightbox.Text = aa.Value.ToString();
            result.Text = bmi.ToString();
        }
    }
}
