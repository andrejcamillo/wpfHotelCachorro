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
    /// Interaction logic for frmExcluirCliente.xaml
    /// </summary>
    public partial class frmExcluirCliente : Window
    {
        public frmExcluirCliente()
        {
            InitializeComponent();
        }

        private void ExcluirCliente(object sender, RoutedEventArgs e)
        {

            Cliente c = new Cliente()
            {
                Cpf = TxtCpf.Text
            };

            if (ClienteDAO.ExcluirCliente(c))
            {
                MessageBox.Show("Cliente:" + c.Nome + " do CPF: " + c.Cpf + " excluido com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Cliente não existe!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }

        }
    }
}


