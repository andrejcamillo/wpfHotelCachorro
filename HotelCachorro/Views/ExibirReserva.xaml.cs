using HotelCachorro.DAL;
using HotelCachorro.Model;
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
    /// Interaction logic for ExibirReserva.xaml
    /// </summary>
    public partial class ExibirReserva : Window
    {
        public ExibirReserva()
        {
            InitializeComponent();
        }

        private void LoadDados(object sender, RoutedEventArgs e)
        {
            
            dgaExibirReserva.ItemsSource = ReservaDAO.ListarReservas();
        }
        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {            
            var reserva = (Reserva)((DataGridRow)sender).Item;
            dgaCarregarItens.ItemsSource = null;
            dgaCarregarItens.Items.Refresh();
            dgaCarregarItens.ItemsSource = ItensDAO.ProdutosPorClienteXX(reserva.IdReserva);

            Console.WriteLine(reserva);
            dgaMostrarQuarto.ItemsSource = null;
            dgaMostrarQuarto.Items.Refresh();
            dgaMostrarQuarto.ItemsSource = QuartoDAO.BuscarQuarto(reserva.Quarto);

        }
        private void CarregarItens(object sender, RoutedEventArgs e)
        {
           // var andreTransformers = true;
            //dgaExibirReserva

            //int index = e.C
            ////int valor = Convert.ToInt32(dgaExibirReserva.SelectedValue);

            //dgaCarregarItens.ItemsSource = 
            //    ItensDAO.ProdutosPorClienteXX(dgaExibirReserva.se);
        }
    }
}
