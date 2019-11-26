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
    /// Interaction logic for FrmAlterarReserva.xaml
    /// </summary>
    public partial class FrmAlterarReserva : Window
    {
        double total = 0;
        private Reserva reserva = new Reserva();
        private List<ItemVenda> ivvv = new List<ItemVenda>();
    

        public FrmAlterarReserva()
        {
            InitializeComponent();
        }

        private void CarregarReservas(object sender, RoutedEventArgs e)
        {
            dgaExibirReserva.ItemsSource = ReservaDAO.ListarReservas();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            //var reserva = (Reserva)((DataGridRow)sender).Item;
            reserva = (Reserva)((DataGridRow)sender).Item;

            //carregar cliente
            reserva.Pet = PetDAO.BuscarPetPorClienteXX(reserva.Pet);
            TxtCliente.Text = reserva.Pet.cliente.Cpf;


            //carregar pet
            cboPets.ItemsSource = PetDAO.ListarPetPorCliente(reserva.Pet.cliente.IdCliente);
            cboPets.DisplayMemberPath = "Nome";
            cboPets.SelectedValuePath = "IdPet";
            cboPets.Text = reserva.Pet.Nome;


            //carregar quarto
            cboQuartos.Text = reserva.Quarto.NomeQuarto;


            //carregar datas
            DtpDataEntrada.SelectedDate = reserva.DataEntrada;
            DtpDataSaida.SelectedDate = reserva.DataSaida;


            //carregar datagrid com os os itens da reserva
            dgItensReserva.ItemsSource = ItensDAO.ProdutosPorClienteXX(reserva.IdReserva);


            //carregar lista do grid para lista da tela alterar
            ivvv = reserva.ItensVendidos;

            //soma os valores ja existentes na lista e joga para o total
            foreach (var money in ivvv)
            {
                total += money.Preco*money.Quantidade;
            }


            Console.WriteLine(reserva);
            Console.WriteLine(ivvv);

        }

       

        private void DadosCarregar(object sender, RoutedEventArgs e)
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

        private void AddProduto(object sender, RoutedEventArgs e)
        {
            if (!TxTQuantidadeProduto.Text.Equals(""))
            {
                int idProduto =
                    Convert.ToInt32(cboProdutos.SelectedValue);
                Produto p = ProdutoDAO.BuscarProdutoPorId(idProduto);

                ItemVenda iv = new ItemVenda()
                {
                   Nome = p.NomeProduto,
                   Quantidade = Convert.ToInt32(TxTQuantidadeProduto.Text),
                   Preco = p.PrecoProduto,
                   Produto = ProdutoDAO.BuscarProdutoPorId(idProduto),
                   Servico = null
                };

                ivvv.Add(iv);

                dgItensReserva.ItemsSource = ivvv;
                dgItensReserva.Items.Refresh();

            
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

        private void AddServico(object sender, RoutedEventArgs e)
        {
            if (!TxtQtdServico.Text.Equals(""))
            {
                int idServico = Convert.ToInt32(cboServicos.SelectedValue);
                Servico s = ServicoDAO.BuscarServicoPorId(idServico);

                ItemVenda iv = new ItemVenda()
                {
                    Nome = s.NomeServico,
                    Quantidade = Convert.ToInt32(TxtQtdServico.Text),
                    Preco = s.PrecoServico,
                    Servico = ServicoDAO.BuscarServicoPorId(idServico),
                    Produto = null
                };

                ivvv.Add(iv);

                dgItensReserva.ItemsSource = ivvv;
                dgItensReserva.Items.Refresh();


                total += s.PrecoServico * Convert.ToInt32(TxtQtdServico.Text);
                labelTotal.Content = "Total: " + total.ToString("C2");
                //labelPrecoFinal.Content = "Preço final: " + (total+ppQuarto).ToString("C2");

            }
            else
            {
                MessageBox.Show("Por favor, prencha o campo da quantidade");
            }
        }

        private void AddQuarto(object sender, RoutedEventArgs e)
        {
            int quarto = Convert.ToInt32(cboQuartos.SelectedValue);
            Quarto qota = QuartoDAO.ValorQuarto(QuartoDAO.BuscarQuartoPorId(quarto));
            double precoQuarto = qota.PrecoQuarto;

            labelPrecoQuarto.Content = "Preço Quarto: " + precoQuarto.ToString("C2");
        }

        private void AlterarReserva(object sender, RoutedEventArgs e)
        {
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
            reserva.ValorTotal = total;

            reserva.Pet = PetDAO.BuscarPetPorId(pet);
            reserva.DataEntrada = (DateTime)DtpDataEntrada.SelectedDate;
            reserva.DataSaida = (DateTime)DtpDataSaida.SelectedDate;
            reserva.Quarto = QuartoDAO.BuscarQuartoPorId(quarto);

            if (ReservaDAO.AlterarReserva(reserva))
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

        private void RemoverItem(object sender, RoutedEventArgs e)
        {

            
            Console.WriteLine(total);

            if (ivvv.Any())
            {
                var lastItem = ivvv.Last();
                total -= lastItem.Preco * lastItem.Quantidade;
                ivvv.RemoveAt(ivvv.Count - 1);
            }

            labelTotal.Content = "Total: " + total.ToString("C2");

            dgItensReserva.ItemsSource = ivvv;
            dgItensReserva.Items.Refresh();
        }
    }
}
