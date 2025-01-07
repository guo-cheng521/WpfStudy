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

namespace WpfProperty
{
    /// <summary>
    /// _7_2_2_DependencyProperty.xaml 的交互逻辑
    /// </summary>
    public partial class _7_2_2_DependencyProperty : Window
    {
        Student stu;
        public _7_2_2_DependencyProperty()
        {
            InitializeComponent();
            stu = new Student();
            Binding binding = new Binding("Text") { Source = textBox1 };
            stu.SetBinding(Student.NameProperty, binding);
            textBox2.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = stu});
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Student stu = new Student();
            //stu.SetValue(Student.NameProperty, this.textBox1.Text);
            //textBox2.Text = (string)stu.GetValue(Student.NameProperty);
            MessageBox.Show(stu.GetValue(Student.NameProperty).ToString());
        }
    }
}
