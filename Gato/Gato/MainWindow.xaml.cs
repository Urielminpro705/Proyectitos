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
        private String fichasLetras;
        private int ficha;
        private Boolean turnos=true;
        private Boolean sePuedeJugar=false;
        private Boolean fin=false;
        private int contador=0;      
        private int[,] cuadricula=new int[3,3];
        private Jugador j1 = new Jugador();
        private Jugador j2 = new Jugador();
        private Jugador ganador = new Jugador();
        
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
                    ficha = j1.ficha;
                    fichasLetras = j1.fichaLetras;
                }
                else
                {
                    ficha = j2.ficha;
                    fichasLetras = j2.fichaLetras;
                }

                if (ficha == 1)
                {
                    boton.Background = Brushes.LightGreen;
                }
                else
                {
                    boton.Background = Brushes.OrangeRed;
                }
                boton.IsEnabled = false;
                boton.Content = fichasLetras;

                switch (boton.Name)
                {
                    case "a1":                        
                        cuadricula[0, 0] = ficha;                       
                        break;

                    case "a2":                       
                        cuadricula[1, 0] = ficha;                        
                        break;

                    case "a3":                       
                        cuadricula[2, 0] = ficha;
                        break;

                    case "b1":                       
                        cuadricula[0, 1] = ficha;
                        break;

                    case "b2":                       
                        cuadricula[1, 1] = ficha;
                        break;

                    case "b3":                        
                        cuadricula[2, 1] = ficha;
                        break;

                    case "c1":                       
                        cuadricula[0, 2] = ficha;
                        break;

                    case "c2":                       
                        cuadricula[1, 2] = ficha;
                        break;

                    case "c3":                       
                        cuadricula[2, 2] = ficha;
                        break;
                }                               
                contador++;
                fin = seAcabo();
                turnos = !turnos;
            }
            
        }

        public Boolean seAcabo()
        {
            Boolean fin = false;
            int fichaComun = 0;
            int juntas=1;
            for (int r = 0; r < 3 && juntas < 3; r++)
            {
                for (int j = 0; j < 2 && juntas < 3; j++)
                {
                    if (cuadricula[r, j] == cuadricula[r, j + 1])
                    {
                        juntas++;
                        fichaComun = cuadricula[r, j];

                    }
                    else
                    {
                        j = 2;
                        juntas = 1;
                        fichaComun = 0;

                    }
                }

            }



            for (int r = 0; r < 3 && juntas < 3; r++)
            {
                for (int j = 0; j < 2 && juntas < 3; j++)
                {
                    if (cuadricula[j, r] == cuadricula[j+1, r])
                    {
                        juntas++;
                        fichaComun = cuadricula[j, r];

                    }
                    else
                    {
                        j = 2;
                        juntas = 1;
                        fichaComun = 0;
                    }
                }

            }

            int g = 0;
            for (int j = 0; j < 2 && juntas < 3; j++)
            {
                if (cuadricula[j, g] == cuadricula[j + 1, g + 1])
                {
                    juntas++;
                    fichaComun = cuadricula[j, g];
                    g++;
                }
                else
                {
                    j = 2;
                    juntas = 1;
                    fichaComun = 0;

                }
            }

            g = 2;
            for (int j = 0; j < 2 && juntas < 3; j++)
            {
                if (cuadricula[g, j] == cuadricula[g-1, j + 1])
                {
                    juntas++;
                    fichaComun = cuadricula[g, j];
                    g--;

                }
                else
                {
                    j = 2;
                    juntas = 1;
                    fichaComun = 0;

                }
            }
            


            if(juntas == 3)
            {
                if(fichaComun == 0)
                {
                    fin = false;
                }
                else
                {
                    if(fichaComun == j1.ficha)
                    {
                        fin = true;
                        ganador = j1;
                        j1.puntos++;
                        puntos1.Text = j1.puntos.ToString();
                        puntos2.Text = j2.puntos.ToString();
                        sePuedeJugar = false;
                        if(j1.ficha == 1)
                        {
                            ganaVerde.Visibility= Visibility.Visible;
                        }
                        else
                        {
                            ganaRojo.Visibility= Visibility.Visible;
                        }
                        bEmpezar.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if(fichaComun == j2.ficha)
                        {
                            fin = true;
                            ganador = j2;
                            j2.puntos++;
                            puntos1.Text = j1.puntos.ToString();
                            puntos2.Text = j2.puntos.ToString();
                            sePuedeJugar = false;
                            if (j2.ficha == 1)
                            {
                                ganaVerde.Visibility = Visibility.Visible;
                            }
                            else
                            {
                                ganaRojo.Visibility = Visibility.Visible;
                            }
                            bEmpezar.Visibility = Visibility.Visible;
                        }                      
                    }
                    
                }
            }
            else
            {
                if (contador >= 9)
                {
                    fin = true;
                    sePuedeJugar = false;
                    empate.Visibility = Visibility.Visible;
                    bEmpezar.Visibility = Visibility.Visible;
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
            volverAjugar();
            j1.nombre = nombreJ1.Text;
            j2.nombre = nombreJ2.Text;           
            if (opciones.SelectedIndex == 0)
            {
                j1.ficha = 1;
                j2.ficha = 2;
                j1.fichaLetras = "O";
                j2.fichaLetras = "X";
                r1.Text = j1.nombre;
                r2.Text = j2.nombre;
            }
            else
            {
                if (opciones.SelectedIndex == 1)
                {
                    j1.ficha = 2;
                    j2.ficha = 1;
                    j1.fichaLetras = "X";
                    j2.fichaLetras = "O";
                    r1.Text = j2.nombre;
                    r2.Text = j1.nombre;
                }
            }
            sePuedeJugar = true;
            bReiniciar.Visibility = Visibility.Visible;
            bEmpezar.Visibility = Visibility.Hidden;           
            opciones.IsEnabled = false;
            nombreJ1.IsEnabled = false;
            nombreJ2.IsEnabled = false;
        }

        public void volverAjugar()
        {
            turnos = true;
            fin = false;
            contador = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cuadricula[j, i] = 0;
                }
            }
            opciones.IsEnabled = true;
            nombreJ1.IsEnabled = true;
            nombreJ2.IsEnabled = true;
            bEmpezar.Visibility = Visibility.Visible;
            sePuedeJugar = false;
            a1.IsEnabled = true;
            a1.Background = Brushes.Transparent;
            a1.Content = "";
            a2.IsEnabled = true;
            a2.Background = Brushes.Transparent;
            a2.Content = "";
            a3.IsEnabled = true;
            a3.Background = Brushes.Transparent;
            a3.Content = "";

            b1.IsEnabled = true;
            b1.Background = Brushes.Transparent;
            b1.Content = "";
            b2.IsEnabled = true;
            b2.Background = Brushes.Transparent;
            b2.Content = "";
            b3.IsEnabled = true;
            b3.Background = Brushes.Transparent;
            b3.Content = "";

            c1.IsEnabled = true;
            c1.Background = Brushes.Transparent;
            c1.Content = "";
            c2.IsEnabled = true;
            c2.Background = Brushes.Transparent;
            c2.Content = "";
            c3.IsEnabled = true;
            c3.Background = Brushes.Transparent;
            c3.Content = "";
            ganaVerde.Visibility = Visibility.Hidden;
            ganaRojo.Visibility = Visibility.Hidden;
            empate.Visibility = Visibility.Hidden;
        }

        private void Reiniciar(object sender, RoutedEventArgs e)
        {
            volverAjugar();          
            j1.puntos = 0;
            j2.puntos = 0;
            puntos1.Text = j1.puntos.ToString();
            puntos2.Text = j2.puntos.ToString();
        }      
    }
}
