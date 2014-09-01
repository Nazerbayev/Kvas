using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CientificosModule.Servicios
{
    public class XmlSerializador : ISerializador
    {
        public void SerializeObject<T>(String archivo, T objeto)
        {
            XmlSerializer xmls = new XmlSerializer(typeof(T));
            using (StreamWriter sw = new StreamWriter(archivo))
            {
                xmls.Serialize(sw, objeto);
            }
        }
        public T DeserializeObject<T>(String archivo)
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
