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
    /// _8_3_2_CustomRoutedEvent.xaml 的交互逻辑
    /// </summary>
    public partial class _8_3_2_CustomRoutedEvent : Window
    {
        public _8_3_2_CustomRoutedEvent()
        {
            InitializeComponent();
        }

        private void ReportTimeHandler(object sender, ReportTimeEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            string timeStr = e.ClickTime.ToLongTimeString();
            string content = string.Format("{0} 到达 {1}", timeStr, element.Name);
            this.listBox.Items.Add(content);

            if (element == this.grid_2)
            {
                e.Handled = true;
            }
        }

    }

    class ReportTimeEventArgs : RoutedEventArgs
    {
        public ReportTimeEventArgs(RoutedEvent routedEvent, object source) : base(routedEvent, source) { }

        public DateTime ClickTime { get; set; }
    }

    class TimeButton : Button
    {
        public static readonly RoutedEvent ReportTimeEvent = EventManager.RegisterRoutedEvent
            ("ReportTime", RoutingStrategy.Bubble, typeof(EventHandler<ReportTimeEventArgs>), typeof(TimeButton));

        public event RoutedEventHandler ReportTime
        {
            add { this.AddHandler(ReportTimeEvent, value); }
            remove { this.RemoveHandler(ReportTimeEvent, value); }
        }

        protected override void OnClick()
        {
            base.OnClick();     //保证button原有功能正常

            ReportTimeEventArgs args = new ReportTimeEventArgs(ReportTimeEvent, this);

            args.ClickTime = DateTime.Now;
            this.RaiseEvent(args);
        }
    }
}
