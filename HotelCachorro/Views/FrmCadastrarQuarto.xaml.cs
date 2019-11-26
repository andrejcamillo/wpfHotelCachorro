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
    /// Interaction logic for FrmCadastrarQuarto.xaml
    /// </summary>
    public partial class FrmCadastrarQuarto : Window
    {
        public FrmCadastrarQuarto()
        {
            InitializeComponent();
        }

        private void SalvarQuarto(object sender, RoutedEventArgs e)
        {
            Quarto q = new Quarto() {
                NomeQuarto = txtNomeQuarto.Text,
                PrecoQuarto = Convert.ToDouble(txtPrecoDiaria.Text)
            };

            if (QuartoDAO.CadastrarQuarto(q))
            {
                MessageBox.Show("Quarto cadastrado com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Este quarto já existe ou preço tem que ser positivo", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }
    }
}
