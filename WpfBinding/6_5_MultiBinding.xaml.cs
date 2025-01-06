using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WpfBinding
{
    /// <summary>
    /// _6_5_MultiBinding.xaml 的交互逻辑
    /// </summary>
    public partial class _6_5_MultiBinding : Window
    {
        public _6_5_MultiBinding()
        {
            InitializeComponent();
            SetMultiBinding();
        }

        private void SetMultiBinding()
        {
            Binding b1 = new Binding("Text") { Source = this.textBox1 };
            Binding b2 = new Binding("Text") { Source = this.textBox2 };
            Binding b3 = new Binding("Text") { Source = this.textBox3 };
            Binding b4 = new Binding("Text") { Source = this.textBox4 };

            MultiBinding mb = new MultiBinding() { Mode = BindingMode.OneWay };
            // 对添加子Binding的顺序是敏感的，顺序决定了汇集到Converter里数据的顺序
            mb.Bindings.Add(b1);
            mb.Bindings.Add(b2);
            mb.Bindings.Add(b3);
            mb.Bindings.Add(b4);
            //MultiBinding的Converter实现的是IMultiValueConverter接口
            mb.Converter = new LogonMultiBindingConverter();

            this.button1.SetBinding(Button.IsEnabledProperty, mb);
        }
    }

    public class LogonMultiBindingConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (!values.Cast<string>().Any(text => string.IsNullOrEmpty(text))
                && values[0].ToString() == values[1].ToString()
                && values[2].ToString() == values[3].ToString())
            {
                return true;
            }
            return false;
        }

        //不会被调用
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
