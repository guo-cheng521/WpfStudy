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

namespace WpfBinding
{
    /// <summary>
    /// _6_3_3_ListBinding.xaml 的交互逻辑
    /// </summary>
    public partial class _6_3_3_ListBinding : Window
    {
        class City
        {
            public string Name { get; set; }
        }
        class Province
        {
            public string Name { get; set; }
            public List<City> CityList { get; set; }

        }
        class Country
        {
            public string Name { get; set; }
            public List<Province> ProvinceList { get; set; }
        }
        public _6_3_3_ListBinding()
        {
            InitializeComponent();
            //将其默认元素作为Path
            //List<String> stringList = new List<String>() { "Tim", "Tom", "Blog"};
            //this.textBox1.SetBinding(TextBox.TextProperty, new Binding("/") { Source = stringList });
            //this.textBox2.SetBinding(TextBox.TextProperty, new Binding("/Length") { Source = stringList, Mode= BindingMode.OneWay });
            //this.textBox3.SetBinding(TextBox.TextProperty, new Binding("/[2]") { Source = stringList, Mode = BindingMode.OneWay });

            City XingTai = new City() { Name = "邢台" };
            City Sjz = new City() { Name = "石家庄" };
            Province province = new Province() { Name = "河北", CityList = new List<City> { XingTai, Sjz } };
            Country China = new Country() { Name ="中国", ProvinceList = new List<Province> { province } };
            List<Country> countryList = new List<Country>() { China };
            this.textBox1.SetBinding(TextBox.TextProperty, new Binding("/Name") { Source = countryList });
            this.textBox2.SetBinding(TextBox.TextProperty, new Binding("/ProvinceList[0].Name") { Source = countryList });
            this.textBox3.SetBinding(TextBox.TextProperty, new Binding("/ProvinceList.[0].CityList[0].Name") { Source = countryList });
        }
    }
}
