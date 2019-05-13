namespace ContentManagment
{
    public interface IContent
    {
        int CountWords();
        string GetLengthiestWord();
        bool LoadText(string fileName);
        bool SaveText(string fileName);
    }
}
