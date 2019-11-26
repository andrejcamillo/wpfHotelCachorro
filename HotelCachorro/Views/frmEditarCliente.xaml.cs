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
    /// Interaction logic for frmEditarCliente.xaml
    /// </summary>
    public partial class frmEditarCliente : Window
    {

        private Cliente c = new Cliente();
        public frmEditarCliente()
        {
            InitializeComponent();
        }



        private void EditarCliente(object sender, RoutedEventArgs e)
        {
            int genero = Convert.ToInt32(cboGeneros.SelectedValue);

            c.Nome = txtNome.Text;
            c.Sobrenome = TxTSobrenome.Text;
            c.Cpf = TxtCpf.Text;
            c.Rg = txtRg.Text;
            c.DataNascimento = (DateTime)dtpDataNascimento.SelectedDate;
            c.Genero = GeneroDAO.BuscarGeneroPorId(genero);
            c.Telefone = txtTelefone.Text;

            if (ClienteDAO.EditarCliente(c))
            {
                MessageBox.Show("Cliente alterado com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não é possivel atualizar!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }

        }



        private void ProcurarCliente(object sender, RoutedEventArgs e)
        {
            int genero = Convert.ToInt32(cboGeneros.SelectedValue);


            c = new Cliente
            {
                Cpf = TxtCpf.Text
            };

            c = ClienteDAO.BuscarClientePorCPF(c);
            if (c != null)
            {
                txtNome.Text = c.Nome;
                TxTSobrenome.Text = c.Sobrenome;
                TxtCpf.Text = c.Cpf;
                txtRg.Text = c.Rg;

                //txtDataNascimento.Text = Convert.ToString(c.DataNascimento);
                dtpDataNascimento.SelectedDate = c.DataNascimento;
                txtTelefone.Text = c.Telefone;
                cboGeneros.Text = c.Genero.Nome;


                /*
                txtCriadoEm.Text = p.CriadoEm.ToString();
                */
            }
            else
            {
                MessageBox.Show("Esse cliente não existe!",
                    "Hotel Cachorro");
            }
        }

        private void CaaregarXX(object sender, RoutedEventArgs e)
        {
            cboGeneros.ItemsSource = GeneroDAO.ListarProdutos();
            cboGeneros.DisplayMemberPath = "Nome";
            cboGeneros.SelectedValuePath = "GeneroId";
        }
    }


    }

            /*
            if (DAL.ClienteDAO.EditarCliente(c))
            {
                MessageBox.Show("Cliente cadastrado com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Este cliente já existe!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }*/








