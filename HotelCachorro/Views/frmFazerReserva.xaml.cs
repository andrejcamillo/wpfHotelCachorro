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
    /// Interaction logic for frmFazerReserva.xaml
    /// </summary>
    public partial class frmFazerReserva : Window
    {
        private List<dynamic> produtosGrid = new List<dynamic>();
        Reserva rest = new Reserva();

        private List<ItemVenda> ivvv = new List<ItemVenda>();
        double total = 0;
        double ppQuarto = 0;

      

        public frmFazerReserva()
        {
            InitializeComponent();
        }

        private void CarregarDados(object sender, RoutedEventArgs e)
        {
            cboQuartos.ItemsSource = QuartoDAO.ListarQuartos();
            cboQuartos.DisplayMemberPath = "NomeQuarto";
            cboQuartos.SelectedValuePath = "IdQuarto";


            cboProdutos.ItemsSource = ProdutoDAO.ListarProdutos();
            cboProdutos.DisplayMemberPath = "NomeProduto";
            cboProdutos.SelectedValuePath = "IdProduto";

            cboServicos.ItemsSource = ServicoDAO.ListarServicos();
            cboServicos.DisplayMemberPath = "NomeServico";
            cboServicos.SelectedValuePath = "IdServico";

            


        }

         



        private void BuscarPet(object sender, RoutedEventArgs e)
        {
           // int buscarPet = Convert.ToInt32(cboPets.SelectedValue);

            Cliente c = new Cliente
            {
                Cpf = TxtCpf.Text
            };

            c = ClienteDAO.BuscarClientePorCPF(c);
            if (c != null)
            {
               
              cboPets.ItemsSource = PetDAO.ListarPetPorCliente(c.IdCliente);
              cboPets.DisplayMemberPath = "Nome";
              cboPets.SelectedValuePath = "IdPet";
             
            }
            else
            {
                MessageBox.Show("Esse cliente não possui pets!", "Hotel Cachorro");
            }

        }

        private void AddProduto(object sender, RoutedEventArgs e)
        {
            if (!TxTQuantidadeProduto.Text.Equals(""))
            {
                int idProduto =
                    Convert.ToInt32(cboProdutos.SelectedValue);
                Produto p = ProdutoDAO.BuscarProdutoPorId(idProduto);

                ItemVenda iv = new ItemVenda();

                dynamic d = new
                {
                    Nome = p.NomeProduto,
                    Categoria = "Produto",
                    Quantidade = TxTQuantidadeProduto.Text,
                    Preco = p.PrecoProduto.ToString("C2"),
                    Subtotal = (p.PrecoProduto * Convert.ToInt32(TxTQuantidadeProduto.Text)).ToString("C2")
                };

                iv.Nome = p.NomeProduto;
                iv.Quantidade = Convert.ToInt32(TxTQuantidadeProduto.Text);
                iv.Preco = p.PrecoProduto;
                iv.Produto = ProdutoDAO.BuscarProdutoPorId(idProduto);
                iv.Servico = null;
                ivvv.Add(iv);

                Console.WriteLine(ivvv);

                produtosGrid.Add(d);
                dgReserva.ItemsSource = produtosGrid;
                dgReserva.Items.Refresh();
                

                total += p.PrecoProduto * Convert.ToInt32(TxTQuantidadeProduto.Text);
                labelTotal.Content = "Total: " + total.ToString("C2");
                //labelPrecoFinal.Content = "Preço final: " + (total+ppQuarto).ToString("C2");

            }
            else
            {
                MessageBox.Show("Por favor, prencha o campo" +
                    "da quantidade");
            }
        }

        private void FazerReserva(object sender, RoutedEventArgs e)
        {

            //int genero = cboGeneros.SelectedIndex;
            int produto = Convert.ToInt32(cboProdutos.SelectedValue);
            int quarto = Convert.ToInt32(cboQuartos.SelectedValue);
            int pet = Convert.ToInt32(cboPets.SelectedValue);


            //pegar datas para obter quantidade dias
            DateTime dataEntrada = (DateTime)DtpDataEntrada.SelectedDate;
            DateTime dataSaida = (DateTime)DtpDataSaida.SelectedDate;
            TimeSpan Dias = dataSaida.Subtract(dataEntrada);
            int totalDias = Convert.ToInt32(Dias.Days);
            Console.WriteLine(totalDias);

            //calcular preco quarto +
            Quarto qota = QuartoDAO.ValorQuarto(QuartoDAO.BuscarQuartoPorId(quarto));
            double precoestadia = totalDias * qota.PrecoQuarto;


            total += precoestadia;


            Reserva res = new Reserva()
            {
                Pet = PetDAO.BuscarPetPorId(pet),
                DataEntrada = (DateTime)DtpDataEntrada.SelectedDate,
                DataSaida = (DateTime)DtpDataSaida.SelectedDate,
                Quarto = QuartoDAO.BuscarQuartoPorId(quarto),
                ValorTotal = total,
                ItensVendidos = ivvv
            };

            Console.WriteLine(res);



            if (ReservaDAO.CadastrarReserva(res))
            {
                MessageBox.Show("Reserva efetuada com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Reserva não pode ser efetuada!!!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }

            

        }

        private void AddServico(object sender, RoutedEventArgs e)
        {
            if (!TxtQtdServico.Text.Equals(""))
            {
                int idServico = Convert.ToInt32(cboServicos.SelectedValue);
                Servico s = ServicoDAO.BuscarServicoPorId(idServico);

                ItemVenda iv = new ItemVenda();

                dynamic d = new
                {
                    Nome = s.NomeServico,
                    Categoria = "Servico",
                    Quantidade = TxtQtdServico.Text,
                    Preco = s.PrecoServico.ToString("C2"),
                    Subtotal = (s.PrecoServico * Convert.ToInt32(TxtQtdServico.Text)).ToString("C2")
                };


                iv.Nome = s.NomeServico;
                iv.Quantidade = Convert.ToInt32(TxtQtdServico.Text);
                iv.Preco = s.PrecoServico;
                iv.Produto = null;
                iv.Servico = ServicoDAO.BuscarServicoPorId(idServico);
                ivvv.Add(iv);

                produtosGrid.Add(d);    
                dgReserva.ItemsSource = produtosGrid;
                dgReserva.Items.Refresh();

                total += s.PrecoServico * Convert.ToInt32(TxtQtdServico.Text);
                labelTotal.Content = "Total: " + total.ToString("C2");
                //labelPrecoFinal.Content = "Preço final: " + (total + ppQuarto).ToString("C2");
            }
            else
            {
                MessageBox.Show("Por favor, prencha o campo" +
                    "da quantidade");
            }
        }

        private void MostrarReservas(object sender, RoutedEventArgs e)
        {
            ExibirReserva er = new ExibirReserva();
            er.ShowDialog();
        }

        private void ExibirPrecoQuarto(object sender, RoutedEventArgs e)
        {
            //string precoQuarto = cboQuartos.DisplayMemberPath = "PrecoQuarto";
            //Console.WriteLine(precoQuarto);
            //labelPrecoQuarto.Content = "Preco: " + precoQuarto.ToString();
            int quarto = Convert.ToInt32(cboQuartos.SelectedValue);
            Quarto qota = QuartoDAO.ValorQuarto(QuartoDAO.BuscarQuartoPorId(quarto));
            double precoQuarto = qota.PrecoQuarto;

            ppQuarto = precoQuarto;

            labelPrecoQuarto.Content = "Preço Quarto: " + precoQuarto.ToString("C2");
        }

      
    }
}
