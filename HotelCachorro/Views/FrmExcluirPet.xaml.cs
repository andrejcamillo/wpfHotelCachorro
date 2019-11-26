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
    /// Interaction logic for FrmExcluirPet.xaml
    /// </summary>
    public partial class FrmExcluirPet : Window
    {
        public FrmExcluirPet()
        {
            InitializeComponent();
        }

        private void ExibirPets(object sender, RoutedEventArgs e)
        {
            FrmExibirPets ep = new FrmExibirPets();
            ep.ShowDialog();
        }

        private void ExcluirPet(object sender, RoutedEventArgs e)
        {

            /*
            Pet p = new Pet()
            {
                IdPet = Convert.ToInt32(TxtIdPet.Text)
            };
            */

            Pet p = new Pet()
            {
                cliente = ClienteDAO.BuscarClientePorId(txtCpfCliente.Text),
                Nome = txtNomePet.Text
            };


            if(p.cliente != null)
            {
                if (PetDAO.BuscarPetPorNome(p) != null)
                {
                    PetDAO.ExcluirPet(p);
                }
                else
                {
                    MessageBox.Show("Pet não existe!", "HotelCachorro", MessageBoxButton.OK,
                       MessageBoxImage.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Cliente não existe!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
           
            /*
            if (PetDAO.ExcluirPet(p))
            {
                MessageBox.Show("Pet:" + p.Nome + " excluido com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Cliente não existe!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }*/
        }
    }
}
