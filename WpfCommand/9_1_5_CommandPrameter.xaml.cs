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
    /// _9_1_5_CommandPrameter.xaml 的交互逻辑
    /// </summary>
    public partial class _9_1_5_CommandPrameter : Window
    {
        public _9_1_5_CommandPrameter()
        {
            InitializeComponent();
        }

        private void New_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.nameTextBox.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }

        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string name = this.nameTextBox.Text;
            if (e.Parameter.ToString() == "Teacher")
            {
                this.listBoxNewItems.Items.Add($"New Teacher: {name}, 学而不厌、诲人不倦");
            }
            if (e.Parameter.ToString() == "Student")
            {
                this.listBoxNewItems.Items.Add($"New Student: {name}, 好好学习、天天向上");
            }
        }
    }
}
