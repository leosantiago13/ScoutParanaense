using ScoutWPF.Views.Jogadores;
using ScoutWPF.Views.Times;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ScoutWPF.Views
{
    /// <summary>
    /// Interaction logic for frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Scout Paranaense",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void menuCadJogador_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void menuJogador_Click(object sender, RoutedEventArgs e)
        {
            frmCadastroJogadores frmJogadores = new frmCadastroJogadores();
            frmJogadores.ShowDialog();
        }

        private void menuTimes_Click(object sender, RoutedEventArgs e)
        {
            frmCadastroTimes frmTimes = new frmCadastroTimes();
            frmTimes.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Criado e desenvolvido por Leonardo Santiago.", "Scout Paranaense");
        }
    }
}
