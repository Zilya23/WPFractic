using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public static ObservableCollection<Film> films { get; set; }
        public static ObservableCollection<Serias> seriass { get; set; }
        public Page3()
        {
            InitializeComponent();
            films = new ObservableCollection<Film>(DataBaseConnect.connection.Film.ToList());
            seriass = new ObservableCollection<Serias>(DataBaseConnect.connection.Serias.ToList());

            var f = new Film();
            var s = new Serias();
            this.DataContext = this;
        }
    }
}
