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
    /// Interaction logic for FrmEditarProduto.xaml
    /// </summary>
    public partial class FrmEditarProduto : Window
    {

        private Produto p = new Produto();

        public FrmEditarProduto()
        {
            InitializeComponent();
        }

        private void BuscarProduto(object sender, RoutedEventArgs e)
        {
            p = new Produto
            {
                NomeProduto = TxtNomeProduto.Text
            };

            p = ProdutoDAO.BuscarProdutoPorNome(p);

            if (p != null)
            {
                TxtNomeProduto.Text = p.NomeProduto;
                TxtPrecoProduto.Text = p.PrecoProduto.ToString();

                MessageBox.Show("Produto encontrado!", "Hotel Cachorro");
            }
            else
            {
                MessageBox.Show("Esse produto não existe!", "Hotel Cachorro");
            }
        }

        private void EditarProduto(object sender, RoutedEventArgs e)
        {
            p.NomeProduto = TxtPrecoProduto.Text;
            p.PrecoProduto = Convert.ToDouble(TxtPrecoProduto.Text);

            if (ProdutoDAO.EditarProduto(p))
            {
                MessageBox.Show("Produto alterado com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não é possivel atualizar este produto!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }
    }
}
