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
        private Boolean turnos;
        private Boolean sePuedeJugar=false;
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
            if (contador < 9 && sePuedeJugar == true)
            {
                if (turnos == true)
                {
                    ficha = 0;
                }
                else
                {
                    ficha = 1;
                }
               
                switch (boton.Name)
                {
                    case "a1":
                        if (ficha == 0)
                        {
                            boton.Background = Brushes.LightGreen;                           
                        }
                        else
                        {
                            boton.Background = Brushes.OrangeRed;
                        }
                        a1.IsEnabled = false;
                        cuadricula[0, 0] = ficha;                       
                        break;

                    case "a2":
                        if (ficha == 0)
                        {
                            boton.Background = Brushes.LightGreen;
                        }
                        else
                        {
                            boton.Background = Brushes.OrangeRed;
                        }
                        boton.IsEnabled = false;
                        cuadricula[1, 0] = ficha;                        
                        break;

                    case "a3":
                        if (ficha == 0)
                        {
                            boton.Background = Brushes.LightGreen;
                        }
                        else
                        {
                            boton.Background = Brushes.OrangeRed;
                        }
                        boton.IsEnabled = false;
                        cuadricula[2, 0] = ficha;
                        break;

                    case "b1":
                        if (ficha == 0)
                        {
                            boton.Background = Brushes.LightGreen;
                        }
                        else
                        {
                            boton.Background = Brushes.OrangeRed;
                        }
                        boton.IsEnabled = false;
                        cuadricula[0, 1] = ficha;
                        break;

                    case "b2":
                        if (ficha == 0)
                        {
                            boton.Background = Brushes.LightGreen;
                        }
                        else
                        {
                            boton.Background = Brushes.OrangeRed;
                        }
                        boton.IsEnabled = false;
                        cuadricula[1, 1] = ficha;
                        break;

                    case "b3":
                        if (ficha == 0)
                        {
                            boton.Background = Brushes.LightGreen;
                        }
                        else
                        {
                            boton.Background = Brushes.OrangeRed;
                        }
                        boton.IsEnabled = false;
                        cuadricula[2, 1] = ficha;
                        break;

                    case "c1":
                        if (ficha == 0)
                        {
                            boton.Background = Brushes.LightGreen;
                        }
                        else
                        {
                            boton.Background = Brushes.OrangeRed;
                        }
                        boton.IsEnabled = false;
                        cuadricula[0, 2] = ficha;
                        break;

                    case "c2":
                        if (ficha == 0)
                        {
                            boton.Background = Brushes.LightGreen;
                        }
                        else
                        {
                            boton.Background = Brushes.OrangeRed;
                        }
                        boton.IsEnabled = false;
                        cuadricula[1, 2] = ficha;
                        break;

                    case "c3":
                        if (ficha == 0)
                        {
                            boton.Background = Brushes.LightGreen;
                        }
                        else
                        {
                            boton.Background = Brushes.OrangeRed;
                        }
                        boton.IsEnabled = false;
                        cuadricula[2, 2] = ficha;
                        break;
                }
                contador++;

                turnos = !turnos;
            }
            
        }

        public Boolean seAcabo()
        {
            Boolean fin = false;
            int juntas=1;
            for(int i = 0; i < 3; i++)
            {
                for(int r = 0; r < 3; r++)
                {
                    for (int j = 0; j < 2 && juntas < 3; j++)
                    {
                        if (cuadricula[r, j] == cuadricula[r, j + 1])
                        {
                            juntas++;
                            
                        }
                        else
                        {
                            j = 2;
                            juntas = 1;
                        }
                    }

                }

                for (int r = 0; r < 3; r++)
                {
                    for (int j = 0; j < 2 && juntas < 3; j++)
                    {
                        if (cuadricula[j, r] == cuadricula[j, r + 1])
                        {
                            juntas++;

                        }
                        else
                        {
                            j = 2;
                            juntas = 1;
                        }
                    }

                }
            }
            return fin;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {         
            if(opciones.SelectedIndex==0)
            {
                Ficha2.Text = "X";
            }
            else
            {
                if (opciones.SelectedIndex == 1)
                {
                    Ficha2.Text = "O";
                }               
            }
        }

        private void Empezar(object sender, RoutedEventArgs e)
        {
            j1.nombre = nombreJ1.Text;
            j2.nombre = nombreJ2.Text;
            if (opciones.SelectedIndex == 0)
            {
                j1.ficha = 0;
                j2.ficha = 1;
                turnos = true;
            }
            else
            {
                if (opciones.SelectedIndex == 1)
                {
                    j1.ficha = 1;
                    j2.ficha = 0;
                    turnos = false;

                }
            }
            sePuedeJugar = true;
            bReiniciar.Visibility = Visibility.Visible;
            bEmpezar.Visibility = Visibility.Hidden;
        }

        private void Reiniciar(object sender, RoutedEventArgs e)
        {

        }
    }
}
