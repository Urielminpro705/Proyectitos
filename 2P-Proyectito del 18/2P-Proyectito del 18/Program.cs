using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_Proyectito_del_18
{
    internal class Program
    {
        public static void Main()
        {
            Empleado e1=new Empleado("Pepe", 200, Program.Empleado.sueldo.practicante, Program.Empleado.incentivo.algo, Program.Empleado.porcentaje.normal);
            Empleado e2 = new Empleado("Juan", 300, Program.Empleado.sueldo.pasante, Program.Empleado.incentivo.nulo, Program.Empleado.porcentaje.inicio);
            Empleado e3 = new Empleado("Pedro", 500, Program.Empleado.sueldo.senior, Program.Empleado.incentivo.consentidos, Program.Empleado.porcentaje.elevado);
            Console.WriteLine("--Empleado 1--");
            Console.WriteLine("Nombre: " + e1.nombre);
            Console.WriteLine("Sueldo: " + e1.a);
            Console.WriteLine("Incentivo: " + e1.b);
            Console.WriteLine("Porcentaje: " + e1.c);
            Console.WriteLine("Total de percepcion: " + e1.calcular()+ "\n");

            Console.WriteLine("--Empleado 2--");
            Console.WriteLine("Nombre: " + e2.nombre);
            Console.WriteLine("Sueldo: " + e2.a);
            Console.WriteLine("Incentivo: " + e2.b);
            Console.WriteLine("Porcentaje: " + e2.c);
            Console.WriteLine("Total de percepcion: " + e2.calcular() + "\n");

            Console.WriteLine("--Empleado 3--");
            Console.WriteLine("Nombre: " + e3.nombre);
            Console.WriteLine("Sueldo: " + e3.a);
            Console.WriteLine("Incentivo: " + e3.b);
            Console.WriteLine("Porcentaje: " + e3.c);
            Console.WriteLine("Total de percepcion: " + e3.calcular());
        }


        public class Empleado
        {
            public String nombre;
            public double venta;
            public sueldo a;
            public incentivo b;
            public porcentaje c;

            public Empleado() { }
            public Empleado(string nombre, double venta, sueldo a, incentivo b, porcentaje c)
            {
                this.nombre = nombre;
                this.venta = venta;
                this.a= a;
                this.b= b;
                this.c= c;
            }

            public enum sueldo {practicante=1000, pasante=2000, nuevo=3000, junior=6000, senior=12000};
            public enum incentivo {nulo=0, algo=500, normal=1000, consentidos=2000}
            public enum porcentaje {inicio=3, normal=6, elevado=8}

            public double calcular()
            {
                double percepcion, descuento=(int)c;
                percepcion = (int)a + (int)b + (venta*(descuento/100));
                return percepcion;
            }
        }


    }
}
