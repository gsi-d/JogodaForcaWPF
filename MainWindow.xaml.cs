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
                        btnPalavra.Visibility = Visibility.Collapsed;
                        btnEnviarResposta.Visibility = Visibility.Visible;
                    }
                    else
                        ttbChave.Text += "  ";
                }
            }
            else
            {
                if (ttbPalavra.Text == palavr)
                {
                    MessageBox.Show("Parabéns, você acertou!");
                    btnPalavra.Visibility = Visibility.Visible;
                    btnEnviarResposta.Visibility = Visibility.Collapsed;
                    lblChances.Content = "12";
                    ttbChave.Text = ttbPalavra.Text;
                }
                else
                {
                    int count = Convert.ToInt32(lblChances.Content);
                    count--;
                    lblChances.Content = count;
                    DesenhaCorpo(count);
                }
            }

            palavr = ttbPalavra.Text;
            ttbPalavra.Clear();

        }

        private void clickCriarPalavra(object sender, RoutedEventArgs e)
        {

            ttbChave.Clear();
            for (int i = 0; i < ttbPalavra.Text.Length; i++)
            {
                if (ttbPalavra.Text[i].ToString() != " ")
                {
                    ttbChave.Text += "_ ";
                    cont++;
                    btnPalavra.Visibility = Visibility.Collapsed;
                    btnEnviarResposta.Visibility = Visibility.Visible;
                }
                else
                    ttbChave.Text += "  ";
            }
            ttbList.Text = "";
            palavr = ttbPalavra.Text;
            mensagemDerrota.Visibility = Visibility.Collapsed;
            mensagemPalavra.Visibility = Visibility.Collapsed;
            ResetaCorpo();
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

            

            bool letraRepetida = false;
            foreach (var item in ttbList.Text)
            {
                if (item.ToString() == letra)
                    letraRepetida = true;
            }
            if (letraRepetida)
                MessageBox.Show("A letra '" + letra + "' já foi informada.");
            else
            {
                ttbList.Text += letra + " ";
                ttbChave.Clear();

                for (int i = 0; i < chav.Length; i++)
                {
                    ttbChave.Text += chav[i];
                }

                var textoChave = ttbChave.Text.Replace(" ", "");
                if (textoChave == palavr)
                {
                    MessageBox.Show("Parabéns, você acertou!");
                    btnPalavra.Visibility = Visibility.Visible;
                    btnEnviarResposta.Visibility = Visibility.Collapsed;
                    lblChances.Content = "12";
                }

                int count = Convert.ToInt32(lblChances.Content);
                count--;
                lblChances.Content = count;
                DesenhaCorpo(count);

                ttbLetras.Focus();

                if (Convert.ToInt32(lblChances.Content) == 0)
                {
                    MessageBox.Show("Suas chances acabaram!");
                    //lblChances.Content = "Suas chances\n acabaram!";
                    ttbChave.Text = palavr;
                    ttbChave.IsEnabled = false;
                    ttbLetras.IsEnabled = false;
                    ttbPalavra.IsEnabled = false;
                    btnLetra.IsEnabled = false;
                    btnPalavra.IsEnabled = false;
                    mensagemDerrota.Visibility = Visibility.Visible;
                    mensagemPalavra.Visibility = Visibility.Visible;
                }
            }

            
        }

        private void DesenhaCorpo(int count)
        {
            switch (count)
            {
                case 11:
                    cabeca.Visibility = Visibility.Visible;
                    break;
                case 9:
                    tronco.Visibility = Visibility.Visible;
                    break;
                case 8:
                    break;
                case 7:
                    bracoDireito.Visibility = Visibility.Visible;
                    break;
                case 5:
                    bracoEsquerdo.Visibility = Visibility.Visible;
                    break;
                case 4:
                    pernaDireita.Visibility = Visibility.Visible;
                    break;
                case 3:
                    pernaEsquerda.Visibility = Visibility.Visible;
                    break;
                case 2:
                    olhoDireito.Visibility = Visibility.Visible;
                    break;
                case 1:
                    olhoEsquerdo.Visibility = Visibility.Visible;
                    break;
                case 0:
                    boca.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void ResetaCorpo()
        {
            cabeca.Visibility = Visibility.Collapsed;
            tronco.Visibility = Visibility.Collapsed;
            bracoDireito.Visibility = Visibility.Collapsed;
            bracoEsquerdo.Visibility = Visibility.Collapsed;
            pernaDireita.Visibility = Visibility.Collapsed;
            pernaEsquerda.Visibility = Visibility.Collapsed;
            olhoDireito.Visibility = Visibility.Collapsed;
            olhoEsquerdo.Visibility = Visibility.Collapsed;
            boca.Visibility = Visibility.Collapsed;
        }
    }
}