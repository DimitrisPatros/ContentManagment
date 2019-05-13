using System;

namespace ContentManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            IContent sentence = new SimpleText();
            FormatedText formatedText = new FormatedText();
            sentence.LoadText("countwords");
            formatedText.LoadText("countwords");
            Console.WriteLine(sentence.CountWords());
            Console.WriteLine(sentence.GetLengthiestWord());
            Console.WriteLine(formatedText.CountWords());

        }
    }
}
