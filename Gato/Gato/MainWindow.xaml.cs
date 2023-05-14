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

namespace Gato
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int ficha;
        private Boolean turnos=true;
        private int contador=0;      
        private int[,] cuadricula=new int[3,3];
        private Jugador j1 = new Jugador();
        private Jugador j2 = new Jugador();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void boton(object sender, RoutedEventArgs e)
        {
            Button boton = sender as Button;
            if(contador < 9)
            {
                if (turnos == true)
                {
                    ficha = j1.ficha;
                }
                else
                {
                    ficha = j2.ficha;
                }
                switch (boton.Name)
                {
                    case "a1":
                        a1.IsEnabled = false;
                        cuadricula[0, 0] = ficha;
                        MessageBox.Show("¡Hola! Has hecho clic en el botón.");
                        break;

                    case "a2":
                        a2.IsEnabled = false;
                        cuadricula[1, 0] = ficha;
                        break;

                    case "a3":
                        a3.IsEnabled = false;
                        cuadricula[2, 0] = ficha;
                        break;

                    case "b1":
                        b1.IsEnabled = false;
                        cuadricula[0, 1] = ficha;
                        break;

                    case "b2":
                        b2.IsEnabled = false;
                        cuadricula[1, 1] = ficha;
                        break;

                    case "b3":
                        b3.IsEnabled = false;
                        cuadricula[2, 1] = ficha;
                        break;

                    case "c1":
                        c1.IsEnabled = false;
                        cuadricula[0, 2] = ficha;
                        break;

                    case "c2":
                        c2.IsEnabled = false;
                        cuadricula[1, 2] = ficha;
                        break;

                    case "c3":
                        c3.IsEnabled = false;
                        cuadricula[2, 2] = ficha;
                        break;
                }
                contador++;

                turnos = !turnos;
            }
            
        }       
    }
}
