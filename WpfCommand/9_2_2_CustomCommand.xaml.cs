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

namespace WpfCommand
{
    /// <summary>
    /// _9_2_2_CustomCommand.xaml 的交互逻辑
    /// </summary>
    public partial class _9_2_2_CustomCommand : Window
    {
        public _9_2_2_CustomCommand()
        {
            InitializeComponent();

            //声明命令并使命令源和目标与之关联
            ClearCommand clearCmd = new ClearCommand();
            this.ctrlClear.Command = clearCmd;
            this.ctrlClear.CommandTarget = this.miniView;
        }
    }

    //自定义命令
    public class ClearCommand : ICommand
    {
        //当命令可执行状态发生改变时，应当被激活
        public event EventHandler? CanExecuteChanged;

        //用于判断命令是否可以执行
        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        // 命令执行，带有与业务相关的Clear逻辑
        public void Execute(object? parameter)
        {
            IView? view = parameter as IView;
            if (view != null)
            {
                view.Clear();
            }
        }
    }

    //自定义命令源
    public class MyCommandSource : UserControl, ICommandSource
    {
        //继承自ICommandSource的三个属性
        public ICommand Command { get; set; }

        public object CommandParameter { get; set; }

        public IInputElement CommandTarget { get; set; }

        //在组件被单及时连带执行命令
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            //在命令目标上执行命令，或称让命令作用于命令目标
            if (this.CommandTarget != null)
            {
                this.Command.Execute(this.CommandTarget);
            }
        }
    }
}
