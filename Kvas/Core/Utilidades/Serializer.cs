using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Kvas.Core.Utilidades
{
    /// <summary>
    /// Clase Utilitaria para guardar objetos en archivos de texto
    /// </summary>
    public class Serializer : ISerializador
    {
        /// <summary>
        /// Guarda un objeto en un archivo de texto
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="archivo"></param>
        /// <param name="objeto"></param>
        public static void SerializeObject<T>(String archivo, T objeto)
        {
            using (Stream stream = File.Open(archivo, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, objeto);
            }
        }

        /// <summary>
        /// Convierte los objetos que estan en un archivo de texto en un objeto
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static T DeserializeObject<T>(String archivo)
        {
            T objeto = default(T);
            using (Stream stream = File.Open(archivo, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                objeto = (T)bf.Deserialize(stream);
            }
            return objeto;
        }
    }
}
