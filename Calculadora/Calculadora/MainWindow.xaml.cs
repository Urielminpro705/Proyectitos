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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int operadores = 0;
        public double total;
        public Queue<double> cola = new Queue<double>();
        public String n1,n2;
        public String numerosString=null;
        public String a = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void numero(object sender, RoutedEventArgs e)
        {
            Button boton = sender as Button;
            if (operadores == 0)
            {               
                numerosString = boton.Content.ToString();
                n1 += numerosString;
            }else
            {
                if (operadores == 1)
                {
                    numerosString = boton.Content.ToString();
                    n2 += numerosString;
                }
            }
            
            
                       
        }

        public void suma(object sender, RoutedEventArgs e)
        {
            if (operadores == 0)
            {
                total = double.Parse(n1);
                cola.Enqueue(total);
                operadores++;
            }
            else
            {

            }
        }

        public void signos(object sender, RoutedEventArgs e)
        {

        }

        public void resta(object sender, RoutedEventArgs e)
        {

        }
        public void multiplicacion(object sender, RoutedEventArgs e)
        {

        }

        public void division(object sender, RoutedEventArgs e)
        {

        }

        public void punto(object sender, RoutedEventArgs e)
        {

        }

        public void resultado(object sender, RoutedEventArgs e)
        {

        }

        public void imprimir()
        {
            pantallita.Text = Convert.ToString(total);
            
        }

        public void borrar(object sender, RoutedEventArgs e)
        {

        }
    }
}
