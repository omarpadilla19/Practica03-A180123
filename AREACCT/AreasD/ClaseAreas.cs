using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AreasD
{
    public class ClaseAreas // Aqui cree la clase Areas donde incluire el codigo para calcular el area del circulo, cuadrado, triangulo
    {
        public double Radio { get; set; }     // estas variables centrales serviran para llamar la ejecucion de los codigos de cada area 
        public decimal Lado { get; set; }
        public decimal Base { get; set; }
        public decimal Altura { get; set; }

        public double AreaCirculo(double Radio1)
        {
            Radio = Radio1;     // aqui ejecutamos las instrucciones usando las operaciones que sirven para calcular el area del circulo
            var resultado = Math.PI * (Radio1 * Radio1);
            return resultado;
        }

        public decimal AreaCuadrado(decimal Lado1) // aqui desarrolle las variables para ejecutar el area del cuadrado
        {

            Lado = Lado1; // aqui ejecutamos las instrucciones usando las operaciones que sirven para calcular el area del cuadrado
            var resultado = Lado1 * Lado1;
            return resultado;
        }

        public decimal AreaTriangulo(decimal Base1, decimal Altura1) //aqui esta el codigo que ejecuta el area de un triangulo
        {
            Base=Base1;
            Altura=Altura1;             // aqui ejecutamos las instrucciones usando las operaciones que sirven para calcular el area del triangulo
            var resultado =(Base1 * Altura1) / 2;
            return resultado;
        }




    }
}