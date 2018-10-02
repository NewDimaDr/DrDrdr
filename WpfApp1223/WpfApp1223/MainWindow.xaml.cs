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
        }

        private void image6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VideoWindow videoWindow = new VideoWindow("1.mp4");
            videoWindow.ShowDialog();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            VideoWindow videoWindow = new VideoWindow("2.mp4");
            videoWindow.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            VideoWindow videoWindow = new VideoWindow("3.mp4");
            videoWindow.ShowDialog();
        }
    }
}
