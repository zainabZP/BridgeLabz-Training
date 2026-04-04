using System;
using System.IO;
using System.Text;

namespace FileProcessorApp
{
    public class FileProcessor
    {
        // Write content to a file safely
        public void WriteToFile(string fileName, string content)
        {
            using (var writer = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                writer.Write(content);
            }
        }

        // Read content from a file safely
        public string ReadFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException($"File not found: {fileName}");

            using (var reader = new StreamReader(fileName, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
