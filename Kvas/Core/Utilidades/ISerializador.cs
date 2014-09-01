using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvas.Core.Utilidades
{
    interface ISerializador
    {
        public static void SerializeObject<T>(String archivo, T objeto);
        public static T DeserializeObject<T>(String archivo);
    }
}
