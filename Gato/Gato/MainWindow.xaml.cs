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
        private int turnos;
        private String j1;
        private String j2;
        private int[,] cuadricula=new int[3,3];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void boton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¡Hola! Has hecho clic en el botón.");
        }


    }
}
