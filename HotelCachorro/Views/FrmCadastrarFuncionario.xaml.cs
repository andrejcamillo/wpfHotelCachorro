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
    /// Interaction logic for FrmCadastrarFuncionario.xaml
    /// </summary>
    public partial class FrmCadastrarFuncionario : Window
    {
        public FrmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void CarregarDados(object sender, RoutedEventArgs e)
        {
            cboGenero.ItemsSource = GeneroDAO.ListarProdutos();
            cboGenero.DisplayMemberPath = "Nome";
            cboGenero.SelectedValuePath = "GeneroId";

            cboFuncao.ItemsSource = FuncaoDAO.ListarFuncoes();
            cboFuncao.DisplayMemberPath = "Nome";
            cboFuncao.SelectedValuePath = "FuncaoId";
        }

        private void SalvarFuncionario(object sender, RoutedEventArgs e)
        {
            //int genero = cboGeneros.SelectedIndex;
            int genero = Convert.ToInt32(cboGenero.SelectedValue);
            int funcao = Convert.ToInt32(cboFuncao.SelectedValue);


            Funcionario f = new Funcionario()
          
            {
                Nome = txtNome.Text,
                Cpf = txtCpf.Text,
                Rg = TxtRg.Text,
                DataNascimento = dtpDataNascimento.SelectedDate,
                Genero = GeneroDAO.BuscarGeneroPorId(genero),
                Telefone = TxtTelefone.Text,
                Funcao = FuncaoDAO.BuscarFuncaoPorId(funcao)

            };




            if (FuncionarioDAO.CadastrarFuncionario(f))
            {
                MessageBox.Show("Funcionário cadastrado com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Está pessoa já está cadastrada no sistema", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }
    }
}
