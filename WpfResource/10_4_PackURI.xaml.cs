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

namespace WpfResource
{
    /// <summary>
    /// _10_4_PackURI.xaml 的交互逻辑
    /// </summary>
    public partial class _10_4_PackURI : Window
    {
        public _10_4_PackURI()
        {
            InitializeComponent();

            //Uri imgUri = new Uri(@"Resources/image.jpg", UriKind.Relative);
            Uri imgUri = new Uri(@"pack://application:,,,/Resources/image.jpg", UriKind.Absolute);
            this.ImageBg.Source = new BitmapImage(imgUri);
        }
    }
}
