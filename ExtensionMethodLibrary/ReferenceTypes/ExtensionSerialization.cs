using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ExtensionMethodLibrary.ReferenceTypes.Serialization
{
    public static class ExtensionSerialization
    {
        [DebuggerStepThrough]
        public static MemoryStream ToXml<T>(this T obj) where T : class
        {
            var stream = new MemoryStream();

            var xmlSerializer = new XmlSerializer(typeof(T));
            xmlSerializer.Serialize(stream, obj);

            stream.Position = 0;

            return stream;
        }

        [DebuggerStepThrough]
        public static MemoryStream ToBinary<T>(this T obj) where T : class
        {
            var stream = new MemoryStream();

            var binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, obj);
            
            stream.Position = 0;

            return stream;
        }

        [DebuggerStepThrough]
        public static T FromXml<T>(this MemoryStream stream) where T : class
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            var result = (T)xmlSerializer.Deserialize(stream);
            stream.Close();
            return result;
        }

        [DebuggerStepThrough]
        public static T FromBinary<T>(this MemoryStream stream) where T : class
        {
            var binaryFormatter = new BinaryFormatter();
            var result = (T)binaryFormatter.Deserialize(stream);
            stream.Close();
            return result;
        }
    }
}
