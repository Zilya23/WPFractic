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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public static ObservableCollection<User> users { get; set; }
        public Page1()
        {
            InitializeComponent();
        }

        private void auto_click(object sender, RoutedEventArgs e)
        {
            users = new ObservableCollection<User>(DataBaseConnect.connection.User.ToList());
            var z = users.Where(a => a.Name == txt_login.Text && a.Password == txt_password.Password).FirstOrDefault();
            if(z != null)
            {
            NavigationService.Navigate(new Page3());
            }
            else
            {
                MessageBox.Show("Логин или пароль неверный", "error", MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }
    }
}
