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
using WpfBinding.Model;

namespace WpfBinding
{
    /// <summary>
    /// _6_3_7_ItemsSource.xaml 的交互逻辑
    /// </summary>
    public partial class _6_3_7_ItemsSource : Window
    {
        public _6_3_7_ItemsSource()
        {
            InitializeComponent();
            List<Student> stuList = new List<Student>()
            {
                new Student() {Id = 0, Name = "Tim", Age=29},
                new Student() {Id = 1, Name = "Tom", Age=28},
                new Student() {Id = 2, Name = "Kyle", Age=27},
                new Student() {Id = 3, Name = "Tony", Age=26},
                new Student() {Id = 4, Name = "Vina", Age=25},
            };

            this.listBoxStudents.ItemsSource = stuList;
            //以DisplayMemberPath的值为Path创建Binding，Binding的目标是ListBoxItem的内容插件
            //this.listBoxStudents.DisplayMemberPath = "Name";

            Binding binding = new Binding("SelectedItem.Id") { Source = this.listBoxStudents };
            this.textBoxId.SetBinding(TextBox.TextProperty, binding);
        }
    }
}
