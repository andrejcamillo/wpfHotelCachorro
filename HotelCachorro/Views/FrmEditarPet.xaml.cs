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
    /// Interaction logic for FrmEditarPet.xaml
    /// </summary>
    public partial class FrmEditarPet : Window
    {

        private Pet p = new Pet();


        public FrmEditarPet()
        {
            InitializeComponent();
        }

        private void EditarPet(object sender, RoutedEventArgs e)
        {
            int genero = Convert.ToInt32(cboGenero.SelectedValue);

            p.Nome = TxtNomePet.Text;
            p.cliente = ClienteDAO.BuscarClientePorId(TxtCpfCliente.Text);
            p.Genero = GeneroDAO.BuscarGeneroPorId(genero);
            p.Raca = TxtRaca.Text;
            p.Castragem = TxtCastragem.Text;
            p.Pelagem = TxtPelagem.Text;
            p.Idade = Convert.ToInt32(TxtIdade.Text);
            p.Porte = TxtPorte.Text;
            p.Peso = Convert.ToDouble(TxtPeso.Text);



            if (PetDAO.EditarPet(p))
            {
                MessageBox.Show("Pet alterado com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não é possivel atualizar!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }

        private void BuscarPet(object sender, RoutedEventArgs e)
        {
            int genero = Convert.ToInt32(cboGenero.SelectedValue);


            p = new Pet
            {
                cliente = ClienteDAO.BuscarClientePorId(TxtCpfCliente.Text),
                Nome = TxtNomePet.Text
            };

           
            
            if (p.cliente != null)
            {
                p = PetDAO.BuscarPetPorCliente(p);

                if (p != null)
                {

                    TxtNomePet.Text = p.Nome;
                    TxtCpfCliente.Text = p.cliente.Cpf;
                    cboGenero.Text = p.Genero.Nome;
                    TxtRaca.Text = p.Raca;
                    TxtCastragem.Text = p.Castragem;
                    TxtPelagem.Text = p.Pelagem;
                    TxtIdade.Text = p.Idade.ToString();
                    TxtPorte.Text = p.Porte;
                    TxtPeso.Text = p.Peso.ToString();

                }
                else
                {
                    MessageBox.Show("Esse Pet não existe!", "Hotel Cachorro");
                }
            }
            else
            {
                MessageBox.Show("Esse Cliente não existe!", "Hotel Cachorro");
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
