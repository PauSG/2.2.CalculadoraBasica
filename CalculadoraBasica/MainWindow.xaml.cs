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

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        
        private void Calcular_click(object sender, RoutedEventArgs e)
        {
            try 
            {
                int operando1 = int.Parse(Operando1TextBox.Text), operando2 = int.Parse(Operando2TextBox.Text);

                switch (OperadorTextBox.Text)
                {
                    case "+":
                        ResultadoTextBox.Text = (operando1 + operando2).ToString();
                        break;
                    case "-":
                        ResultadoTextBox.Text = (operando1 - operando2).ToString();
                        break;
                    case "*":
                        ResultadoTextBox.Text = (operando1 * operando2).ToString();
                        break;
                    case "/":
                        if(operando2 == 0)
                        {
                            ResultadoTextBox.Text = "Infinito";
                        }
                        else
                        {
                            ResultadoTextBox.Text = (operando1 / operando2).ToString();
                        }
                        break;
                }

            }
            catch(FormatException)
            {
                MessageBox.Show("Error de formato, introduce numeros enteros.");
                VaciarTextBox();
            }
            
        }

        private void Limpiar_click(object sender, RoutedEventArgs e)
        {
            VaciarTextBox();
        }
        private void VaciarTextBox()
        {
            Operando1TextBox.Clear();
            Operando2TextBox.Clear();
            OperadorTextBox.Clear();
            ResultadoTextBox.Clear();
        }

        private void OperadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OperadorTextBox.Text == "+" || OperadorTextBox.Text == "-" || OperadorTextBox.Text == "*" || OperadorTextBox.Text == "/")
            {
                CalcularButton.IsEnabled = true;
            }
            else
            {
                CalcularButton.IsEnabled = false;
            }
        }
    }
}

