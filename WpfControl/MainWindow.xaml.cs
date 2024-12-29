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

namespace WpfControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Employee> empList;
        public MainWindow()
        {
            InitializeComponent();
            empList = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Time", Age = 30},
                new Employee(){Id = 2, Name = "Tom", Age = 26},
                new Employee(){Id = 3, Name = "Guo", Age = 25},
                new Employee(){Id = 4, Name = "Yan", Age = 26},
                new Employee(){Id = 5, Name = "Owen", Age = 30}
            };
            this.listBoxEmplyee.ItemsSource = empList;
            this.listBoxEmplyee.DisplayMemberPath = "Name";
            this.listBoxEmplyee.SelectedValuePath = "Id";
        }

        /// <summary>
        /// VisualTreeHelper:帮助在可视化元素构成的树上进行导航的辅助类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVictor_Click(object sender, RoutedEventArgs e)
        {
            Button? btn = sender as Button;
            DependencyObject level1 = VisualTreeHelper.GetParent(btn);
            DependencyObject level2 = VisualTreeHelper.GetParent(level1);
            DependencyObject level3 = VisualTreeHelper.GetParent(level2);
            MessageBox.Show(level3.GetType().ToString());

        }
    }
}