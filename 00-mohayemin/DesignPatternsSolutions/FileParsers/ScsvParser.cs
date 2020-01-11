using System.IO;

namespace DesignPatternsSolutions.FileParsers
{
    class ScsvParser : IFileParser
    {
        private readonly string filePath;

        ScsvParser(string filePath)
        {
            this.filePath = filePath;
        }

        public string GetItemAsString(int index)
        {
            var lines = File.ReadAllLines(filePath);
            return lines[index + 1];
        }

        public int GetItemCount()
        {
            return File.ReadAllLines(filePath).Length - 1;
        }
    }
}
