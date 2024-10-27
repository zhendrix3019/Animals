using System;
using System.IO;

namespace Animals.Services
{
    public class FileOutput
    {
        private StreamWriter _writer;

        public FileOutput(string fileName)
        {
            try
            {
                _writer = new StreamWriter(fileName);
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Open Error: {fileName} {e.Message}");
            }
        }

        public void FileWrite(string line)
        {
            try
            {
                _writer.WriteLine(line);
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Write Error: {e.Message}");
            }
        }

        public void FileClose()
        {
            _writer?.Close();
        }
    }
}
