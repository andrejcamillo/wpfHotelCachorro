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
    /// Interaction logic for FrmExcluirFuncionario.xaml
    /// </summary>
    public partial class FrmExcluirFuncionario : Window
    {
        public FrmExcluirFuncionario()
        {
            InitializeComponent();
        }

        private void ExcluirFuncionario(object sender, RoutedEventArgs e)
        {

            Funcionario f = new Funcionario()
            {
                Cpf = TxtCpf.Text
            };

            if (FuncionarioDAO.ExcluirFuncionario(f))
            {
                MessageBox.Show("Funcionário:" + f.Nome + " do CPF: " + f.Cpf + " excluído com sucesso!!!", "HotelCachorro",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Cliente não existe!", "HotelCachorro", MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }
    }
}
