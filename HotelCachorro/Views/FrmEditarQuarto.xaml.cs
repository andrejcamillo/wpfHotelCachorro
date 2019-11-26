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
    /// Interaction logic for FrmEditarQuarto.xaml
    /// </summary>
    public partial class FrmEditarQuarto : Window
    {

        private Quarto q = new Quarto();

        public FrmEditarQuarto()
        {
            InitializeComponent();
        }

        private void BuscarQuarto(object sender, RoutedEventArgs e)
        {
            q = new Quarto
            {
                NomeQuarto = TxtNomeQuarto.Text
            };

            q = QuartoDAO.BuscarQuartoPorNome(q);

            if (q != null)
            {
                TxtNomeQuarto.Text = q.NomeQuarto;
                txtPrecoQuarto.Text = q.PrecoQuarto.ToString();

                MessageBox.Show("Quarto encontrado!", "Hotel Cachorro");
            }
            else
            {
                MessageBox.Show("Esse quarto não existe!", "Hotel Cachorro");
            }

        }

        private void EditarQuarto(object sender, RoutedEventArgs e)
        {

            q.NomeQuarto = TxtNomeQuarto.Text;
            q.PrecoQuarto = Convert.ToDouble(txtPrecoQuarto.Text);

            if (QuartoDAO.EditarQuarto(q))
            {
                MessageBox.Show("Quarto alterado com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não é possivel atualizar este quarto!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }

        }
    }
}
