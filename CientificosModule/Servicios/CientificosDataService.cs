using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CientificosModule.Core.Objetos;

namespace CientificosModule.Servicios
{
    public class CientificosDataService : ICientificosDataService
    {
        public Cientificos obtenerCientificos()
        {
            Cientificos lista = new Cientificos();
            lista.Add(new Cientifico() { Id = "1", Nombre = "Alfred R.", Apellido = "Wallace", Merito = "Descubrió la evolución por Selección Natural" });
            lista.Add(new Cientifico() { Id = "2", Nombre = "Aristarchus", Apellido = "", Merito = "Primero en decir que la tierra orbita al sol" });
            lista.Add(new Cientifico() { Id = "3", Nombre = "Jane", Apellido = "Marcet", Merito = "Quimica Inspiracional" });
            lista.Add(new Cientifico() { Id = "4", Nombre = "Pythagoras", Apellido = "", Merito = "Primer Matemático Riguroso" });
            lista.Add(new Cientifico() { Id = "5", Nombre = "Alessandro", Apellido = "Volta", Merito = "Pionero Electrico. Inventor de la Batería." });
            lista.Add(new Cientifico() { Id = "6", Nombre = "James", Apellido = "Watt", Merito = "Padre de la Revolución Industrial." });
            lista.Add(new Cientifico() { Id = "7", Nombre = "Gene", Apellido = "Shoemaker", Merito = "Primer astro-geologo." });
            lista.Add(new Cientifico() { Id = "8", Nombre = "Brahmagupta", Apellido = "", Merito = "Descubridor del Cero." });
            lista.Add(new Cientifico() { Id = "9", Nombre = "Archimedes", Apellido = "", Merito = "Probablemente el mejor cientifico de la historia." });
            lista.Add(new Cientifico() { Id = "10", Nombre = "Eratosthenes", Apellido = "", Merito = "Calculó con precisión el tamaño del Planeta Tierra hace 2500 años." });
            lista.Add(new Cientifico() { Id = "11", Nombre = "Stephanie", Apellido = "Kwolek", Merito = "Inventora del Kevlar" });
            lista.Add(new Cientifico() { Id = "12", Nombre = "James", Apellido = "Clerk Maxwell", Merito = "Unificó electricidad, Magnetismo y Luz." });
            lista.Add(new Cientifico() { Id = "13", Nombre = "Albert", Apellido = "Einstein", Merito = "Preparaba unos bizcochos muy esponjosos." });
            lista.Add(new Cientifico() { Id = "14", Nombre = "Gregor", Apellido = "Mendel", Merito = "Fundador de la genética." });
            lista.Add(new Cientifico() { Id = "15", Nombre = "Dmitri", Apellido = "Mendeleev", Merito = "Descubrió la tabla periodica en un sueño." });
            return lista;
        }
    }
}
