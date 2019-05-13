﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace ContentManagment
{
    class FormatedText : IContent
    {
        public string Text { get; set; }
        List<string> Sentence { get; set; }

        public FormatedText(string text)
        {
            Sentence = new List<string>();
            Text = text;
        }

        public FormatedText()
        {
        }

        public int CountWords()
        {
            int numwords = 0;
            string[] words = Text.Split(" ");
            numwords = words.Length;
            return numwords;
        }

        public string GetLengthiestWord()
        {
            string biggest = "";
            string[] words = Text.Split(" ");
            foreach (string w in words)
            {
                if (biggest.Length < w.Length)
                {
                    biggest = w;
                }
            }
            return biggest;
        }
        public bool LoadText(string filename)
        {
            try
            {
                var fileStream = new FileStream($"C:\\Users\\patro\\Desktop\\docRepos\\{filename}",
                    FileMode.Open, FileAccess.Read);
                using (var streamReader = new System.IO.StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Sentence.Add(line);
                    }
                }

                foreach (String s in Sentence)
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine(s);
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }


        public bool SaveText(string filename)
        {
            using (StreamWriter file = new StreamWriter($"C:\\Users\\patro\\Desktop\\docRepos\\{filename}"))
            {
                foreach (string s in Sentence)
                {
                    file.WriteLine(s);
                }
            }
            return true;
        }
    }
}