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

namespace WpfTemplate
{
    /// <summary>
    /// _11_2_DataTemplate.xaml 的交互逻辑
    /// </summary>
    public partial class _11_2_DataTemplate : Window
    {
        public _11_2_DataTemplate()
        {
            InitializeComponent();
            InitialCarList();
        }
        private void InitialCarList()
        {
            List<Car> carList = new List<Car>()
            {
                new Car() {Automaker="Lamborghini",Name="Diablo",Year="1990",TopSpeed="340"},
                new Car() {Automaker="Lamborghini",Name="Murcielago",Year="2001",TopSpeed="353"},
                new Car() {Automaker="Lamborghini",Name="Gallardo",Year="2003",TopSpeed="325"}
            };
            this.listBoxCars.ItemsSource = carList;
        }
    }
}
