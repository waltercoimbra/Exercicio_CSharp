using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex008
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            int inicio;
            int.TryParse(txtInicio.Text, out inicio);
            int fim;
            int.TryParse(txtFim.Text, out fim);

            Random gerador = new Random();
            int num = gerador.Next(inicio, fim + 1);
            lblMsg.Visibility = Visibility.Visible;
            lblMsg.Content = $"Sorteando um número entre {inicio} e {fim}....";
            await Task.Delay(2000);
            lblMsg.Content = $"Sorteei o número {num}";
            
            
           
            
        }
    }
}
