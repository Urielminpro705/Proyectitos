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
        public SqlConnection conectateSQL;
        public historial(Jugador j1, Jugador j2, SqlConnection conectateSQL)
        {

            InitializeComponent();
            this.conectateSQL = conectateSQL;
            this.j1 = j1;
            this.j2 = j2;
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
                    lista.Items.Add(j1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conectateSQL.Close();
        }
    }
}
