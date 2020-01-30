using System;
using System.IO;

namespace DesignPatterns.__Commons
{
    public class OutputFile
    {
        private static readonly string outputFilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/output.txt";
        public OutputFile Write(string content)
        {
            File.WriteAllText(outputFilePath, content);
            return this;
        }

        public OutputFile WriteLine(string content)
        {
            Write(content + Environment.NewLine);
            return this;
        }

        public OutputFile Append(string content)
        {
            File.AppendAllText(outputFilePath, content);
            return this;
        }

        public OutputFile AppendLine(string content = "")
        {
            Append(content + Environment.NewLine);
            return this;
        }
    }
}
