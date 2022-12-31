using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            DrawScreen();
            WriteOptions();
            try
            {
                var option = short.Parse(Console.ReadLine());
                HandleMenuOption(option);
            }
            catch
            {
                Show();
            }
        }

        public static void DrawScreen()
        {
            DrawnLines();

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");
                Console.Write("|\r\n");
            }

            DrawnLines();
        }
        public static void DrawnLines()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("+\r\n");
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("Editor HTML");

            Console.SetCursorPosition(10, 3);
            Console.WriteLine("-----------");

            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Seleciona uma opção abaixo");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");

            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir arquivo");

            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(3, 10);
            Console.Write("> ");

        }
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 0: Console.Clear(); Environment.Exit(0); break;
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                default: Show(); break;
            }
        }
    }
}