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
    /// Interaction logic for FrmCadastrarServico.xaml
    /// </summary>
    public partial class FrmCadastrarServico : Window
    {
        public FrmCadastrarServico()
        {
            InitializeComponent();
        }

        private void CadastrarServico(object sender, RoutedEventArgs e)
        {
            Servico s = new Servico()
            {
                NomeServico = txtNomeServico.Text,
                PrecoServico = Convert.ToDouble(txtPrecoServico.Text)
            };

            if (ServicoDAO.CadastrarServico(s))
            {
                MessageBox.Show("Serviço cadastrado com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Este serviço já existe ou preço tem que ser positivo", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }
    }
}
