using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfBinding.Model;

namespace WpfBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student stu;
        public MainWindow()
        {
            InitializeComponent();
            stu = new Student();

            //准备Binding
            Binding binding = new Binding();
            binding.Source = stu;
            binding.Path = new PropertyPath("Name");

            //Binding连接数据源与Binding目标
            //目标、目标哪个属性：DependencyProperty 依赖属性
            BindingOperations.SetBinding(this.textBoxName, TextBox.TextProperty, binding);

            //this.textBoxName.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = stu = new Student() });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stu.Name += "Name";
        }
    }
}