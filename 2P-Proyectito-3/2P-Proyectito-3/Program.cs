using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Proyectito3
    {
        public static void Main()
        {
            Comision c = new Comision();          
            Salario s=new Salario(c.pedir());
            s.pedir();
            s.calcular();
            Console.WriteLine("La comision es: " + s.comision);
            Console.WriteLine("El salario por venta es: " + s.salarioVenta);

        }



        public class Salario
        {
            public double salario;
            public double salarioVenta;
            public double comision;

            public Salario(double comision)
            {
                this.comision = comision;
            }

            public void pedir()
            {
                Console.WriteLine("Introduce el salario base");
                this.salario = Double.Parse(Console.ReadLine());
            }
            public double calcular()
            {
                this.salarioVenta = this.comision + this.salario;
                return salarioVenta;
            }
        }

        public struct Comision
        {
            public double comision;
            public double venta;
            public double pedir()
            {
                Console.WriteLine("Introduce la venta");
                this.venta = Double.Parse(Console.ReadLine());
                this.comision = venta * 0.03;
                return comision;
            }
        }
    }
}



