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
    /// _10_3_ResourcesResx.xaml 的交互逻辑
    /// </summary>
    public partial class _10_3_ResourcesResx : Window
    {
        public _10_3_ResourcesResx()
        {
            InitializeComponent();
            this.textBlockPassword.Text = Properties.Resources.Password;
        }
    }
}
