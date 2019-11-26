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
    /// Interaction logic for FrmExcluirServico.xaml
    /// </summary>
    public partial class FrmExcluirServico : Window
    {
        public FrmExcluirServico()
        {
            InitializeComponent();
        }

        private void ExcluirServico(object sender, RoutedEventArgs e)
        {
            Servico s = new Servico()
            {
                NomeServico = TxtNomeServico.Text
            };

            s = ServicoDAO.BuscarServicoPorNome(s);

            if (s != null)
            {

                ServicoDAO.ExcluirServico(s);
                MessageBox.Show("Servico: " + s.NomeServico + " excluido com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Serviço não existe!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }
    }
}
