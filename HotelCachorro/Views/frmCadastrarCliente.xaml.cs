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
    /// Interaction logic for frmCadastrarPessoa.xaml
    /// </summary>
    public partial class frmCadastrarCliente : Window
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void CarregarInfo(object sender, RoutedEventArgs e)
        {
            cboGeneros.ItemsSource = GeneroDAO.ListarProdutos();
            cboGeneros.DisplayMemberPath = "Nome";
            cboGeneros.SelectedValuePath = "GeneroId";
         
        }

        private void btnCadastrarPessoa(object sender, RoutedEventArgs e)
        {

           
            //int genero = cboGeneros.SelectedIndex;
            int genero = Convert.ToInt32(cboGeneros.SelectedValue);
            

            Cliente c = new Cliente()
            {
                Nome = txtNome.Text,
                Sobrenome = TxTSobrenome.Text,
                Cpf = TxtCpf.Text,
                Rg = txtRg.Text,
                DataNascimento = DtpkDtNascumento.SelectedDate,
                Genero = GeneroDAO.BuscarGeneroPorId(genero),
                Telefone = txtTelefone.Text,
               
               
            };


           

            if (DAL.ClienteDAO.CadastrarCliente(c))
            {
                MessageBox.Show("Cliente cadastrado com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Este cliente já existe ou não pode ser cadastrado", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }

        }

        private void btnBuscarCliente(object sender, RoutedEventArgs e)
        {
            if (!TxtCpf.Text.Equals(""))
            {
                Cliente c = new Cliente
                {
                    Cpf = TxtCpf.Text
                };

                c = ClienteDAO.BuscarClientePorCPF(c);
                if (c != null)
                {
                    txtNome.Text = c.Nome;
                    TxtCpf.Text = c.Cpf;

                    /*
                    txtCriadoEm.Text = p.CriadoEm.ToString();
                    */
                }
                else
                {
                    MessageBox.Show("Esse cliente não existe!",
                        "WPF Vendas");
                }
            }
        }

    }
}
