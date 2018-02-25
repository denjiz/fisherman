using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fisherman.DomainModel
{
    static class Persistor
    {
        internal static T DeserializeBinary<T>(string filePath)
        {
            Stream fileStream = File.OpenRead(filePath);
            BinaryFormatter deserializer = new BinaryFormatter();
            T _object = (T)deserializer.Deserialize(fileStream);
            fileStream.Close();

            return _object;
        }

        internal static void SerializeBinary<T>(T _object, string filePath)
        {
            Stream fileStream = File.Create(filePath);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fileStream, _object);
            fileStream.Close();
        }
    }
}
