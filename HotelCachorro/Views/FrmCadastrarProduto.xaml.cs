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
    /// Interaction logic for FrmCadastrarProduto.xaml
    /// </summary>
    public partial class FrmCadastrarProduto : Window
    {
        public FrmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void CadastrarProduto(object sender, RoutedEventArgs e)
        {
            Produto p = new Produto()
            {
                NomeProduto = txtNomeProduto.Text,
                PrecoProduto = Convert.ToDouble(txtPrecoProduto.Text)
            };

            if (ProdutoDAO.CadastrarProduto(p))
            {
                MessageBox.Show("Produto cadastrado com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Este produto já existe ou preço tem que ser positivo", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }
    }
}
