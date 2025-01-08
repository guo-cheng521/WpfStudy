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
    /// _7_3_AttachProperty.xaml 的交互逻辑
    /// </summary>
    public partial class _7_3_AttachProperty : Window
    {
        public _7_3_AttachProperty()
        {
            InitializeComponent();

            //InitializeLayout();

            //附加属性本质是依赖属性，也可以使用Binding依赖在其它对象的数据上
            this.rect.SetBinding(Canvas.LeftProperty, new Binding("Value") { Source = this.sliderX });
            this.rect.SetBinding(Canvas.TopProperty, new Binding("Value") { Source = this.sliderY });
        }

        private void InitializeLayout()
        {
            Grid grid = new Grid() { ShowGridLines = true };

            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());

            Button button = new Button() { Content = "OK"};
            Grid.SetColumn(button, 1);
            Grid.SetRow(button, 1);
            grid.Children.Add(button);
            this.Content = grid;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Human human = new Human();
            School.SetGrade(human, 6);
            int grade = School.GetGrade(human);
            MessageBox.Show(grade.ToString());
        }
    }
}
