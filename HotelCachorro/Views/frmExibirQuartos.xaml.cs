using HotelCachorro.DAL;
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

namespace HotelCachorro.Views
{
    /// <summary>
    /// Interaction logic for frmExibirQuartos.xaml
    /// </summary>
    public partial class frmExibirQuartos : Window
    {
        public frmExibirQuartos()
        {
            InitializeComponent();
        }

        private void MostrarQuartos(object sender, RoutedEventArgs e)
        {
            datagridQuartos.ItemsSource = QuartoDAO.ListarQuartos();
        }
    }
}
