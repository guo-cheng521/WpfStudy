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
    /// _11_4_3_FindControl.xaml 的交互逻辑
    /// </summary>
    public partial class _11_4_3_FindControl : Window
    {
        public _11_4_3_FindControl()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //寻找由ControlTemplate生成的控件
            //对于ControlTemplate对象，访问其目标对象的Template属性就能拿到
            TextBox tb = this.uc.Template.FindName("textBox1",this.uc) as TextBox;
            tb.Text = "Hello WPF";
            StackPanel sp = tb.Parent as StackPanel;
            (sp.Children[1] as TextBox).Text = "Hello ControlTemplate";
            (sp.Children[2] as TextBox).Text = "I can find you!";
        }
    }
}
