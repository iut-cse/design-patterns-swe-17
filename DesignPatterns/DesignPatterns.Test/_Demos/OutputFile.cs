using System;
using System.IO;

namespace DesignPatterns.Test._Demos
{
    public class OutputFile
    {
        private static readonly string outputFilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/_Demos/output.txt";
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
