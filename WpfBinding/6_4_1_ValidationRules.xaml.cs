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
    /// _6_4_1_ValidationRules.xaml 的交互逻辑
    /// </summary>
    public partial class _6_4_1_ValidationRules : Window
    {
        public _6_4_1_ValidationRules()
        {
            InitializeComponent();

            Binding binding = new Binding("Value") { Source = this.slider1};

            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            RangeValidationRule rvr = new RangeValidationRule();
            rvr.ValidatesOnTargetUpdated = true;
            binding.ValidationRules.Add(rvr);
            binding.NotifyOnValidationError = true;
            this.textBox1.SetBinding(TextBox.TextProperty, binding);

            this.textBox1.AddHandler(Validation.ErrorEvent, new RoutedEventHandler(this.ValidationError));
        }

        private void ValidationError(object sender, RoutedEventArgs e)
        {
            if (Validation.GetErrors(this.textBox1).Count > 0)
            {
                this.textBox1.ToolTip = Validation.GetErrors(this.textBox1)[0].ErrorContent.ToString();
            }
        }
    }
}
