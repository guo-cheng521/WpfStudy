using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBinding.Model
{
    class Student : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        /*private string name;
        public string Name
        {
            get { return name; }
            set { name = value;
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }*/

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
