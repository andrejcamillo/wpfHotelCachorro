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
    /// Interaction logic for FrmDesmarcarReserva.xaml
    /// </summary>
    public partial class FrmDesmarcarReserva : Window
    {
        public FrmDesmarcarReserva()
        {
            InitializeComponent();
        }

        private void CarregarInfo(object sender, RoutedEventArgs e)
        {
            dgaExibirReserva.ItemsSource = ReservaDAO.ListarReservas();
        }

        private void DesmarcarReserva(object sender, RoutedEventArgs e)
        {
           Reserva r = new Reserva
            {
               IdReserva = Convert.ToInt32(txtIdReserva.Text)
            };

            r = ReservaDAO.BuscarReservaPorId(r.IdReserva);

            Console.WriteLine(r);

            if (r != null)
            {
                ItensDAO.RemoverVendaPorId(r.IdReserva);
                ReservaDAO.ExcluirReserva(r);
                MessageBox.Show("Reserva excluida com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Reserva não existe!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }
    }
}
