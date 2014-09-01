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
            lista.Add(new Cientifico() { Id = "1", Nombre = "Testo 1", Apellido = "Tester 1", Merito = "Merito 1" });
            lista.Add(new Cientifico() { Id = "2", Nombre = "Testo 2", Apellido = "Tester 2", Merito = "Merito 2" });
            lista.Add(new Cientifico() { Id = "3", Nombre = "Testo 3", Apellido = "Tester 3", Merito = "Merito 3" });
            lista.Add(new Cientifico() { Id = "4", Nombre = "Testo 4", Apellido = "Tester 4", Merito = "Merito 4" });
            lista.Add(new Cientifico() { Id = "5", Nombre = "Testo 5", Apellido = "Tester 5", Merito = "Merito 5" });
            lista.Add(new Cientifico() { Id = "6", Nombre = "Testo 6", Apellido = "Tester 6", Merito = "Merito 6" });
            lista.Add(new Cientifico() { Id = "7", Nombre = "Testo 7", Apellido = "Tester 7", Merito = "Merito 7" });
            lista.Add(new Cientifico() { Id = "8", Nombre = "Testo 8", Apellido = "Tester 8", Merito = "Merito 8" });
            lista.Add(new Cientifico() { Id = "9", Nombre = "Testo 9", Apellido = "Tester 9", Merito = "Merito 9" });
            return lista;
        }
    }
}
