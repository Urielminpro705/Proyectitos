using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        //Atributos del programa
        private String fichasLetras;
        private int ficha;
        private Boolean turnos=true;
        private Boolean fin=false;
        private Boolean sePuedeJugar=false;
        private int contador=0;      
        private int[,] cuadricula=new int[3,3];
        private Jugador j1 = new Jugador();
        private Jugador j2 = new Jugador();
        private int auxPuntos1 = 0;
        private int auxPuntos2 = 0;
        public SqlConnection conectateSQL = new SqlConnection("Data Source=DESKTOP-D3BA5M2\\SQLEXPRESS;Initial Catalog=Historial;Integrated Security=True");

        public MainWindow()
        {
            InitializeComponent();
            MostrarJugadores();
        }

        //Funcion que se activa cada vez que se presiona un boton de la cuadricula
        private void boton(object sender, RoutedEventArgs e)
        {
            Button boton = sender as Button;
            //Se comprueba si aun sigue el juego y si aun no se presionan todos los botones
            if (contador < 9 && sePuedeJugar == true && fin == false)
            {
                //Este if le asigan datos a las variables necesarias dependiendo de quien sea el turno
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

                //Este if sirve para sabes de que ficha va a ser el boton dependiendo del turno
                if (ficha == 1)
                {
                    boton.Background = Brushes.LightGreen;
                    turnoRojo.Visibility = Visibility.Visible;
                    turnoVerde.Visibility = Visibility.Hidden;
                }
                else
                {
                    turnoVerde.Visibility = Visibility.Visible;
                    turnoRojo.Visibility = Visibility.Hidden;
                    boton.Background = Brushes.OrangeRed;
                }
                boton.IsEnabled = false;
                boton.Content = fichasLetras;
                //El switch sirve para recrear la cuadricula dentro de un arreglo bidimensional
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

        //Esta funcion sirve para comprobar si alguien ya gano el juego, o si quedaron empate
        public Boolean seAcabo()
        {
            Boolean fin = false;
            int fichaComun = 0;
            int juntas=1;
            //Este for analiza las 3 columnas
            for (int r = 0; r < 3 && juntas < 3; r++)
            {
                for (int j = 0; j < 2 && juntas < 3; j++)
                {
                    if (cuadricula[r, j] == cuadricula[r, j + 1] && cuadricula[r,j] != 0)
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

            //Este for analiza las 3 filas
            for (int r = 0; r < 3 && juntas < 3; r++)
            {
                for (int j = 0; j < 2 && juntas < 3; j++)
                {
                    if (cuadricula[j, r] == cuadricula[j+1, r] && cuadricula[j, r] != 0)
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

            //Este for analiza la linea diagonal que empieza por la parte superior izquierda
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

            //Este for analiza la linea diagonal que empieza por la parte inferior izquierda
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
            
            //Este if analiza cual ficha fue la ganadora
            if(juntas == 3)
            {
                if(fichaComun == 0)
                {
                    fin = false;
                }
                else
                {
                    //Al jugador que gane, se le agrega un punto
                    if(fichaComun == j1.ficha)
                    {
                        fin = true;
                        j1.puntos = 1;
                        j2.perdidas = 1;
                        auxPuntos1++;
                        sePuedeJugar = false;
                        //Dependiendo de cual ficha tenga el jugador va a variar el mensaje de ganador
                        if(j1.ficha == 1)
                        {
                            ganaVerde.Visibility= Visibility.Visible;
                            puntos1.Text = auxPuntos1.ToString();
                            puntos2.Text = auxPuntos2.ToString();
                        }
                        else
                        {
                            puntos1.Text = auxPuntos2.ToString();
                            puntos2.Text = auxPuntos1.ToString();
                            ganaRojo.Visibility= Visibility.Visible;
                        }
                        bEmpezar.Visibility = Visibility.Visible;
                        existeDB(j1);
                        existeDB(j2);
                    }
                    else
                    {
                        if(fichaComun == j2.ficha)
                        {
                            fin = true;
                            j2.puntos = 1;
                            j1.perdidas = 1;
                            auxPuntos2++;
                            sePuedeJugar = false;
                            if (j2.ficha == 1)
                            {
                                ganaVerde.Visibility = Visibility.Visible;
                                puntos1.Text = auxPuntos2.ToString();
                                puntos2.Text = auxPuntos1.ToString();
                            }
                            else
                            {
                                puntos1.Text = auxPuntos1.ToString();
                                puntos2.Text = auxPuntos2.ToString();
                                ganaRojo.Visibility = Visibility.Visible;
                            }
                            bEmpezar.Visibility = Visibility.Visible;
                            existeDB(j1);
                            existeDB(j2);
                        }                      
                    }                 
                }
            }
            else
            {
                //Este if sirve para saber si fue empate
                if (contador >= 9)
                {
                    fin = true;
                    sePuedeJugar = false;
                    empate.Visibility = Visibility.Visible;
                    bEmpezar.Visibility = Visibility.Visible;                   
                    j1.empates = 1;
                    j2.empates = 1;
                    existeDB(j1);
                    existeDB(j2);
                }
            }
            //Se retorna fin, si fin es true significa que ya se acabó el juego
            return fin;
        }

        //Esta funcion sirve para hacer que se asigne al jugador 2 una ficha diferente a la del jugador 1
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {         
            if(opciones.SelectedIndex==0)
            {              
                j1.fichaLetras = "O";
                j2.fichaLetras = "X";
                Ficha2.Text = j2.fichaLetras;
                j1.ficha = 1;
                j2.ficha = 2;
            }
            else
            {
                if (opciones.SelectedIndex == 1)
                {
                    j1.fichaLetras = "X";
                    j2.fichaLetras = "O";
                    Ficha2.Text = j2.fichaLetras;
                    j1.ficha = 2;
                    j2.ficha = 1;
                }               
            }
        }

        //Esta funcion se activa cuando se presiona el boton de empezar
        private void Empezar(object sender, RoutedEventArgs e)
        {
            if(nombreJ1.Text == string.Empty || nombreJ2.Text == string.Empty)
            {
                MessageBox.Show("Crea un nombre de jugador");
            }
            else
            {
                if (nombreJ1.Text == nombreJ2.Text)
                {
                    MessageBox.Show("No se pueden repetir nombres");
                }
                else
                {
                    volverAjugar();
                    //Se guardan los nombres
                    j1.nombre = nombreJ1.Text;
                    j2.nombre = nombreJ2.Text;
                    if (opciones.SelectedIndex == 0)
                    {
                        r1.Text = j1.nombre;
                        r2.Text = j2.nombre;
                        turnoRojo.Visibility = Visibility.Hidden;
                        turnoVerde.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (opciones.SelectedIndex == 1)
                        {
                            r1.Text = j2.nombre;
                            r2.Text = j1.nombre;
                            turnoVerde.Visibility = Visibility.Hidden;
                            turnoRojo.Visibility = Visibility.Visible;
                        }
                    }
                    //Se activa el tablero
                    sePuedeJugar = true;
                    //Se activa muestra el boton de reiniciar
                    bReiniciar.Visibility = Visibility.Visible;
                    //Se esconde el boton de empezar
                    bEmpezar.Visibility = Visibility.Hidden;
                    //Se deshabilitan las opciones
                    opciones.IsEnabled = false;
                    nombreJ1.IsEnabled = false;
                    nombreJ2.IsEnabled = false;
                    listaJugadores.IsEnabled = false;
                    listaJugadores2.IsEnabled = false;
                }
            }                      
        }

        //Esta funcion sirve para reiniciar muchos de los elementos a su estado original
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
            j1.puntos = 0;
            j1.perdidas = 0;
            j1.empates = 0;
            j2.puntos = 0;
            j2.perdidas = 0;
            j2.empates = 0;
        }

        //Esta funcion invoca a la funcion de volverAjugar y borra los puntos de los jugadores
        private void Reiniciar(object sender, RoutedEventArgs e)
        {
            volverAjugar();            
            MostrarJugadores();           
            puntos1.Text = "0";
            puntos2.Text = "0";
            auxPuntos1 = 0;
            auxPuntos2 = 0;
            opciones.IsEnabled = true;
            nombreJ1.IsEnabled = true;
            nombreJ2.IsEnabled = true;
            listaJugadores.IsEnabled = true;
            listaJugadores2.IsEnabled = true;
            turnoRojo.Visibility= Visibility.Hidden;
            turnoVerde.Visibility= Visibility.Hidden;
        }

        private void irHistorial_Click(object sender, RoutedEventArgs e)
        {
            // Código para cerrar la ventana actual y abrir una nueva ventana
            historial ventana = new historial(j1, j2, conectateSQL); // Reemplaza "NuevaVentana" con el nombre real de tu ventana
            ventana.Show();
        }
        private void insertar(Jugador j)
        {
            string consulta = "INSERT INTO Registros (Jugador, victorias, derrotas, empates) VALUES (@Jugador, @victorias, @derrotas, @empates)";
            SqlCommand miComandoI = new SqlCommand(consulta, conectateSQL);
            conectateSQL.Open();
            try
            {               
                miComandoI.Parameters.AddWithValue("@Jugador", j.nombre);
                miComandoI.Parameters.AddWithValue("@victorias", j.puntos);
                miComandoI.Parameters.AddWithValue("@derrotas", j.perdidas);
                miComandoI.Parameters.AddWithValue("@empates", j.empates);
                miComandoI.ExecuteNonQuery();               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conectateSQL.Close();
        }

        public void MostrarJugadores()
        {
            listaJugadores.Items.Clear();
            listaJugadores2.Items.Clear();
            listaJugadores.Items.Add("Nuevo jugador");
            listaJugadores2.Items.Add("Nuevo jugador");
            string consulta = "SELECT * FROM Registros;";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectateSQL);
            DataSet datos = new DataSet();
            conectateSQL.Open();
            adaptador.Fill(datos);
            try
            {
                DataTable tabla = datos.Tables[0];
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow fila = tabla.Rows[i];
                    listaJugadores.Items.Add(fila["Jugador"]);
                    listaJugadores2.Items.Add(fila["Jugador"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conectateSQL.Close();
        }

        private void actualizarPuntaje(Jugador j)
        {
            
            try
            {
                string consulta = "UPDATE Registros SET victorias = victorias + @victorias, derrotas = derrotas + @derrotas, empates = empates + @empates WHERE Jugador = @Jugador";
                SqlCommand miComandoI = new SqlCommand(consulta, conectateSQL);
                conectateSQL.Open();
                miComandoI.Parameters.AddWithValue("@Jugador", j.nombre);
                miComandoI.Parameters.AddWithValue("@victorias", j.puntos);
                miComandoI.Parameters.AddWithValue("@derrotas", j.perdidas);
                miComandoI.Parameters.AddWithValue("@empates", j.empates);
                miComandoI.ExecuteNonQuery();               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conectateSQL.Close();
        }

        private void listaJugadores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listaJugadores.SelectedIndex == 0)
            {
                nombreJ1.Text = string.Empty;
            }
            else
            {
                nombreJ1.Text = (string)listaJugadores.SelectedItem;
            }
        }

        private void listaJugadores2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listaJugadores2.SelectedIndex == 0)
            {
                nombreJ2.Text = string.Empty;
            }
            else
            {
                nombreJ2.Text = (string)listaJugadores2.SelectedItem;
            }
        }

        private void existeDB(Jugador j)
        {
            Boolean existe = false;
            try
            {
               
                string consulta = "SELECT Jugador FROM Registros WHERE Jugador = '" + j.nombre + "'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectateSQL);
                DataSet datos = new DataSet();
                conectateSQL.Open();
                adaptador.Fill(datos);
                if (datos.Tables[0].Rows.Count  > 0)
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conectateSQL.Close();
            if (existe == true)
            {
                actualizarPuntaje(j);
            }
            else
            {
                insertar(j);
            }
            
        }
    }
}
