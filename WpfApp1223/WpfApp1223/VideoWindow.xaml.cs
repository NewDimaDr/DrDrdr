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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for VideoWindow.xaml
    /// </summary>
    public partial class VideoWindow : Window
    {
        public VideoWindow()
        {
            InitializeComponent();
        }
        public VideoWindow(string path)
        {
            InitializeComponent();
            movieLoader.Source = new Uri(path, UriKind.RelativeOrAbsolute);
        }

        private void movieLoader_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
