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

namespace WpfRoutedEvent
{
    /// <summary>
    /// _8_3_1_RoutedEvent.xaml 的交互逻辑
    /// </summary>
    public partial class _8_3_1_RoutedEvent : Window
    {
        public _8_3_1_RoutedEvent()
        {
            InitializeComponent();

            //把想监听的事件与事件的处理器关联起来
            this.gridRoot.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.ButtonClicked));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">sender是gridRoot而不是Button</param>
        /// <param name="e"></param>
        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as FrameworkElement).Name);
        }
    }
}
