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
    /// Interaction logic for FrmPrincipal.xaml
    /// </summary>
    public partial class FrmPrincipal : Window
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

      

        private void CadastrarCliente(object sender, RoutedEventArgs e)
        {
            frmCadastrarCliente f = new frmCadastrarCliente();
            f.ShowDialog();
        }

        private void acaoSair(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AdicionarPet(object sender, RoutedEventArgs e)
        {
            frmAddPet faPet = new frmAddPet();
            faPet.ShowDialog();
        }

        private void BuscarCliente(object sender, RoutedEventArgs e)
        {
            FrmBuscarCliente bc = new FrmBuscarCliente();
            bc.ShowDialog();
        }

        private void ListarClientes(object sender, RoutedEventArgs e)
        {
            frmListarClientes lc = new frmListarClientes();
            lc.ShowDialog();
        }

        private void ExcluirCliente(object sender, RoutedEventArgs e)
        {
            frmExcluirCliente ec = new frmExcluirCliente();
            ec.ShowDialog();
        }

        private void EditarClientes(object sender, RoutedEventArgs e)
        {
            frmEditarCliente fec = new frmEditarCliente();
            fec.ShowDialog();
        }

    

        private void FazerReserva(object sender, RoutedEventArgs e)
        {
            frmFazerReserva fr = new frmFazerReserva();
            fr.ShowDialog();
        }

        private void ExibirQuartos(object sender, RoutedEventArgs e)
        {
            frmExibirQuartos eq = new frmExibirQuartos();
            eq.ShowDialog();
        }

        private void AddPet(object sender, RoutedEventArgs e)
        {
            frmAddPet addPet = new frmAddPet();
            addPet.ShowDialog();
        }

        private void ExcluirPet(object sender, RoutedEventArgs e)
        {
            FrmExcluirPet excluirPet = new FrmExcluirPet();
            excluirPet.ShowDialog();
        }

        
        private void ListarPets(object sender, RoutedEventArgs e)
        {
            FrmExibirPets exibirPet = new FrmExibirPets();
            exibirPet.ShowDialog();
        }

        private void AddQuarto(object sender, RoutedEventArgs e)
        {
            FrmCadastrarQuarto cq = new FrmCadastrarQuarto();
            cq.ShowDialog();
        }

        private void ExcluirQuarto(object sender, RoutedEventArgs e)
        {
            FrmExcluirQuarto eq = new FrmExcluirQuarto();
            eq.ShowDialog();
        }

        private void ListarQuartos(object sender, RoutedEventArgs e)
        {
            frmExibirQuartos eeq = new frmExibirQuartos();
            eeq.ShowDialog();
        }

        private void EditarQuartos(object sender, RoutedEventArgs e)
        {
            FrmEditarQuarto ediq = new FrmEditarQuarto();
            ediq.ShowDialog();
        }

        private void CadastrarFuncionario(object sender, RoutedEventArgs e)
        {
            FrmCadastrarFuncionario cf = new FrmCadastrarFuncionario();
            cf.ShowDialog();
        }

        private void ExcluirFuncionario(object sender, RoutedEventArgs e)
        {
            FrmExcluirFuncionario ef = new FrmExcluirFuncionario();
            ef.ShowDialog();
        }

        private void BuscarFuncionario(object sender, RoutedEventArgs e)
        {
            FrmBuscarFuncionario bf = new FrmBuscarFuncionario();
            bf.ShowDialog();
        }

        private void ListarFuncionario(object sender, RoutedEventArgs e)
        {
            FrmListarFuncionario flf = new FrmListarFuncionario();
            flf.ShowDialog();
        }

        private void AlterarFuncionario(object sender, RoutedEventArgs e)
        {
            FrmEditarFuncionario fef = new FrmEditarFuncionario();
            fef.ShowDialog();
        }

        private void EditarPet(object sender, RoutedEventArgs e)
        {
            FrmEditarPet fep = new FrmEditarPet();
            fep.ShowDialog();
        }

        private void AddProdutos(object sender, RoutedEventArgs e)
        {
            FrmCadastrarProduto fac = new FrmCadastrarProduto();
            fac.ShowDialog();
        }

        private void ExcluirProdutos(object sender, RoutedEventArgs e)
        {
            FrmExcluirProduto fec = new FrmExcluirProduto();
            fec.ShowDialog();
        }

        private void ListarProdutos(object sender, RoutedEventArgs e)
        {
            FrmListarProdutos flp = new FrmListarProdutos();
            flp.ShowDialog();
        }

        private void EditarProdutos(object sender, RoutedEventArgs e)
        {
            FrmEditarProduto fup = new FrmEditarProduto();
            fup.ShowDialog();
        }

        

        private void CadastrarServico(object sender, RoutedEventArgs e)
        {
            FrmCadastrarServico fcs = new FrmCadastrarServico();
            fcs.ShowDialog();
        }

        private void ExcluirServico(object sender, RoutedEventArgs e)
        {
            FrmExcluirServico fec = new FrmExcluirServico();
            fec.ShowDialog();
        }

        private void ListarServico(object sender, RoutedEventArgs e)
        {
            FrmListarServico fls = new FrmListarServico();
            fls.ShowDialog();
        }

        private void AlterarServico(object sender, RoutedEventArgs e)
        {
            FrmEditarServico fess = new FrmEditarServico();
            fess.ShowDialog();
        }

        private void DesmarcarReserva(object sender, RoutedEventArgs e)
        {
            FrmDesmarcarReserva fdesr = new FrmDesmarcarReserva();
            fdesr.ShowDialog();
        }

        private void ListarReservas(object sender, RoutedEventArgs e)
        {
            ExibirReserva errc = new ExibirReserva();
            errc.ShowDialog();
        }

        private void AlterarReserva(object sender, RoutedEventArgs e)
        {
            FrmAlterarReserva fffc = new FrmAlterarReserva();
            fffc.ShowDialog();
        }
    }
}
