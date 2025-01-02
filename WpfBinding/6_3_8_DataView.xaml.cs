using System;
using System.Collections.Generic;
using System.Data;
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
using WpfBinding.Model;

namespace WpfBinding
{
    /// <summary>
    /// 6_3_8_DataView.xaml 的交互逻辑
    /// </summary>
    public partial class _6_3_8_DataView : Window
    {
        public _6_3_8_DataView()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "Tim", 29 };
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 1, "Tom", 28 };
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 2, "Kyle", 27 };
            dt.Rows.Add(dr);
            

            this.listViewStudents.ItemsSource = dt.DefaultView;

        }
    }
}
