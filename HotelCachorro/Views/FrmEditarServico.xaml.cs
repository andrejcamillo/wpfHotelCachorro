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
    /// Interaction logic for FrmEditarServico.xaml
    /// </summary>
    public partial class FrmEditarServico : Window
    {

        private Servico s = new Servico();

        public FrmEditarServico()
        {
            InitializeComponent();
        }

        private void BuscarServico(object sender, RoutedEventArgs e)
        {
            s = new Servico
            {
                NomeServico= TxtNomeServico.Text
            };

            s = ServicoDAO.BuscarServicoPorNome(s);

            if (s != null)
            {
                TxtNomeServico.Text = s.NomeServico;
                TxtPrecoServico.Text = s.PrecoServico.ToString();

                MessageBox.Show("Serviço encontrado!", "Hotel Cachorro");
            }
            else
            {
                MessageBox.Show("Esse serviço não existe!", "Hotel Cachorro");
            }
        }

        private void EditarServico(object sender, RoutedEventArgs e)
        {
            s.NomeServico = TxtPrecoServico.Text;
            s.PrecoServico = Convert.ToDouble(TxtPrecoServico.Text);

            if (ServicoDAO.EditarServico(s))
            {
                MessageBox.Show("Serviço alterado com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não é possivel atualizar este serviço!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }
    }
}
