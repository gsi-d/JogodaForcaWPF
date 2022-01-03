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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JogoForcaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string palavr;
        private int cont = 0;
        private int contador = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clickbtn(object sender, RoutedEventArgs e)
        {
            if (cont == 0)
            {
                for (int i = 0; i < ttbPalavra.Text.Length; i++)
                {
                    if (ttbPalavra.Text[i].ToString() != " ")
                    {
                        ttbChave.Text += "_ ";
                        cont++;
                        btnPalavra.Content = "Enviar resposta";
                    }
                    else
                        ttbChave.Text += "  ";
                }
            }
            else
            {
                if (ttbPalavra.Text == palavr)
                {
                    lblChances.FontSize = 15;
                    lblChances.Content = "Parabéns,\n você acertou!";
                    ttbChave.Text = ttbPalavra.Text;
                }
                else
                {
                    if(contador == 0)
                    {
                        int count = Convert.ToInt32(lblChances.Content);
                        count--;
                        lblChances.Content = count;
                    }
                    
                }
            }

            palavr = ttbPalavra.Text;
            ttbPalavra.Clear();

        }

        private void clickbtnLetra(object sender, RoutedEventArgs e)
        {
            string palSecreta = palavr;
            string[] palavra = new string[palavr.Length];
            for (int i = 0; i < palavr.Length; i++)
            {
                palavra[i] = palSecreta[i].ToString();
            }
            string letra = ttbLetras.Text;
            ttbLetras.Clear();
            string chave = ttbChave.Text.ToString();
            string[] chav = new string[ttbChave.Text.Length];
            for (int i = 0; i < ttbChave.Text.Length; i++)
            {
                chav[i] = chave[i].ToString();
            }

            for (int i = 0; i < palavra.Length; i++)
            {

                if (letra == palavra[i].ToString())
                {
                    chav[i + i] = letra;
                    contador++;
                }
            }

            if (contador == 0)
            {
                int count = Convert.ToInt32(lblChances.Content);
                count--;
                lblChances.Content = count;
            }

            ttbList.Text += letra + " ";
            ttbChave.Clear();

            for (int i = 0; i < chav.Length; i++)
            {
                ttbChave.Text += chav[i];
            }

            if (ttbChave.Text == palavr)
            {
                lblChances.Content = "Parabéns, você acertou!";
            }

            ttbLetras.Focus();

            if (Convert.ToInt32(lblChances.Content) == 0)
            {
                lblChances.FontSize = 15;
                lblChances.Content = "Suas chances\n acabaram!";
                ttbChave.IsEnabled = false;
                ttbLetras.IsEnabled = false;
                ttbPalavra.IsEnabled = false;
                btnLetra.IsEnabled = false;
                btnPalavra.IsEnabled = false;
            }
        }

        private void ttbChave_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}