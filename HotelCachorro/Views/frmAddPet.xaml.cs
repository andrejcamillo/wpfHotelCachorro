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
    /// Interaction logic for frmAddPet.xaml
    /// </summary>
    public partial class frmAddPet : Window
    {
        public frmAddPet()
        {
            InitializeComponent();
        }



        private void SalvarPet(object sender, RoutedEventArgs e)
        {

            int genero = Convert.ToInt32(cboGenero.SelectedValue);
           

            Pet p = new Pet()
            {
                Nome = TxtNomePet.Text,
                cliente = ClienteDAO.BuscarClientePorId(TxtCpfCliente.Text),
                Genero = GeneroDAO.BuscarGeneroPorId(genero), 
                Raca =  TxtRaca.Text,
                Castragem = TxtCastragem.Text,
                Pelagem =  TxtPelagem.Text,
                Idade =  Convert.ToInt32(TxtIdade.Text),
                Porte =  TxtPorte.Text,
                Peso = Convert.ToDouble(TxtPeso.Text)
            };

            if(p.cliente != null)
            {
                if (PetDAO.CadastrarPet(p))
                {
                    MessageBox.Show("Pet cadastrado com sucesso!!!", "HotelCachorro",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Este Pet já existe!", "HotelCachorro", MessageBoxButton.OK,
                       MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Este Cliente não existe!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }

        }

     

        private void CarregarDados(object sender, RoutedEventArgs e)
        {
            cboGenero.ItemsSource = GeneroDAO.ListarProdutos();
            cboGenero.DisplayMemberPath = "Nome";
            cboGenero.SelectedValuePath = "GeneroId";
        }

      
    }
}
