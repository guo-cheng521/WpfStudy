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
    /// _10_2_DynamicResource.xaml 的交互逻辑
    /// </summary>
    public partial class _10_2_DynamicResource : Window
    {
        public _10_2_DynamicResource()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["res1"] = new TextBlock() { Text = "天涯共此时" };
            this.Resources["res2"] = new TextBlock() { Text = "天涯共此时" };
        }
    }
}
