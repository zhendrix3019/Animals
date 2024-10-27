using System;
using System.IO;

namespace Animals.Services
{
    public class FileInput
    {
        private StreamReader _reader;

        public FileInput(string fileName)
        {
            try
            {
                _reader = new StreamReader(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File Open Error: {fileName} {e.Message}");
            }
        }

        public string FileReadLine()
        {
            try
            {
                return _reader.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Read Error: {e.Message}");
                return null;
            }
        }

        public void FileClose()
        {
            _reader?.Close();
        }
    }
}
