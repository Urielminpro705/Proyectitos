using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectito2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la opcion a realizar");
            Console.WriteLine("---Areas y Perimetros---");
            Console.WriteLine("1) Circulo");
            Console.WriteLine("2) Triangulo equilatero");
            Console.WriteLine("3) Triangulo isoceles");
            Console.WriteLine("4) Triangulo escaleno");
            Console.WriteLine("---Volumenes---");
            Console.WriteLine("5) Cubo");
            Console.WriteLine("6) Cilindro");
            Console.WriteLine("7) Todas las operaciones a la vez");
            int indice = int.Parse(Console.ReadLine());
            double area, perimetro, radio, laBase, altura, lado, lado2, volumen;
            switch (indice)
            {
                case 1: Console.WriteLine("Introduce el radio");
                        radio=double.Parse(Console.ReadLine());
                        area = Math.Pow(radio, 2) * Math.PI;
                        perimetro = radio * 2 * Math.PI;
                        Console.WriteLine("El radio ingresado es: " + radio);
                        Console.WriteLine("El area es: " + area);
                        Console.WriteLine("El perimetro es: " + perimetro);
                        
                        break;
                case 2: Console.WriteLine("Introduce la base del triangulo");
                        laBase = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del triangulo");
                        altura = double.Parse(Console.ReadLine());
                        area = (laBase * altura) / 2;
                        perimetro = laBase*3;
                        Console.WriteLine("Se ingreso una base de {0} y una altura de {1} ",laBase,altura);
                        Console.WriteLine("El area es: " + area);
                        Console.WriteLine("El perimetro es: " + perimetro);
                        break;
                case 3: Console.WriteLine("Introduce la base del triangulo");
                        laBase= double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del triangulo");
                        altura = double.Parse(Console.ReadLine());
                        area = (laBase * altura) / 2;
                        lado = Math.Sqrt(Math.Pow((laBase / 2), 2)+ Math.Pow(altura,2));
                        perimetro = laBase + (lado * 2);
                        Console.WriteLine("Se ingreso una base de {0} y una altura de {1} ", laBase, altura);
                        Console.WriteLine("El area es: " + area);
                        Console.WriteLine("El perimetro es: " + perimetro);
                        break;
                case 4: Console.WriteLine("Introduce la base del triangulo");
                        laBase= double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del triangulo");
                        altura = double.Parse(Console.ReadLine());
                        area = (laBase * altura) / 2;
                        Console.WriteLine("Introduce el valor de uno de los lados que no sea la base");
                        lado=double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el lado faltante");
                        lado2=double.Parse(Console.ReadLine());
                        perimetro = laBase + lado + lado2;
                        Console.WriteLine("Se ingreso una base de {0} y una altura de {1}", laBase, altura + $". Ademas, uno de sus lados es {lado} y el otro {lado2}");
                        Console.WriteLine("El area es: " + area);
                        Console.WriteLine("El perimetro es: " + perimetro);
                        break;
                case 5: Console.WriteLine("Introduce el valor de un lado");
                        lado=double.Parse(Console.ReadLine());
                        volumen = Math.Pow(lado, 3);
                        Console.WriteLine("Se ingreso que uno de los lados es {0}",lado);
                        Console.WriteLine("El volumen es: " + volumen);
                        break;
                case 6: Console.WriteLine("Introduce el radio");
                        radio=double.Parse(Console.ReadLine());
                        area = Math.Pow(radio, 2) * Math.PI;
                        Console.WriteLine("Introduce la altura");
                        altura=double.Parse(Console.ReadLine());
                        volumen = area * altura;
                        Console.WriteLine("El radio ingresado es: " + radio);
                        Console.WriteLine("La altura ingresada es: " + altura);
                        Console.WriteLine("El volumen es: " + volumen);
                        break;
                case 7:
                        Console.WriteLine("--Circulo--");
                        Console.WriteLine("Introduce el radio");
                        radio = double.Parse(Console.ReadLine());
                        area = Math.Pow(radio, 2) * Math.PI;
                        perimetro = radio * 2 * Math.PI;
                        Console.WriteLine("El radio ingresado es: " + radio);
                        Console.WriteLine("El area es: " + area);
                        Console.WriteLine("El perimetro es: " + perimetro);

                        Console.WriteLine("\n--Triangulo equilatero--");
                        Console.WriteLine("Introduce la base del triangulo");
                        laBase = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del triangulo");
                        altura = double.Parse(Console.ReadLine());
                        area = (laBase * altura) / 2;
                        perimetro = laBase * 3;
                        Console.WriteLine("Se ingreso una base de {0} y una altura de {1} ", laBase, altura);
                        Console.WriteLine("El area es: " + area);
                        Console.WriteLine("El perimetro es: " + perimetro);

                        Console.WriteLine("\n--Triangulo isoceles--");
                        Console.WriteLine("Introduce la base del triangulo");
                        laBase = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del triangulo");
                        altura = double.Parse(Console.ReadLine());
                        area = (laBase * altura) / 2;
                        lado = Math.Sqrt(Math.Pow((laBase / 2), 2) + Math.Pow(altura, 2));
                        perimetro = laBase + (lado * 2);
                        Console.WriteLine("Se ingreso una base de {0} y una altura de {1} ", laBase, altura);
                        Console.WriteLine("El area es: " + area);
                        Console.WriteLine("El perimetro es: " + perimetro);

                        Console.WriteLine("\n--Triangulo escaleno--");
                        Console.WriteLine("Introduce la base del triangulo");
                        laBase = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del triangulo");
                        altura = double.Parse(Console.ReadLine());
                        area = (laBase * altura) / 2;
                        Console.WriteLine("Introduce el valor de uno de los lados que no sea la base");
                        lado = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el lado faltante");
                        lado2 = double.Parse(Console.ReadLine());
                        perimetro = laBase + lado + lado2;
                        Console.WriteLine("Se ingreso una base de {0} y una altura de {1}", laBase, altura + $". Ademas, uno de sus lados es {lado} y el otro {lado2}");
                        Console.WriteLine("El area es: " + area);
                        Console.WriteLine("El perimetro es: " + perimetro);

                        Console.WriteLine("\n--Cubo--");
                        Console.WriteLine("Introduce el valor de un lado");
                        lado = double.Parse(Console.ReadLine());
                        volumen = Math.Pow(lado, 3);
                        Console.WriteLine("Se ingreso que uno de los lados es {0}", lado);
                        Console.WriteLine("El volumen es: " + volumen);

                        Console.WriteLine("\n--Cilindro--");
                        Console.WriteLine("Introduce el radio");
                        radio = double.Parse(Console.ReadLine());
                        area = Math.Pow(radio, 2) * Math.PI;
                        Console.WriteLine("Introduce la altura");
                        altura = double.Parse(Console.ReadLine());
                        volumen = area * altura;
                        Console.WriteLine("El radio ingresado es: " + radio);
                        Console.WriteLine("La altura ingresada es: " + altura);
                        Console.WriteLine("El volumen es: " + volumen);
                        break;

                default: Console.WriteLine("El valor no es valido");
                        break;
            }
        }
    }
}
