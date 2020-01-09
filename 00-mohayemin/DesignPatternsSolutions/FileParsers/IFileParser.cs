namespace DesignPatternsSolutions.FileParsers
{
    interface IFileParser
    {
        public int GetItemCount();
        public string GetItemAsString(int index);
    }
}
