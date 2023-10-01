using System;

class Program
{
    static void Main()
    {
        
        Action[] menuActions = { NewGame, LoadGame, ShowRules, ShowAuthorInfo, Exit };

        while (true)
        {
            
            Console.WriteLine("Меню:");
            Console.WriteLine("0 - Новая игра");
            Console.WriteLine("1 - Загрузить игру");
            Console.WriteLine("2 - Правила");
            Console.WriteLine("3 - Об авторе");
            Console.WriteLine("4 - Выход");

            
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice <= 5 && choice < menuActions.Length)
                {
                    
                    menuActions[choice]();
                }
                else
                {
                    Console.WriteLine("Выберите корректный пункт меню.");
                }
            }
            else
            {
                Console.WriteLine("Введите число.");
            }
        }
    }

    static void NewGame()
    {
        Console.WriteLine("Начата новая игра.");
    }

    static void LoadGame()
    {
        Console.WriteLine("Загружена игра.");
    }

    static void ShowRules()
    {
        Console.WriteLine("Показываем правила игры.");
    }

    static void ShowAuthorInfo()
    {
        Console.WriteLine("Информация об автор: \tСАМЫЙ ЛЕНИВЫЙ ЧЕЛОВЕК НА ПЛАНЕТЕ");
    }

    static void Exit()
    {
        Console.WriteLine("Выход из программы.");
        Environment.Exit(0);
    }
}
