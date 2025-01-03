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

namespace WpfBinding
{
    /// <summary>
    /// _6_3_11_ObjectDataProvider.xaml 的交互逻辑
    /// </summary>
    public partial class _6_3_11_ObjectDataProvider : Window
    {
        public _6_3_11_ObjectDataProvider()
        {
            InitializeComponent();
            this.SetBinding();
        }

        private void SetBinding()
        {
            ObjectDataProvider odp = new ObjectDataProvider();
            odp.ObjectInstance = new Calculator();
            odp.MethodName = "Add";
            odp.MethodParameters.Add("0");
            odp.MethodParameters.Add("0");

            //以ObjectDataProvider对象为Source创建Binding
            Binding bindingToArg1 = new Binding("MethodParameters[0]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            Binding bindingToArg2 = new Binding("MethodParameters[1]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            Binding bindingToResult = new Binding(".") { Source = odp };

            this.textBoxArg1.SetBinding(TextBox.TextProperty, bindingToArg1);
            this.textBoxArg2.SetBinding(TextBox.TextProperty, bindingToArg2);
            this.textBoxResult.SetBinding(TextBox.TextProperty, bindingToResult);
        }

        class Calculator()
        {
            public string Add(string arg1, string arg2)
            {
                double a;
                double b;
                double c;
                if (double.TryParse(arg1, out a) && double.TryParse(arg2, out b))
                {
                    c = a + b;
                    return c.ToString();
                }
                return "Input Error!";
            }
        }
    }
}
