using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AreasD
{
    /// <summary>
    /// Descripción breve de WebServiceDeAreas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceDeAreas : System.Web.Services.WebService
    {
        [WebMethod] // aqui colocamos este metodo para llamarlo a nuestro web service 

        public double AreaCirculo(double Radio)
        {
            ClaseAreas r = new ClaseAreas(); //aqui llamamos nuestra clase de area para que regrese la ejecucion de datos
            return r.AreaCirculo(Radio);
        }



        [WebMethod]

        public decimal AreaCuadrado(decimal Lado)
        {
            ClaseAreas r = new ClaseAreas();
            return r.AreaCuadrado(Lado);
        }

        [WebMethod]
        public decimal AreaTriangulo (decimal Base , decimal Altura)
        {
            ClaseAreas r = new ClaseAreas();
            return r.AreaTriangulo (Base, Altura);
        }
            
    }
}
