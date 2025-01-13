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

namespace WpfCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeCommand();
        }
        private RoutedCommand clearCmd = new RoutedCommand("Clear", typeof(MainWindow));
        private void InitializeCommand()
        {
            //把命令赋值给命令源，并指定快捷键
            this.button1.Command = this.clearCmd;
            this.clearCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));

            //指定命令目标
            this.button1.CommandTarget = this.textBoxA;

            //创建命令关联
            CommandBinding cb = new CommandBinding();
            cb.Command = this.clearCmd;     //只关注与clearCmd相关的事件
            cb.CanExecute += new CanExecuteRoutedEventHandler(cb_CanExecute);
            cb.Executed += new ExecutedRoutedEventHandler(cb_Executed);

            //把命令关联安置在外围控件上
            this.stackPanel.CommandBindings.Add(cb);
        }

        private void cb_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.textBoxA.Clear();
            e.Handled = true;
        }

        private void cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxA.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
            e.Handled = true;   //避免继续向上传递
        }
    }
}