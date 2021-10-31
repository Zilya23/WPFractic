using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public static ObservableCollection<Film> films { get; set; }
        public static ObservableCollection<Film_Operator> svazy {get; set;}

        public static ObservableCollection<Operator> operators { get; set; }

        public static IEnumerable<Film2> result { get; set; }
        public static IEnumerable<Operator2> result2 { get; set; }
        public Page4(Film n)
        {
            InitializeComponent();
            tb_Name.Text = n.Title;
            img_Poster.Source = new BitmapImage(new Uri(n.Poster, UriKind.RelativeOrAbsolute));
            operators = new ObservableCollection<Operator>(DataBaseConnect.connection.Operator.ToList());
            svazy = new ObservableCollection<Film_Operator>(DataBaseConnect.connection.Film_Operator.ToList());
            films = new ObservableCollection<Film>(DataBaseConnect.connection.Film.ToList());

            result = from f in films 
                    join t in svazy on f.ID_Film equals t.ID_Film
                     where n.ID_Film == f.ID_Film
                    select new Film2 { idOperator = t.ID_Operator, idFilm = f.ID_Film };

            result2 = from o in operators
                     join t in result on o.ID_Operator equals t.idOperator
                     select new Operator2 { idOperator2 = o.ID_Operator, nameOper = o.Name };
            foreach (var i in result2)
                tb_Operator.Text += i.nameOper;
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
    public class Film2
    {
        public int idFilm { get; set; }
        public int idOperator { get; set; }
        
    }

    public class Operator2
    {
        public string nameOper { get; set; }
        public int idOperator2 { get; set; }

    }
}
