
using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public static class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO DE VISUALIZAÇÃO");
            Console.WriteLine("--------------------");
            Replace(text);
            Console.WriteLine("--------------------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            foreach (var palavra in words)
            {
                if (strong.IsMatch(palavra))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(palavra.Substring(palavra.IndexOf('>') + 1, (palavra.LastIndexOf('<') - 1) - palavra.IndexOf('>')));

                    Console.Write(' ');
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(palavra);
                    Console.Write(' ');
                }
            }
        }
    }
}