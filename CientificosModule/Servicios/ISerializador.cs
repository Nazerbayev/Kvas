using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CientificosModule.Servicios
{
    interface ISerializador
    {
        void SerializeObject<T>(String archivo, T objeto);
        T DeserializeObject<T>(String archivo);
    }
}
