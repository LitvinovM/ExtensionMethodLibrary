using System.IO;

namespace ExtensionMethodLibrary.ReferenceTypes.StreamMemory
{
    public static class ExtensionMemoryStream
    {
        /// <summary>
        /// Saves stream to a file and closes the stream
        /// </summary>
        /// <param name="stream">Data to be stored</param>
        /// <param name="path">Path to the file where the data is stored</param>
        public static void Save(this MemoryStream stream, FileInfo path)
        {
            File.WriteAllBytes(path.FullName, stream.ToArray());
            stream.Close();
        }

        /// <summary>
        /// Reads the contents of a file into an array of bytes
        /// </summary>
        /// <param name="path">Path to the file where the data is stored</param>
        /// <returns>Contents of a file</returns>
        public static MemoryStream Read(this FileInfo path)
        {
            return new MemoryStream(File.ReadAllBytes(path.FullName));
        }
    }
}