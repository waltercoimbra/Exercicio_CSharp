﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex006
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            int nasc;
            int.TryParse(txtNasc.Text, out nasc);
            int ano = DateTime.Now.Year;
            int idade = ano - nasc;

            panResult.Visibility = Visibility.Visible;
            lbl1.Content = $"Atualmente enstamo em {ano:D}";
            lbl2.Content = $"Se você nasceu em {nasc:D} vai ter {idade:D} anos";
        }
    }
}
