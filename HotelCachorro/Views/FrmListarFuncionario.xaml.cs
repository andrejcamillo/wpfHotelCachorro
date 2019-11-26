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
    /// Interaction logic for FrmListarFuncionario.xaml
    /// </summary>
    public partial class FrmListarFuncionario : Window
    {
        public FrmListarFuncionario()
        {
            InitializeComponent();
        }

        private void CarregarDados(object sender, RoutedEventArgs e)
        {
            dtGridDados.ItemsSource = FuncionarioDAO.ListarFuncionarios();
        }
    }
}
