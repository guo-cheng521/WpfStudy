using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfProperty
{
    internal class Student : DependencyObject
    {
        //CLR属性包装器
        //依赖对象准备了用于暴漏数据的Binding Path，现在依赖对象已经具备了扮演数据源和数据目标双重角色的能力
        //尽管没有实现INotifyPropertyChanged接口，当属性值发生改变时，与之关联的Binding对象依然可以得到通知，
        //依赖属性默认带有这样的功能。
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register("Name", typeof(string), typeof(Student));

        public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding)
        {
            return BindingOperations.SetBinding(this, dp, binding);
        }
    }
}
