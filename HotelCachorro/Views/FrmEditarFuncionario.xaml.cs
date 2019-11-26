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
    /// Interaction logic for FrmEditarFuncionario.xaml
    /// </summary>
    public partial class FrmEditarFuncionario : Window
    {

        Funcionario f = new Funcionario();
        public FrmEditarFuncionario()
        {
            InitializeComponent();
        }

        private void BuscarFuncionario(object sender, RoutedEventArgs e)
        {
            int genero = Convert.ToInt32(cboGenero.SelectedValue);
            int funcao = Convert.ToInt32(cboFuncao.SelectedValue);


            f = new Funcionario
            {
                Cpf = txtCpf.Text
            };

            Console.WriteLine(f);

            f = FuncionarioDAO.BuscarFuncionarioPorCPF(f);

            Console.WriteLine(f);

            if (f != null)
            {
                txtNome.Text = f.Nome;
                txtCpf.Text = f.Cpf;
                TxtRg.Text = f.Rg;
                dtpDataNascimento.SelectedDate = f.DataNascimento;
                TxtTelefone.Text = f.Telefone;
                cboGenero.Text = f.Genero.Nome;
                cboFuncao.Text = f.Funcao.Nome;
              
            }
            else
            {
                MessageBox.Show("Esse funcionário não existe!", "Hotel Cachorro");
            }
        }

        private void EditarFuncionario(object sender, RoutedEventArgs e)
        {
            int genero = Convert.ToInt32(cboGenero.SelectedValue);
            int funcao = Convert.ToInt32(cboFuncao.SelectedValue);

            f.Nome = txtNome.Text;
            f.Cpf = txtCpf.Text;
            f.Rg = TxtRg.Text;
            f.DataNascimento = (DateTime)dtpDataNascimento.SelectedDate;
            f.Genero = GeneroDAO.BuscarGeneroPorId(genero);
            f.Funcao = FuncaoDAO.BuscarFuncaoPorId(funcao);
            f.Telefone = TxtTelefone.Text;

            if (FuncionarioDAO.EditarFuncionario(f))
            {
                MessageBox.Show("Funcionário alterado com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não é possivel atualizar!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }

        private void CarregarBoxes(object sender, RoutedEventArgs e)
        {
            cboGenero.ItemsSource = GeneroDAO.ListarProdutos();
            cboGenero.DisplayMemberPath = "Nome";
            cboGenero.SelectedValuePath = "GeneroId";

            cboFuncao.ItemsSource = FuncaoDAO.ListarFuncoes();
            cboFuncao.DisplayMemberPath = "Nome";
            cboFuncao.SelectedValuePath = "FuncaoId";
        }
    }
}
