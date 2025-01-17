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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTemplate
{
    /// <summary>
    /// CarDetailView.xaml 的交互逻辑
    /// </summary>
    public partial class CarDetailView : UserControl
    {
        private Car car;
        public Car Car
        {
            get { return car; }
            set
            {
                car = value;
                this.textBlockAutomaker.Text = car.Automaker;
                this.textBlockName.Text = car.Name;
                this.textBlockYear.Text = car.Year;
                this.textBlockTopSpeed.Text = car.TopSpeed;
                string uriStr = $@"/Resources/Images/{car.Name}.jpg";
                this.imagePhote.Source = new BitmapImage(new Uri(uriStr, UriKind.Relative));
            }
        }
        public CarDetailView()
        {
            InitializeComponent();
        }
    }
}
