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
    /// Interaction logic for FrmExcluirProduto.xaml
    /// </summary>
    public partial class FrmExcluirProduto : Window
    {
        public FrmExcluirProduto()
        {
            InitializeComponent();
        }

        private void ExcluirProduto(object sender, RoutedEventArgs e)
        {
          Produto p = new Produto
          {
              NomeProduto = TxtNome.Text
          };

            p = ProdutoDAO.BuscarProdutoPorNome(p);

            if (p != null)
            {

                ProdutoDAO.ExcluirProduto(p);
                MessageBox.Show("Produto: " + p.NomeProduto + " excluido com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Produto não existe!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }
    }
}
