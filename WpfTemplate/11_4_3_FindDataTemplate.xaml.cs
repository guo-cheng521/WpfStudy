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

namespace WpfTemplate
{
    /// <summary>
    /// _11_4_3_FindDataTemplate.xaml 的交互逻辑
    /// </summary>
    public partial class _11_4_3_FindDataTemplate : Window
    {
        public _11_4_3_FindDataTemplate()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBlock tb = this.cp.ContentTemplate.FindName("textBlockName", this.cp) as TextBlock;
            MessageBox.Show(tb.Text);
        }
    }
}
