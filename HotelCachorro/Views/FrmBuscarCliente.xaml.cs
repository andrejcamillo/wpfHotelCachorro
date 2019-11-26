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
    /// Interaction logic for FrmBuscarCliente.xaml
    /// </summary>
    public partial class FrmBuscarCliente : Window
    {
        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        private void BuscarCliente(object sender, RoutedEventArgs e)
        {
            if (!txtCpf.Text.Equals(""))
            {
                Cliente c = new Cliente
                {
                    Cpf = txtCpf.Text
                };

                c = ClienteDAO.Lmmm(c);
                if (c != null)
                {
                    //txtNome.Text = c.Nome;
                    //txtCpf.Text = c.Cpf;

                    
                    MessageBox.Show("Cliente encontrado!!!\n" + 
                        "\nId: " + c.IdCliente +
                        "\nNome: " + c.Nome +
                        "\nCPF: " + c.Cpf +
                        "\nRG: " + c.Rg +
                        "\nData Nascimento: " + c.DataNascimento +
                        "\nGênero: " + c.Genero.Nome +
                        "\nTelefone: " + c.Telefone 


                        , "Hotel Cachorro");
                }
                else
                {
                    MessageBox.Show("Esse cliente não existe!",
                        "Hotel Cachorro");
                }
            }
        }
    }
}
