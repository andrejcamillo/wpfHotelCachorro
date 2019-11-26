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
    /// Interaction logic for FrmBuscarFuncionario.xaml
    /// </summary>
    public partial class FrmBuscarFuncionario : Window
    {
        public FrmBuscarFuncionario()
        {
            InitializeComponent();
        }

        private void BuscarFuncionario(object sender, RoutedEventArgs e)
        {
            if (!txtCpf.Text.Equals(""))
            {
                Funcionario f = new Funcionario
                {
                    Cpf = txtCpf.Text
                };

                f = FuncionarioDAO.Lmmm(f);
                if (f != null)
                {
                    //txtNome.Text = c.Nome;
                    //txtCpf.Text = c.Cpf;


                    MessageBox.Show("Funcionario encontrado!!!\n" +
                        "\nMatricula: " + f.Matricula +
                        "\nNome: " + f.Nome +
                        "\nCPF: " + f.Cpf +
                        "\nRG: " + f.Rg +
                        "\nData Nascimento: " + f.DataNascimento +
                        "\nGênero: " + f.Genero.Nome +
                        "\nFunção: " + f.Funcao.Nome +
                        "\nTelefone: " + f.Telefone


                        , "Hotel Cachorro");
                }
                else
                {
                    MessageBox.Show("Esse funcionário não existe!",
                        "Hotel Cachorro");
                }
            }
        }
    }
    }
