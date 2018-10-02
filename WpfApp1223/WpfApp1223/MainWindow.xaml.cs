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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MB mB = new MB();
            mB.ShowDialog();
        }

        private void image6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Remove((sender as Button));
            VideoWindow videoWindow = new VideoWindow("1.mp4");
            videoWindow.ShowDialog();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Remove((sender as Button));
            VideoWindow videoWindow = new VideoWindow("2.mp4");
            videoWindow.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Remove((sender as Button));
            VideoWindow videoWindow = new VideoWindow("3.mp4");
            videoWindow.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Remove((sender as Button));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Remove((sender as Button));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Remove((sender as Button));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Remove((sender as Button));
        }
    }
}
