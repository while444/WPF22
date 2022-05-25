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
using WpfApp20.DataBase;

namespace WpfApp20.Fragments.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page_list.xaml
    /// </summary>
    public partial class Page_list : Page
    {
        public Page_list()
        {
            InitializeComponent();
            refreshItems();
        }

        private void refreshItems()
        {
            var user = DBHelper.DBHelper.GetContext().UserData;
            DataGrid.ItemsSource = user.ToList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
