using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CientificosModule.Core.Objetos
{
    [Serializable]
    public class Cientifico
    {
        public String Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Merito { get; set; }
    }
}
