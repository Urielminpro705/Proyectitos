using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Gato
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class historial : Window
    {
        public Jugador j1 = new Jugador();
        public Jugador j2 = new Jugador();
        string[] indice = new string[100];
        public SqlConnection conectateSQL;
        public historial(Jugador j1, Jugador j2, SqlConnection conectateSQL)
        {
            InitializeComponent();
            this.conectateSQL = conectateSQL;
            this.j1 = j1;
            this.j2 = j2;            
            Mostrarusuarios();                      
        }   

        public void testeo()
        {
            try
            {
                conectateSQL.Open();
                MessageBox.Show("Vamooooo");
            }
            catch (Exception ex) { }
        }
        public void Mostrarusuarios()
        {                 
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
                    indice[i] = fila["Jugador"].ToString();
                    
                }
                lista.ItemsSource = tabla.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conectateSQL.Close();
        } 

        private void borrarDatos_Click(object sender, RoutedEventArgs e)
        {
            string consulta = "DELETE FROM Registros;";
            SqlCommand miComandoSQL = new SqlCommand(consulta, conectateSQL);
            conectateSQL.Open();
            try
            {
                
                miComandoSQL.ExecuteNonQuery();
                
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            conectateSQL.Close();

            Mostrarusuarios();
        }

        private void borrarUnDato_Click(object sender, RoutedEventArgs e)
        {
            if (lista.SelectedIndex != -1)
            {
                string consulta = "DELETE FROM Registros WHERE Jugador = @j";
                SqlCommand miComandoSQL = new SqlCommand(consulta, conectateSQL);
                conectateSQL.Open();
                try
                {
                    miComandoSQL.Parameters.AddWithValue("@j", indice[lista.SelectedIndex]);
                    miComandoSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conectateSQL.Close();
                Mostrarusuarios();
            }
        }

        /*
        private void actualizarDatos_Click(object sender, RoutedEventArgs e)
        {
            int elIDOriginal = (int)indice[lista.SelectedIndex];
            string consulta = "UPDATE Registros SET Jugador = @j WHERE Jugador = " + elIDOriginal;
            SqlCommand miComandoI = new SqlCommand(consulta, conectateSQL);
            conectateSQL.Open();
            miComandoI.Parameters.AddWithValue("@nombreusr", usuarioact.Text);
            miComandoI.Parameters.AddWithValue("@pwd", contrasenaact.Text);
            miComandoI.ExecuteNonQuery();
            conectateSQL.Close();
            opciones.IsEnabled = true;
            ocultar();
            Mostrarusuarios();
        }

        private void existeDB()
        {
            Boolean existe = false;
            try
            {

                string consulta = "SELECT Jugador FROM Registros WHERE Jugador = '" + j.nombre + "'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectateSQL);
                DataSet datos = new DataSet();
                conectateSQL.Open();
                adaptador.Fill(datos);
                if (datos.Tables[0].Rows.Count > 0)
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
        */
    }   
}
