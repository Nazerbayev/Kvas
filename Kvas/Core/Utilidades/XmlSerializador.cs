using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Kvas.Core.Utilidades
{
    public class XmlSerializador : ISerializador
    {
        public static void SerializeObject<T>(String archivo, T objeto)
        {
            XmlSerializer xmls = new XmlSerializer(typeof(T));
            using (StreamWriter sw = new StreamWriter(archivo))
            {
                xmls.Serialize(sw, objeto);
            }
        }
        public static T DeserializeObject<T>(String archivo)
        {
            T objeto = default(T);
            XmlSerializer xmls = new XmlSerializer(typeof(T));
            using (StreamReader sw = new StreamReader(archivo))
            {
                objeto = (T)xmls.Deserialize(sw);
            }
            return objeto;
        }
    }
}
