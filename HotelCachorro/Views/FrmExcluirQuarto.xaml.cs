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
    /// Interaction logic for FrmExcluirQuarto.xaml
    /// </summary>
    public partial class FrmExcluirQuarto : Window
    {
        public FrmExcluirQuarto()
        {
            InitializeComponent();
        }

        public void ExcluirQuarto(object sender, RoutedEventArgs e)
        {
            Quarto q = new Quarto()
            {
                NomeQuarto = TxtNomeQuarto.Text
            };

            q = QuartoDAO.BuscarQuartoPorNome(q);

            if (q != null)
            {

                QuartoDAO.ExcluirQuarto(q);
                MessageBox.Show("Quarto: " + q.NomeQuarto +  " excluido com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Quarto não existe!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }
    }
}
