using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3P__CRUD_simple
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Mostrarusuarios();
            ocultar();
        }

        private object[] indice = new object[100];
        private SqlConnection conectateSQL = new SqlConnection("Data Source=PC_de_Uriel;Initial Catalog=UsuariosDB;Integrated Security=True");

        
        public void Mostrarusuarios()
        {          
            string consulta = "SELECT id, usr FROM usuario";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectateSQL);
            DataSet datos = new DataSet();          
            conectateSQL.Open();
            adaptador.Fill(datos);             
            lista.Items.Clear();
            try
            {
                DataTable tabla = datos.Tables[0];
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow fila = tabla.Rows[i];
                    lista.Items.Add(fila["usr"]);
                    indice[i] = fila["id"];
                }                         
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            conectateSQL.Close();
        }       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (lista.SelectedIndex != -1)
            {
                string consulta = "DELETE FROM usuario WHERE ID=@elID";
                SqlCommand miComandoSQL = new SqlCommand(consulta, conectateSQL);
                conectateSQL.Open();
                miComandoSQL.Parameters.AddWithValue("@elID", indice[lista.SelectedIndex]);
                miComandoSQL.ExecuteNonQuery();
                conectateSQL.Close();
                Mostrarusuarios();
            }                                    
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string consulta = "INSERT INTO usuario (usr, contra) VALUES (@nombreusr, @pwd)";
            SqlCommand miComandoI = new SqlCommand(consulta, conectateSQL);
            conectateSQL.Open();
            miComandoI.Parameters.AddWithValue("@nombreusr", altaUsr.Text);
            miComandoI.Parameters.AddWithValue("@pwd", contrasena.Text);
            miComandoI.ExecuteNonQuery();
            conectateSQL.Close();
            Mostrarusuarios();
            altaUsr.Text = "";
            contrasena.Text = "";
        }

        private void Button_CLick_3(object sender, RoutedEventArgs e)
        {
            int elIDOriginal = (int)indice[lista.SelectedIndex];
            string consulta = "UPDATE usuario SET usr= @nombreusr," + " contra = @pwd WHERE ID = " + elIDOriginal;
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                modificar.Visibility = Visibility.Visible;
                opciones.IsEnabled = false;
                string consulta = "SELECT usr, contra FROM usuario WHERE ID = @elID";
                SqlCommand miComandoSQL = new SqlCommand(consulta, conectateSQL);
                SqlDataAdapter adaptador = new SqlDataAdapter(miComandoSQL);
                DataSet datos = new DataSet();
                using (adaptador)
                {
                    miComandoSQL.Parameters.AddWithValue("@elID", indice[lista.SelectedIndex]);
                    adaptador.Fill(datos);
                    DataTable tabla = datos.Tables[0];
                    usuarioact.Text = tabla.Rows[0]["usr"].ToString();
                    contrasenaact.Text = tabla.Rows[0]["contra"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lista.SelectedIndex != -1)
            {
                actu.Visibility = Visibility.Visible;
            }
            else
            {
                actu.Visibility = Visibility.Hidden;
            }
        }

        private void cancelar(object sender, RoutedEventArgs e)
        {
            opciones.IsEnabled = true;
            ocultar();
        }

        public void ocultar()
        {
            if (modificar.Visibility == Visibility.Visible)
            {
                modificar.Visibility = Visibility.Hidden;
                usuarioact.Text = "";
                contrasenaact.Text = "";
            }
            else
            {
                modificar.Visibility = Visibility.Visible;
            }
        }
    }
}
