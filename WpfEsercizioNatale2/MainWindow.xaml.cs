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
using System.IO;

namespace WpfEsercizioNatale2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(txtNumero1.Text);
            double num2 = double.Parse(txtNumero2.Text);
            if (ComboBox.SelectedIndex == 0)
            {
                double somma = num1 + num2;
                txtRisultato.Text = $"{somma}";
            }
            else if (ComboBox.SelectedIndex == 1)
            {
                double differenza = num1 - num2;
                txtRisultato.Text = $"{differenza}";
            }
            else if (ComboBox.SelectedIndex == 2)
            {
                double prodotto = num1 * num2;
                txtRisultato.Text = $"{prodotto}";
            }
            else if (ComboBox.SelectedIndex == 3)
            {
                double divisione = num1 / num2;
                txtRisultato.Text = $"{divisione}";
            }
            else
            {
                MessageBox.Show("devi prima selezionare un'operazione");
            }
            string risultato = txtRisultato.Text;
            StreamWriter w = new StreamWriter("CalcoloMatematico.txt", true, Encoding.UTF8);
            w.WriteLine($"numero 1:{txtNumero1.Text}\n");
            w.WriteLine($"numero 2:{txtNumero2.Text}\n");
            w.WriteLine(risultato);
            w.Flush();
            w.Close();

        }
    }
}
       
        
