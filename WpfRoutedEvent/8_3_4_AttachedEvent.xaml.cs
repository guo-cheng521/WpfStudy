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
    /// _8_3_4_AttachedEvent.xaml 的交互逻辑
    /// </summary>
    public partial class _8_3_4_AttachedEvent : Window
    {
        public _8_3_4_AttachedEvent()
        {
            InitializeComponent();
            //this.gridMain.AddHandler(Student.NameChangedEvent, new RoutedEventHandler(StudentNameChangedHandler));
            Student.AddNameChangedHandler(this.gridMain, new RoutedEventHandler(this.StudentNameChangedHandler));
        }

        private void StudentNameChangedHandler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as Student).Id.ToString());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student() { Id = 101, Name = "Tim" };
            stu.Name = "Tom";

            RoutedEventArgs arg = new RoutedEventArgs(Student.NameChangedEvent, stu);
            this.button1.RaiseEvent(arg);
        }
    }

    public class Student
    {
        public static readonly RoutedEvent NameChangedEvent = EventManager.RegisterRoutedEvent
            ("NameChanged",RoutingStrategy.Bubble,typeof(RoutedEventHandler),typeof(Student));
        public int Id { get; set; }
        public string Name { get; set; }

        //为界面元素添加路由事件侦听
        public static void AddNameChangedHandler(DependencyObject d, RoutedEventHandler h)
        {
            UIElement e = d as UIElement;
            if (e != null)
            {
                e.AddHandler(Student.NameChangedEvent, h);
            }
        }

        public static void RemoveNameChangedHandler(DependencyObject d, RoutedEventHandler h)
        {
            UIElement e = d as UIElement;
            if (e != null)
            {
                e.RemoveHandler(Student.NameChangedEvent, h);
            }
        }
    }
}
